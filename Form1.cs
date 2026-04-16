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
                    item.SubItems.Add("<DIR>"); // 폴더는 크기 대신 <DIR> 표시 [cite: 617]
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
                lv.EndUpdate(); // 업데이트 완료 [cite: 646]
            }
        }
    }
}
