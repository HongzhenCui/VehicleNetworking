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

namespace CarManager
{
    /// <summary>
    /// 创建人：崔洪振
    /// 创建时间：2016-10-18
    /// 作用：重新封装DataGridView控件
    /// </summary>
    public class NewDataGridView
    {
        Form subForm1;//子窗体，实例以“修改/编辑”为例
        Form subForm2;//子窗体，实例以“删除”为例

        public DataGridView dataGV;

        private int row = 4;
        private int column = 5;

        public NewDataGridView(Form form,Form SubForm1, Form SubForm2)
        {
            dataGV = new DataGridView();
            dataGV.ForeColor = Color.Black;
            form.Controls.Add(dataGV);
            dataGV.Height = form.Height - 135;
            dataGV.Width = form.Width - 10;

            this.subForm1 = SubForm1;
            this.subForm2 = SubForm2;
        }

        public void addDGV(int row, int column)
        {
            //dv.MouseDown += new MouseEventHandler(dv_MouseDown);
            dataGV.CellClick += new DataGridViewCellEventHandler(dataGV_CellContentClick);
            dataGV.CellPainting += new DataGridViewCellPaintingEventHandler(dataGV_CellPainting);
            //dataGV.ColumnWidthChanged += new DataGridViewColumnEventArgs(dataGV_ColumnWidthChanged);            
            dataGV.CellClick += new DataGridViewCellEventHandler(dataGV_CellClick);
            dataGV.CellMouseLeave += new DataGridViewCellEventHandler(dataGV_CellMouseLeave);
            dataGV.CellMouseEnter += new DataGridViewCellEventHandler(dataGV_CellMouseEnter);

            dataGV.Location = new Point(5, 70);

            dataGV.ColumnHeadersHeight = 30;

            //dataGridView1.RowTemplate.Height = 30;
            dataGV.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGV.EnableHeadersVisualStyles = false;
            dataGV.RowHeadersVisible = false;
            dataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGV.ReadOnly = true;
            dataGV.ColumnCount = column;


            dataGV.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Lavender;
            //FromArgb(196, 225, 255);
            //Color.Lavender;//薰衣草的淡紫色
            columnHeaderStyle.Font = new Font("宋体", 12);
            columnHeaderStyle.ForeColor = Color.Black;
            columnHeaderStyle.SelectionBackColor = Color.White;
            columnHeaderStyle.SelectionForeColor = Color.Black;
            dataGV.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//填满DataGridView

            dataGV.AllowUserToAddRows = false;
            dataGV.AllowUserToDeleteRows = false;
            dataGV.AllowUserToResizeColumns = false;
            dataGV.AllowUserToResizeRows = false;

            dataGV.BackgroundColor = Color.White;
            dataGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

        }
        /// <summary>
        /// 添加CheckBox
        /// </summary>
        /// <param name="dgv"></param>
        public void addCheckBox(DataGridView dgv)
        {
            DataGridViewCheckBoxColumn dataCheckBox = new DataGridViewCheckBoxColumn();
            dataCheckBox.Name = "select";
            dataCheckBox.HeaderText = "全选";
            dataCheckBox.ReadOnly = false;
            //dgv.Columns[0].Frozen = false;                    //可以设置为冻结列
            //dgv.Columns[1].Frozen = false;
            dgv.Columns.Insert(0, dataCheckBox);                //插入 
            dgv.Columns[0].Width = 80;
            //dataGridView1.Columns.Insert(0, dataCheckBox);    //插入  
        }

        public void dataGV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //鼠标移动到某行时更改背景色
            if (e.RowIndex >= 0)
            {
                dataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lavender;
            }
        }

        public void dataGV_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //鼠标移开时还原背景色 
            if (e.RowIndex >= 0)
            {
                dataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }


        string[] ColumnHeader = { "编号", "姓名", "年龄", "性别", "总成绩" };//它的数组的长度必须和datagridview的列数保持一致
        /// <summary>
        /// 添加表头
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="CH"></param>
        public void modifyDGVHeader(DataGridView dgv, string[] CH)
        {
            if (CH.Length == column)
            {
                for (int i = 0; i < CH.Length; i++)
                {
                    dgv.Columns[i].Name = CH[i];
                }
            }
            else
            {
                MessageBox.Show("输入的列数和数组标题不一致！");
            }

        }

        string[][] rows = { new string[] { "0001", "小吕", "28", "男", "99" }, new string[] { "0002", "小吕", "28", "男", "99" }, new string[] { "0003", "小吕", "28", "男", "99" } };
        //string[,] arr = { { "1", 2, 3, 4 }, { 4, 5, 6, 4 }, { 1, 2, 3, 4 } };
        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="dgv">传入DataGridView的对象</param>
        /// <param name="rows">要写入的二维数组数据</param>
        public void modifyDGVRow(DataGridView dgv, string[][] rows)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                dgv.Rows.Add(new DataGridViewRow());
                dgv.Rows[i].Height = 30;
                for (int j = 0; j < rows[0].Length; j++)
                {
                    dgv.Rows[i].Cells[j].Value = rows[i][j];
                }
            }

        }

        /// <summary>
        /// 追加修改列按钮，要弹出修改/编辑“窗体”
        /// </summary>
        /// <param name="dgv">要修改的DataGridView对象</param>
        public void addDGVModifyButton(DataGridView dgv)
        {

            DataGridViewButtonColumn dgv_button_col_ViewEdit = new DataGridViewButtonColumn();      //修改/编辑

            // 设定列的名字
            dgv_button_col_ViewEdit.Name = "ViewEdit";
            //dgv_button_col_ViewEdit.DefaultCellStyle=

            // 在所有按钮上表示"查看/编辑"
            dgv_button_col_ViewEdit.UseColumnTextForButtonValue = true;
            dgv_button_col_ViewEdit.Text = "查看/编辑";
            dgv_button_col_ViewEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_button_col_ViewEdit.FlatStyle = FlatStyle.Standard;
            dgv_button_col_ViewEdit.CellTemplate.Style.BackColor = Color.Lavender;
            //dgv_button_col_ViewEdit.DisplayIndex = 0;

            // 设置列标题
            dgv_button_col_ViewEdit.HeaderText = "";//“查看/编辑”

            // 向DataGridView追加
            dgv.Columns.Insert(dgv.ColumnCount, dgv_button_col_ViewEdit);       //添加“查看/编辑”列按钮

            //DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            //{
            //    buttons.HeaderText = "Sales";
            //    buttons.Text = "Sales";
            //    buttons.UseColumnTextForButtonValue = true;
            //    buttons.AutoSizeMode =
            //        DataGridViewAutoSizeColumnMode.AllCells;
            //    buttons.FlatStyle = FlatStyle.Standard;
            //    buttons.CellTemplate.Style.BackColor = Color.Honeydew;
            //    buttons.DisplayIndex = 0;
            //}

            //DataGridView1.Columns.Add(buttons);

        }

        /// <summary>
        /// 追加删除列按钮，要弹出删除“窗体”
        /// </summary>
        /// <param name="dgv">要修改的DataGridView对象</param>
        public void addDGVDelButton(DataGridView dgv)
        {
            DataGridViewButtonColumn dgv_button_col_Del = new DataGridViewButtonColumn();           //删除

            //设定列的名字
            dgv_button_col_Del.Name = "Delete";

            //在所有按钮上表示"删除"
            dgv_button_col_Del.UseColumnTextForButtonValue = true;
            dgv_button_col_Del.Text = "删除";
            dgv_button_col_Del.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_button_col_Del.FlatStyle = FlatStyle.Standard;
            dgv_button_col_Del.CellTemplate.Style.BackColor = Color.Lavender;
            //dgv_button_col_Del.DisplayIndex = 1;

            //设置列标题
            dgv_button_col_Del.HeaderText = "";//“删除”

            //向DataGridView追加
            dgv.Columns.Insert(dgv.ColumnCount, dgv_button_col_Del);            //添加“删除”列按钮

        }

        /// <summary>
        /// 合并列表头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // 假定需要将表头行第7列单元格与其左单元格合并
            if (e.ColumnIndex == (column + 2) && e.RowIndex == -1)
            {
                Rectangle re = new Rectangle(e.CellBounds.Left - dataGV.Columns[e.ColumnIndex - 1].Width,
                    e.CellBounds.Top, e.CellBounds.Width + dataGV.Columns[e.ColumnIndex - 1].Width,
                    e.CellBounds.Height);
                e.Graphics.FillRectangle(Brushes.Lavender, re);//保持和前边的颜色一致

                Pen pen = new Pen(dataGV.BackgroundColor, 1);

                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                e.Graphics.DrawLine(pen, re.X, re.Y + re.Height - 1, re.X + re.Width, re.Y + re.Height - 1);//下线

                e.Graphics.DrawLine(pen, re.X + re.Width - 1, re.Y, re.X + re.Width - 1, re.Y + re.Height);//右线

                //SizeF strSize = e.Graphics.MeasureString(dataGV.Rows[0].Cells[1].Value.ToString()
                //    + e.Value.ToString(), dataGV.Font);
                SizeF strSize = e.Graphics.MeasureString("操作", dataGV.Font);

                //e.Graphics.DrawString(dataGV.Rows[0].Cells[1].Value.ToString() + e.Value.ToString(),
                //    dataGV.Font, Brushes.Black, re.X + (re.Width - strSize.Width) / 2,
                //    re.Y + (re.Height - strSize.Height) / 2);
                e.Graphics.DrawString("操作", dataGV.Font, Brushes.Black, re.X + (re.Width - strSize.Width) / 2,
                    re.Y + (re.Height - strSize.Height) / 2);

                e.Handled = true;

            }
        }

        /// <summary>
        /// CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int count = 0;
        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)//如果单击列表头，全选．
            {

                if (count % 2 == 0)//(bool)dataGV.Rows[e.RowIndex].Cells[0].EditedFormattedValue == true
                {
                    count++;
                    for (int i = 0; i < dataGV.RowCount; i++)
                    {
                        dataGV.EndEdit();//结束编辑状态．
                        string re_value = dataGV.Rows[i].Cells[0].EditedFormattedValue.ToString();
                        dataGV.Rows[i].Cells[0].Value = "true";//如果为true则为选中,false未选中
                        dataGV.Rows[i].Selected = true;//选中整行。

                    }
                }
                else
                {
                    count--;
                    for (int i = 0; i < dataGV.RowCount; i++)
                    {
                        dataGV.EndEdit();//结束编辑状态．
                        string re_value = dataGV.Rows[i].Cells[0].EditedFormattedValue.ToString();
                        dataGV.Rows[i].Cells[0].Value = "false";//如果为true则为选中,false未选中
                        dataGV.Rows[i].Selected = false;//选中整行。

                    }
                }

            }
            else
            {
                for (int i = 0; i < dataGV.Rows.Count; i++)
                {
                    ////不是当前选中的则checkBox全部设为false
                    //if (i != e.RowIndex || dataGV.CurrentCell.ColumnIndex != 0)
                    //{
                    //    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGV.Rows[i].Cells[0];
                    //    cell.Value = false;
                    //}
                    //else
                    //{
                    //是当前选中的，要设置为互斥的
                    if ((bool)dataGV.Rows[e.RowIndex].Cells[0].EditedFormattedValue == true)
                    {
                        dataGV.Rows[e.RowIndex].Cells[0].Value = false;
                    }
                    else
                    {
                        dataGV.Rows[e.RowIndex].Cells[0].Value = true;
                    }
                    //}
                }
            }

        }

        Form SubForm;

        /// <summary>
        /// DataGridView中的Button事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV.Columns[e.ColumnIndex].Name == "ViewEdit")//跳转到“查看/编辑”窗体
            {
                //弹出对应的窗体事件
                //MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; 被点击了");
                //int rows = int.Parse(e.RowIndex.ToString());                             //点击所在的行号
                //int columns = int.Parse(e.ColumnIndex.ToString());                       //点击所在的列号
                //MessageBox.Show(rows.ToString() + ";" + columns.ToString());
                //if(subForm.Visible == false)
                //{
                //    subForm.Show();
                //}

                //if (Application.OpenForms["Form11"] != null && Application.OpenForms["Form11"].Visible == true)
                //{
                //    subForm.Visible = false;
                //}else if (Application.OpenForms["Form11"] != null && Application.OpenForms["Form11"].Visible == false)
                //{
                //    subForm.Visible = true;
                //}
                //else
                //{
                //    subForm.Show();
                //}
                helpform.control_Modify_Form(subForm1);
            }

            if (dataGV.Columns[e.ColumnIndex].Name == "Delete")//跳转到“删除”窗体
            {
                //弹出对应的窗体事件
                //MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; 被点击了");
                helpform.control_Del_Form(subForm2);
            }
        }
    }
}
