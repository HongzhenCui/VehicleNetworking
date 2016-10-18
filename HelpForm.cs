using System;
using CCWin;
using CCWin.SkinControl;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using CarManager.HelpForm;

namespace CarManager
{
    
    public partial class helpform : CCSkinMain
    {
        public helpform()
        {
            
            InitializeComponent();                    
            
        }



        //DataGridView dataGV;
        //public int row = 4;
        //public int column = 5;
        //public void addDGV(int row, int column)
        //{
        //    DataGridView dataGridView1 = new DataGridView();
        //    dataGV = dataGridView1;
        //    this.Controls.Add(dataGridView1);

        //    //dv.MouseDown += new MouseEventHandler(dv_MouseDown);
        //    dataGV.CellClick += new DataGridViewCellEventHandler(dataGV_CellContentClick);
        //    dataGV.CellPainting += new DataGridViewCellPaintingEventHandler(dataGV_CellPainting);
        //    //dataGV.ColumnWidthChanged += new DataGridViewColumnEventArgs(dataGV_ColumnWidthChanged);            
        //    dataGV.CellClick += new DataGridViewCellEventHandler(dataGV_CellClick);

        //    dataGridView1.Location = new Point(10, 70);
        //    dataGridView1.Height = mainWindow.Height - 120;
        //    dataGridView1.Width = mainWindow.Width - 10;

        //    dataGridView1.ColumnHeadersHeight = 30;

        //    //dataGridView1.RowTemplate.Height = 30;
        //    dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        //    dataGridView1.EnableHeadersVisualStyles = false;
        //    dataGridView1.RowHeadersVisible = false;
        //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //    dataGridView1.ReadOnly = true;
        //    dataGridView1.ColumnCount = column;


        //    dataGridView1.ColumnHeadersVisible = true;
        //    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
        //    columnHeaderStyle.BackColor = Color.Lavender;//薰衣草的淡紫色
        //    columnHeaderStyle.Font = new Font("宋体", 12);
        //    columnHeaderStyle.ForeColor = Color.Black;
        //    columnHeaderStyle.SelectionBackColor = Color.White;
        //    columnHeaderStyle.SelectionForeColor = Color.Black;
        //    dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    //dataGridView1
        //    dataGridView1.AllowUserToAddRows = false;
        //    dataGridView1.AllowUserToDeleteRows = false;
        //    dataGridView1.AllowUserToResizeColumns = false;
        //    dataGridView1.AllowUserToResizeRows = false;

        //    dataGridView1.BackgroundColor = Color.White;
        //    dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
        //    dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

        //}
        ///// <summary>
        ///// 添加CheckBox
        ///// </summary>
        ///// <param name="dgv"></param>
        //public void addCheckBox(DataGridView dgv)
        //{
        //    DataGridViewCheckBoxColumn dataCheckBox = new DataGridViewCheckBoxColumn();
        //    dataCheckBox.Name = "select";
        //    dataCheckBox.HeaderText = "选择";
        //    dataCheckBox.ReadOnly = false;
        //    //dgv.Columns[0].Frozen = false;    //可以设置为冻结列
        //    //dgv.Columns[1].Frozen = false;
        //    dgv.Columns.Insert(0, dataCheckBox);    //插入 
        //    dgv.Columns[0].Width = 80;
        //    //dataGridView1.Columns.Insert(0, dataCheckBox);    //插入  
        //}

        //string[] ColumnHeader = { "编号", "姓名", "年龄", "性别", "总成绩" };//它的数组的长度必须和datagridview的列数保持一致
        ///// <summary>
        ///// 添加表头
        ///// </summary>
        ///// <param name="dgv"></param>
        ///// <param name="CH"></param>
        //public void modifyDGVHeader(DataGridView dgv, string[] CH)
        //{
        //    if(CH.Length == column)
        //    {
        //        for (int i = 0; i < CH.Length; i++)
        //        {
        //            dgv.Columns[i].Name = CH[i];
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("输入的列数和数组标题不一致！");
        //    }

        //}

        //string[][] rows = { new string[]{ "0001", "小吕", "28", "男", "99" }, new string[]{ "0002", "小吕", "28", "男", "99" }, new string[]{ "0003", "小吕", "28", "男", "99" } };
        ////string[,] arr = { { "1", 2, 3, 4 }, { 4, 5, 6, 4 }, { 1, 2, 3, 4 } };
        ///// <summary>
        ///// 写入数据
        ///// </summary>
        ///// <param name="dgv"></param>
        ///// <param name="rows"></param>
        //public void modifyDGVRow(DataGridView dgv, string[][] rows)
        //{
        //    for(int i = 0; i < rows.Length; i++)
        //    {
        //        dgv.Rows.Add(new DataGridViewRow());
        //        dgv.Rows[i].Height = 30;
        //        for (int j = 0; j < rows[0].Length; j++)
        //        {
        //            dgv.Rows[i].Cells[j].Value = rows[i][j];
        //        }
        //    }

        //}

        ///// <summary>
        ///// 追加修改列按钮，要弹出修改/编辑“窗体”
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void addDGVModifyButton(DataGridView dgv)
        //{

        //    DataGridViewButtonColumn dgv_button_col_ViewEdit = new DataGridViewButtonColumn();      //修改/编辑

        //    // 设定列的名字
        //    dgv_button_col_ViewEdit.Name = "ViewEdit";

        //    // 在所有按钮上表示"查看/编辑"
        //    dgv_button_col_ViewEdit.UseColumnTextForButtonValue = true;
        //    dgv_button_col_ViewEdit.Text = "查看/编辑";

        //    // 设置列标题
        //    dgv_button_col_ViewEdit.HeaderText = "";//“查看/编辑”

        //    // 向DataGridView追加
        //    dgv.Columns.Insert(dgv.ColumnCount, dgv_button_col_ViewEdit);       //添加“查看/编辑”列按钮

        //}

        ///// <summary>
        ///// 追加删除列按钮，要弹出删除“窗体”
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void addDGVDelButton(DataGridView dgv)
        //{
        //    DataGridViewButtonColumn dgv_button_col_Del = new DataGridViewButtonColumn();           //删除

        //    //设定列的名字
        //    dgv_button_col_Del.Name = "Delete";

        //    //在所有按钮上表示"删除"
        //    dgv_button_col_Del.UseColumnTextForButtonValue = true;
        //    dgv_button_col_Del.Text = "删除";

        //    //设置列标题
        //    dgv_button_col_Del.HeaderText = "";//“删除”

        //    //向DataGridView追加
        //    dgv.Columns.Insert(dgv.ColumnCount, dgv_button_col_Del);            //添加“删除”列按钮

        //}

        ///// <summary>
        ///// 合并列表头
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>

        //private void dataGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    // 假定需要将表头行第7列单元格与其左单元格合并
        //    if (e.ColumnIndex == (column+2) && e.RowIndex == -1)
        //    {
        //        Rectangle re = new Rectangle(e.CellBounds.Left - dataGV.Columns[e.ColumnIndex - 1].Width,
        //            e.CellBounds.Top, e.CellBounds.Width + dataGV.Columns[e.ColumnIndex - 1].Width,
        //            e.CellBounds.Height);
        //        e.Graphics.FillRectangle(Brushes.Lavender, re);//保持和前边的颜色一致

        //        Pen pen = new Pen(dataGV.BackgroundColor, 1);

        //        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

        //        e.Graphics.DrawLine(pen, re.X, re.Y + re.Height - 1, re.X + re.Width, re.Y + re.Height - 1);//下线

        //        e.Graphics.DrawLine(pen, re.X + re.Width - 1, re.Y, re.X + re.Width - 1, re.Y + re.Height);//右线

        //        //SizeF strSize = e.Graphics.MeasureString(dataGV.Rows[0].Cells[1].Value.ToString()
        //        //    + e.Value.ToString(), dataGV.Font);
        //        SizeF strSize = e.Graphics.MeasureString("操作", dataGV.Font);

        //        //e.Graphics.DrawString(dataGV.Rows[0].Cells[1].Value.ToString() + e.Value.ToString(),
        //        //    dataGV.Font, Brushes.Black, re.X + (re.Width - strSize.Width) / 2,
        //        //    re.Y + (re.Height - strSize.Height) / 2);
        //        e.Graphics.DrawString("操作",dataGV.Font, Brushes.Black, re.X + (re.Width - strSize.Width) / 2,
        //            re.Y + (re.Height - strSize.Height) / 2);

        //        e.Handled = true;

        //    }
        //}

        //private void dataGV_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        //{
        //    dataGV.Columns[1].Visible = false;
        //    dataGV.Columns[1].Visible = true;
        //}



        /////// <summary>
        /////// 当勾选CheckBox时高亮显示勾选行
        /////// </summary>
        /////// <param name="sender"></param>
        /////// <param name="e"></param>
        ////private void dataGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        ////{
        ////    if (dataGV.Columns[e.ColumnIndex].Name == "select")
        ////    {

        ////        if ((Boolean)dataGV.Rows[e.RowIndex].Cells["select"].Value)
        ////        {
        ////            dataGV.Rows[e.RowIndex].Selected = true;
        ////            dataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(224, 240, 252);//Color.PaleGreen;
        ////        }
        ////        else
        ////        {
        ////            dataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        ////        }
        ////    }
        ////}

        ///// <summary>
        ///// CheckBox
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    for (int i = 0; i < dataGV.Rows.Count; i++)
        //    {
        //        //不是当前选中的则checkBox全部设为false
        //        if (i != e.RowIndex && dataGV.CurrentCell.ColumnIndex == 0)
        //        {
        //            DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGV.Rows[i].Cells[0];
        //            cell.Value = false;
        //        }
        //        else
        //        {
        //            //是当前选中的，要设置为互斥的
        //            if ((bool)dataGV.Rows[e.RowIndex].Cells[0].EditedFormattedValue == true)
        //            {
        //                dataGV.Rows[e.RowIndex].Cells[0].Value = false;
        //            }
        //            else
        //            {
        //                dataGV.Rows[e.RowIndex].Cells[0].Value = true;
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// DataGridView中的Button事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGV.Columns[e.ColumnIndex].Name == "ViewEdit")//跳转到“查看/编辑”窗体
        //    {
        //        MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; 被点击了");
        //        //int rows = int.Parse(e.RowIndex.ToString());                             //点击所在的行号
        //        //int columns = int.Parse(e.ColumnIndex.ToString());                       //点击所在的列号

        //        //MessageBox.Show(rows.ToString() + ";" + columns.ToString());
        //    }

        //    if (dataGV.Columns[e.ColumnIndex].Name == "Delete")//跳转到“删除”窗体
        //    {
        //        MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; 被点击了");
        //    }
        //}

        //private void button1_Click(object sender, MouseEventArgs e)
        //{
        //    System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
        //    button.Location = new Point(button.Location.X + e.Location.X, button.Location.Y + e.Location.Y);
        //}
		
		/*************************************测试NewDataGridView类的代码****************************************************************/
        Form11 form11;
        Form22 form22;
        private void HelpForm_Load(object sender, EventArgs e)
        {
            int row = 4;
            int column = 5;
            
            NewDataGridView ndgv = new NewDataGridView(this, form11, form22);
            ndgv.addDGV(row, column);
            string[] ColumnHeader = { "编号", "姓名", "年龄", "性别", "总成绩" };//它的数组的长度必须和datagridview的列数保持一致
            ndgv.modifyDGVHeader(ndgv.dataGV, ColumnHeader);
            //    addDGV(row, column);
            //    modifyDGVHeader(dataGV, ColumnHeader);
            string[][] rows = { new string[] { "0001", "小吕", "28", "男", "99" }, new string[] { "0002", "小吕", "28", "男", "99" }, new string[] { "0003", "小吕", "28", "男", "99" } };
            ndgv.modifyDGVRow(ndgv.dataGV, rows);
            ndgv.addCheckBox(ndgv.dataGV);
            ndgv.addDGVModifyButton(ndgv.dataGV);
            ndgv.addDGVDelButton(ndgv.dataGV);
        }

        public static void control_Modify_Form(Form form11)
        {
            form11 = new Form11();//“修改/编辑”窗体
            form11.Show();
            //form11.Visible = true;
        }

        public static void control_Del_Form(Form form22)
        {
            form22 = new Form22();//“删除”窗体
            form22.Show();
        }
		
		/*************************************测试NewDataGridView类的代码****************************************************************/

        private  void FormReSize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Visible = false;
        }

        private void OnClose(object sender,EventArgs e)
        {
            if (mainWindow == null) return;

           mainWindow.taskManager.Delete(this.Name);
           mainWindow.formManager.DeleteForm(this.Name);
        }

        //主窗口访问接口
        public MainWindow MainWindow
        {
            get
            {
                return mainWindow;
            }

            set
            {
                mainWindow = value;
            }
        }
        //主窗口
        private MainWindow mainWindow;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.LinkVisited == false)
            {
                linkLabel1.LinkVisited = true;
                richTextBox1.Visible = true;
            }
            else
            {
                linkLabel1.LinkVisited = false;
                richTextBox1.Visible = false;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel2.LinkVisited == false)
            {
                linkLabel2.LinkVisited = true;
                richTextBox1.Visible = true;
            }
            else
            {
                linkLabel2.LinkVisited = false;
                richTextBox1.Visible = false;
            }
        }


    }

    class help_form : RegisterForm
    {
        public help_form()
        {
            FormType1 = "help_form";
        }

        override public CCSkinMain CreateForm(MainWindow mainWindow)
        {
            helpform temp = new helpform();
            temp.MainWindow = mainWindow;
            temp.TopLevel = false;
            temp.Parent = mainWindow.desktop_main;
            temp.StartPosition = FormStartPosition.CenterScreen;
            return temp;
        }
    }
}
