namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 왼쪽 리스트뷰 설정
            lvwLeftDir.View = View.Details; 
            lvwLeftDir.FullRowSelect = true; 
            lvwLeftDir.GridLines = true; 

            // 컬럼 헤더 추가
            lvwLeftDir.Columns.Add("이름", 300); 
            lvwLeftDir.Columns.Add("크기", 100); 
            lvwLeftDir.Columns.Add("수정일", 160);

            // 오른쪽도
            lvwRightDir.View = View.Details;
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;

            lvwRightDir.Columns.Add("이름", 300);
            lvwRightDir.Columns.Add("크기", 100);
            lvwRightDir.Columns.Add("수정일", 160);
        }
        private void CompareFiles()
        {
            if (lvwLeftDir.Items.Count == 0 || lvwRightDir.Items.Count == 0) return;

            // 1. 초기화: 일단 모두 단독 항목(보라색)으로 칠함
            foreach (ListViewItem item in lvwLeftDir.Items) item.ForeColor = Color.Purple;
            foreach (ListViewItem item in lvwRightDir.Items) item.ForeColor = Color.Purple;

            // 2. 왼쪽 리스트뷰를 기준으로 오른쪽과 비교
            foreach (ListViewItem leftItem in lvwLeftDir.Items)
            {
                string name = leftItem.Text;
                bool isDir = leftItem.SubItems[1].Text == "<DIR>";

                // 오른쪽 리스트뷰에서 이름과 타입(폴더/파일)이 똑같은 항목 찾기
                ListViewItem rightItem = null;
                foreach (ListViewItem item in lvwRightDir.Items)
                {
                    if (item.Text == name && (item.SubItems[1].Text == "<DIR>") == isDir)
                    {
                        rightItem = item;
                        break;
                    }
                }

                // 3. 동일한 이름의 파일/폴더가 양쪽에 다 있다면
                if (rightItem != null)
                {
                    if (isDir)
                    {
                        // 폴더의 경우 양쪽에 존재하면 그냥 검은색으로 표시
                        leftItem.ForeColor = Color.Black;
                        rightItem.ForeColor = Color.Black;
                    }
                    else
                    {
                        // 파일의 경우 기존과 동일하게 날짜 비교 (빨강/회색/검정)
                        DateTime leftDate = DateTime.Parse(leftItem.SubItems[2].Text);
                        DateTime rightDate = DateTime.Parse(rightItem.SubItems[2].Text);

                        if (leftDate == rightDate)
                        {
                            leftItem.ForeColor = Color.Black;
                            rightItem.ForeColor = Color.Black;
                        }
                        else if (leftDate > rightDate)
                        {
                            leftItem.ForeColor = Color.Red;
                            rightItem.ForeColor = Color.Gray;
                        }
                        else
                        {
                            leftItem.ForeColor = Color.Gray;
                            rightItem.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";

                // 기존 텍스트박스에 있는 경로가 유효하다면, 그곳을 시작 폴더로 설정
                if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) && Directory.Exists(txtLeftDir.Text))
                {
                    dlg.SelectedPath = txtLeftDir.Text;
                }

                // 사용자가 '확인(OK)'을 눌렀을 때
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath; // 선택한 경로를 TextBox에 표시 
                    PopulateListView(lvwLeftDir, dlg.SelectedPath); // 리스트 뷰 업데이트 함수 호출 

                    CompareFiles();
                }
            }
        }

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요."; 

                if (!string.IsNullOrWhiteSpace(txtRightDir.Text) && Directory.Exists(txtRightDir.Text))
                {
                    dlg.SelectedPath = txtRightDir.Text; 
                }

                // 사용자가 '확인(OK)'을 눌렀을 때
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath; 
                    PopulateListView(lvwRightDir, dlg.SelectedPath);

                    CompareFiles();
                }
            }
        }

        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate(); // 화면 깜빡임 방지 
            lv.Items.Clear(); // 기존 목록 지우기 

            try
            {
                // 1. 하위 폴더(디렉터리) 목록 먼저 추가 
                var dirs = Directory.EnumerateDirectories(folderPath)
                                    .Select(p => new DirectoryInfo(p))
                                    .OrderBy(d => d.Name); 

                foreach (var d in dirs)
                {
                    var item = new ListViewItem(d.Name); 
                    item.SubItems.Add("<DIR>"); // 폴더는 크기 대신 <DIR> 표시 
                    item.SubItems.Add(d.LastWriteTime.ToString("g")); // 수정일 표시 
                    lv.Items.Add(item); 
                }

                // 2. 파일 목록 추가 
                var files = Directory.EnumerateFiles(folderPath)
                                     .Select(p => new FileInfo(p))
                                     .OrderBy(f => f.Name);

                foreach (var f in files)
                {
                    var item = new ListViewItem(f.Name); 
                    item.SubItems.Add(f.Length.ToString("N0") + " 바이트"); // 파일 크기 
                    item.SubItems.Add(f.LastWriteTime.ToString("g")); // 파일 수정일
                    lv.Items.Add(item); 
                }
                // 3. 내용물 길이에 맞춰 컬럼 너비 자동 조정
                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent); 
                }
            }
                catch (Exception ex) // 접근 권한 부족 등의 예외 처리 
            {
                MessageBox.Show(this, "오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lv.EndUpdate(); // 업데이트 완료 
            }
        }

        // >>> 버튼 (왼쪽에서 오른쪽으로 복사)
        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            // 원본 리스트: lvwLeftDir, 대상 폴더 경로: txtRightDir, 원본 폴더 경로: txtLeftDir
            CopySelectedFiles(lvwLeftDir, txtRightDir, txtLeftDir);
        }

        // <<< 버튼 (오른쪽에서 왼쪽으로 복사)
        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            // 원본 리스트: lvwRightDir, 대상 폴더 경로: txtLeftDir, 원본 폴더 경로: txtRightDir
            CopySelectedFiles(lvwRightDir, txtLeftDir, txtRightDir);
        }

        private void CopySelectedFiles(ListView sourceListView, TextBox destTextBox, TextBox sourceTextBox)
        {
            string destPath = destTextBox.Text;
            string sourceDir = sourceTextBox.Text;

            if (string.IsNullOrWhiteSpace(destPath) || !Directory.Exists(destPath))
            {
                MessageBox.Show("대상 폴더를 먼저 선택해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sourceListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("복사할 항목을 먼저 선택해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (ListViewItem item in sourceListView.SelectedItems)
            {
                string itemName = item.Text;
                string sourceItemPath = Path.Combine(sourceDir, itemName);
                string destItemPath = Path.Combine(destPath, itemName);

                // ✅ 1. 폴더 복사 처리
                if (item.SubItems[1].Text == "<DIR>")
                {
                    DialogResult result = DialogResult.Yes;

                    // 덮어쓰기 로직: 대상 경로에 이미 똑같은 이름의 폴더가 있다면 묻기
                    if (Directory.Exists(destItemPath))
                    {
                        result = MessageBox.Show($"'{itemName}' 폴더가 이미 존재합니다.\n덮어쓰시겠습니까? (내용이 병합/업데이트 됩니다)",
                                                 "폴더 덮어쓰기 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DirectoryCopy(sourceItemPath, destItemPath); // 우리가 만든 마법의 폴더 복사 함수 호출!
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"폴더 복사 에러:\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // ✅ 2. 파일 복사 처리 (기존 로직과 거의 동일)
                else
                {
                    bool shouldCopy = true;

                    if (File.Exists(destItemPath))
                    {
                        DateTime sourceDate = File.GetLastWriteTime(sourceItemPath);
                        DateTime destDate = File.GetLastWriteTime(destItemPath);

                        if (destDate >= sourceDate)
                        {
                            string msg = $"대상에 동일한 이름의 파일이 있습니다.\n대상 파일이 더 신규 파일입니다. 덮어쓰시겠습니까?\n\n원본: {sourceItemPath}\n대상: {destItemPath}";
                            if (MessageBox.Show(msg, "파일 덮어쓰기 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                shouldCopy = false;
                            }
                        }
                    }

                    if (shouldCopy)
                    {
                        try
                        {
                            File.Copy(sourceItemPath, destItemPath, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"파일 복사 에러:\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            // 복사 완료 후 화면 갱신
            PopulateListView(lvwLeftDir, txtLeftDir.Text);
            PopulateListView(lvwRightDir, txtRightDir.Text);
            CompareFiles();
        }

        // 하위 폴더와 파일들을 재귀적으로 모두 복사
        private void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // 대상 폴더가 없으면 새로 만듦
            Directory.CreateDirectory(destDirName);

            // 1. 해당 폴더 안의 파일들을 모두 복사 (덮어쓰기 허용)
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, true);
            }

            // 2. 하위 폴더가 있다면, 재귀호출
            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, tempPath);
            }
        }
    }
}
