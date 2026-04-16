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
            // 양쪽 폴더가 모두 선택되어 리스트뷰에 항목이 있을 때만 비교를 진행
            if (lvwLeftDir.Items.Count == 0 || lvwRightDir.Items.Count == 0) return;

            // 1. 초기화: 일단 모든 항목을 '단독 파일'로 간주하고 보라색으로 칠함 
            foreach (ListViewItem item in lvwLeftDir.Items) item.ForeColor = Color.Purple;
            foreach (ListViewItem item in lvwRightDir.Items) item.ForeColor = Color.Purple;

            // 2. 왼쪽 리스트뷰를 기준으로 오른쪽 리스트뷰와 비교
            foreach (ListViewItem leftItem in lvwLeftDir.Items)
            {
                // 폴더(<DIR>)는 색상 비교에서 제외
                if (leftItem.SubItems[1].Text == "<DIR>") continue;

                string fileName = leftItem.Text;

                // 오른쪽 리스트뷰에서 똑같은 이름의 파일 찾기
                ListViewItem rightItem = null;
                foreach (ListViewItem item in lvwRightDir.Items)
                {
                    if (item.Text == fileName && item.SubItems[1].Text != "<DIR>")
                    {
                        rightItem = item;
                        break;
                    }
                }

                // 3. 동일한 이름의 파일이 양쪽에 다 있다면 
                if (rightItem != null)
                {
                    // 리스트뷰에 텍스트로 저장된 수정일 글자를 다시 시간(DateTime)으로 변환하여 비교
                    DateTime leftDate = DateTime.Parse(leftItem.SubItems[2].Text);
                    DateTime rightDate = DateTime.Parse(rightItem.SubItems[2].Text);

                    if (leftDate == rightDate)
                    {
                        // 1단계: 완전히 동일한 파일 - 양쪽 모두 검은색 
                        leftItem.ForeColor = Color.Black;
                        rightItem.ForeColor = Color.Black;
                    }
                    else if (leftDate > rightDate)
                    {
                        // 2단계: 왼쪽이 더 최신 파일 - 최신은 빨간색, 이전은 회색 
                        leftItem.ForeColor = Color.Red;
                        rightItem.ForeColor = Color.Gray;
                    }
                    else
                    {
                        // 2단계: 오른쪽이 더 최신 파일 - 최신은 빨간색, 이전은 회색 
                        leftItem.ForeColor = Color.Gray;
                        rightItem.ForeColor = Color.Red;
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
    }
}
