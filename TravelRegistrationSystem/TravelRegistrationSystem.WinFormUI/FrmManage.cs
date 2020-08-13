using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//add
using TravelRegistrationSystem.WinFormUI.Model;
using TravelRegistrationSystem.Domain.Abstract;
using CCWin;
using CCWin.SkinControl;
using System.Threading;
using TravelRegistrationSystem.WinFormUI.Infrastructure;
using System.Drawing;
using TravelRegistrationSystem.Domain.Entities;
using System.Text.RegularExpressions;
using System.Data;

namespace TravelRegistrationSystem.WinFormUI
{
    public partial class FrmManage :Skin_Metro
    {
        private IUserInfoRepository uInfoRepository;
        private Skin_Metro loadingFrm;
        private int PageSize = ModalityConfig.getXmlPageSize();
        private int sIndex;

        public string Modality { get { return cboModality.SelectedItem.ToString(); } }
        public string QueryName { get { return txtName.Text.ToString().Trim().Replace(" ", ""); } }
        public string QueryPhoneNum { get { return txtPhoneNum.Text.ToString().Trim().Replace(" ", ""); } }
        public int page { get { return Convert.ToInt32(cboCurrentPage.SelectedItem.ToString()); } }
        private object cellTempValue = null;                                                                //临时修改指定单元格存储量

        //使用泛型了，一些参数可根据业务需要添加。
        public FrmManage(/*IUserAdminRepository adminRepository,*/ IUserInfoRepository userInfoRepository)
        {
            //uAdminRepository = adminRepository;
            uInfoRepository = userInfoRepository;
            InitializeComponent();
        }
        //系统提供的事件——窗体加载处理
        private void FrmManage_Load(object sender, EventArgs e)
        {
            LoadController.State = "正在加载...";
            //配置文件处理
            this.lblModality.Text = ModalityConfig.getXmlCate()+":";
            this.dgvPeople.Columns[2].HeaderText = ModalityConfig.getXmlCate();
            this.btnModality.Text = ModalityConfig.getXmlCateCount();

            //处理窗口之间如何跳转
            this.Tag = WinTag.frmLogin;
            
            //处理下拉选择框
            this.cboModality.Items.Add("全部");
            UserInfoesListViewModel model = new UserInfoesListViewModel
            {
                //类初始化器
                UserInfoes = uInfoRepository.UserInfoes,
                PagingInfo = new PagingInfo()
                {
                   ItemsPerPage =PageSize,
                   TotalItems=uInfoRepository.UserInfoes.Count()
                }
            };
            //默认加载全部的数据
            this.cboCurrentPage.Items.Add("1");
            this.cboModality.SelectedIndex = 0;
            foreach (var p in model.UserInfoes)
            {
                this.cboGenderContext.Items.Add(p.gender);
            }
            RemoveRepeatItem(this.cboGenderContext);
            foreach (DataRowView dr in ModalityConfig.getXmlSubjectData().Tables[0].DefaultView)
            {
                var tempStr = dr["name"].ToString();
                this.cboModality.Items.Add(tempStr);
                this.cboModalityContext.Items.Add(tempStr);
            }
            //数据视图附加下拉选择框
            this.dgvPeople.Controls.Add(this.cboModalityContext);
            this.dgvPeople.Controls.Add(this.cboGenderContext);
            //加载完成
            LoadController.State = "加载完成...";
            Thread.Sleep(500);
            //关闭加载界面
            loadingFrm = LoadController.Close();
        }
        /// <summary>
        /// 自定义方法——删除下拉框重复的选项
        /// </summary>
        /// <param name="cbo"></param>
        private void RemoveRepeatItem(SkinComboBox cbo)
        {
            List<string> list = new List<string>();
            foreach (string s in cbo.Items)
            {
                if (!list.Contains(s))
                {
                    list.Add(s);
                }
            }
            cbo.Items.Clear();
            foreach (string s in list)
            {
                cbo.Items.Add(s);
            }
        }
        //系统提供的事件——关闭窗口时做相应的跳转
        private void FrmManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag.ToString() == WinTag.frmLogin.ToString())
            {
                //跳转到登录界面
                DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmLogin>().ShowDialog(); }));
                //DialogHelper.ShowNextDlg(new Thread(delegate() { new FrmLogin(uAdminRepository, uInfoRepository).ShowDialog(); }));
            }
            else
            {
                //跳转到形式统计界面
                LoadController.Show(typeof(FrmLoading));
                DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmModality>().ShowDialog(); }));
            }
        }
        //系统提供的事件——通过下拉选择检索  形式  记录
        private void cboModality_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboCurrentPage.SelectedIndex = 0;
            int pTotal;
            currentPagePro(out pTotal);
            this.cboCurrentPage.Items.Clear();
            for (int i = 1; i <= pTotal; i++)
            {
                this.cboCurrentPage.Items.Add("" + i);
            }
            this.cboCurrentPage.SelectedIndex = 0;
            this.lblTotal.Text = string.Format("页,共{0}页", pTotal);
        }
        //系统提供的事件——姓名、手机号模糊查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (QueryName == "" && QueryPhoneNum == "")
            {
                return;
            }
            //加载数据开始
            loadingFrm.Show();
            LoadController.State = "正在检索...";
            Thread.Sleep(500);
            UserInfoesListViewModel model = new UserInfoesListViewModel
            {
                UserInfoes = uInfoRepository.UserInfoes
                .Where(p => p.uName.Contains(QueryName) && p.phoneNum.Contains(QueryPhoneNum))
            };
            this.dgvPeople.DataSource = model.UserInfoes.ToList();
            this.panelBottom.Hide();
            //加载完成
            LoadController.State = "检索完成...";
            Thread.Sleep(500);
            //关闭加载界面
            LoadController.Close();
        }
        //系统提供的事件——处理单元格附加的下拉选择框
        private void dgvPeople_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPeople.CurrentRow == null) return;
                DataGridViewColumn column = this.dgvPeople.CurrentCell.OwningColumn;
                //单元格显示  形式  下拉列表框（形式约束）
                if (column.Name.Equals("modality"))
                {
                    cboDgvContext(this.cboModalityContext);
                }
                else
                {
                    this.cboModalityContext.Visible = false;
                }
                //单元格显示  性别  下拉列表框（性别约束）
                if (column.Name.Equals("gender"))
                {
                    cboDgvContext(this.cboGenderContext);
                }
                else
                {
                    this.cboGenderContext.Visible = false;
                }
            }
            catch
            {
                return;
            }
        }
        //自定义方法——封装附加的下拉选择框
        private void cboDgvContext(SkinComboBox myCboDgvContext)
        {
            int columnIndex = this.dgvPeople.CurrentCell.ColumnIndex;
            int rowIndex = this.dgvPeople.CurrentCell.RowIndex;
            Rectangle rect = this.dgvPeople.GetCellDisplayRectangle(columnIndex, rowIndex, false);
            myCboDgvContext.Left = rect.Left;
            myCboDgvContext.Top = rect.Top;
            myCboDgvContext.Width = rect.Width;
            myCboDgvContext.Height = rect.Height;
            //将单元格的内容显示为下拉列表的当前项
            string consultingRoom = this.dgvPeople.Rows[rowIndex].Cells[columnIndex].Value.ToString();
            int index = myCboDgvContext.Items.IndexOf(consultingRoom);
            myCboDgvContext.SelectedIndex = index;
            myCboDgvContext.Visible = true;
        }
        
        //系统提供事件——DrawItem每当需要绘制特定项/区域时发生
        private void cboModalityContext_DrawItem(object sender, DrawItemEventArgs e)
        {
            //调用DrawItem封装的代码
            cboDgvDrawItem(this.cboModality, e);
        }
        private void cboGenderContext_DrawItem(object sender, DrawItemEventArgs e)
        {
            cboDgvDrawItem(this.cboGenderContext, e);
        }
        
        //自定义方法——DrawItem封装的代码
        private void cboDgvDrawItem(SkinComboBox myCboDgvContext,DrawItemEventArgs e)
        {
            try 
            { 
            e.DrawBackground();
            e.Graphics.DrawString(myCboDgvContext.Items[e.Index].ToString(), e.Font, Brushes.Black,
                e.Bounds, StringFormat.GenericDefault);
            }
            catch
            {
                return;
            }
        }
        //系统提供的事件——下拉选择框SelectedIndex属性值更改时发生
        private void cboGenderContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            //性别
            cboDgvSelectedValue(this.cboGenderContext, this.dgvPeople);
        }

        private void cboModalityContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            //形式
            cboDgvSelectedValue(this.cboModalityContext, this.dgvPeople);
        }
        //自定义方法——封装下拉选择框 SelectedIndexChanged 事件代码
        //实现下拉选择框的选择的值 赋值到 数据视图控件相应的单元格中
        private void cboDgvSelectedValue(SkinComboBox myCboDgvContext, SkinDataGridView myDgv)
        {
            if (myDgv.CurrentCell != null)
            {
                myDgv.CurrentCell.Value = myCboDgvContext.Items[myCboDgvContext.SelectedIndex];
            }
        }

        private void cboModalityContext_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboModalityContext_SelectedIndexChanged(sender, e);
            dgvUpdateData(this.dgvPeople);
        }

        private void cboGenderContext_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboGenderContext_SelectedIndexChanged(sender, e);
            dgvUpdateData(this.dgvPeople);
        }
        //自定义方法，封装数据显示及存储
        private void dgvUpdateData(SkinDataGridView myDgv)
        {
            int currentID =Convert.ToInt32(myDgv.Rows[myDgv.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
            //修改的字段
            UserInfo userInfo = new UserInfo()
            {
                ID = currentID,
                modality = myDgv.Rows[myDgv.CurrentCell.RowIndex].Cells["modality"].Value.ToString(),
                gender = myDgv.Rows[myDgv.CurrentCell.RowIndex].Cells["gender"].Value.ToString(),
                personIDNum = myDgv.Rows[myDgv.CurrentCell.RowIndex].Cells["personIDNum"].Value.ToString(),
                phoneNum = myDgv.Rows[myDgv.CurrentCell.RowIndex].Cells["phoneNum"].Value.ToString()
            };
            //不修改的字段，赋值为之前的记录
            var tmp = uInfoRepository.UserInfoes.FirstOrDefault(p => p.ID == currentID);
            userInfo.photo = tmp.photo;
            userInfo.registrationDeadline = tmp.registrationDeadline;
            userInfo.uName = tmp.uName;
            userInfo.comment = tmp.comment;
            userInfo.age = tmp.age;
            
            if (!userInfo.IsNull())
            {
                uInfoRepository.SaveUserInfo(userInfo);
                MessageBox.Show(string.Format("{0}保存成功了", userInfo.uName));
            }
            else
            {
                return;
            }
        }
        //保存手机号、身份证号单元格
        //编辑单元格之前
        private void dgvPeople_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellTempValue = this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvPeople_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //判断编辑前后的值是否一样（是否修改了内容）
            if (Object.Equals(cellTempValue, this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            {
                return;
            }
            //手机号和身份证号有效性验证
            if (this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == string.Empty)
            {
                this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                return;
            }
            if (MessageBox.Show("确定修改?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None) != DialogResult.OK)
            {
                //如果不修改，恢复原来的值
                this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
            }
            else
            {
                //修改数据库中的数据
                DataGridViewColumn column = this.dgvPeople.CurrentCell.OwningColumn;
                string commonStr = this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (column.Name)
                {
                    case "phoneNum":
                        //手机号码
                        if (!Regex.IsMatch(commonStr, RegExpression.Phone))
                        {
                            MessageBox.Show("手机号输入错误:非法输入");
                            this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                        }
                        else
                        {
                            dgvUpdateData(this.dgvPeople);
                        }
                        break;
                    case "personIDNum":
                        //身份证号
                        if (!Regex.IsMatch(commonStr, RegExpression.ID))
                        {
                            MessageBox.Show("身份证号输入错误:非法输入");
                            this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                        }
                        else
                        {
                            dgvUpdateData(this.dgvPeople);
                        }
                        break;
                    default:
                        MessageBox.Show("只能修改科目，手机号，身份证号和性别");
                        this.dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                        break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(this.dgvPeople.Rows[this.dgvPeople.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
            if (this.dgvPeople.SelectedRows.Count == 1)
            {
                uInfoRepository.DeleteUserInfo(currentID);
                this.dgvPeople.DataSource = uInfoRepository.UserInfoes.ToList();
            }
            else
            {
                MessageBox.Show("亲，请选择一行数据");
            }
            
        }

        private void btnModality_Click(object sender, EventArgs e)
        {
            this.Tag = WinTag.frmModality;
            this.Close();
        }

        //自定义的方法，封装查询处理
        private void currentPagePro(out int pageTotal)
        {
            bool isFirstModalityItem = this.cboModality.SelectedItem.ToString() == "全部" ? true : false;
            if (isFirstModalityItem) { 
            LoadController.State = "正在检索...";
            UserInfoesListViewModel modelAll = new UserInfoesListViewModel
            {
                //类初始化器
                UserInfoes = uInfoRepository.UserInfoes
                .OrderBy(p => p.ID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = uInfoRepository.UserInfoes.Count()
                }

            };
            pageTotal = modelAll.PagingInfo.TotalPages;
            this.dgvPeople.DataSource = modelAll.UserInfoes.ToList();
            //加载完成
            LoadController.State = "检索完成...";
            Thread.Sleep(500);
            //关闭加载界面
            LoadController.Close();
            return;
            }

            LoadController.State = "正在检索...";
            UserInfoesListViewModel modelPart = new UserInfoesListViewModel
            {
                //类初始化器
                UserInfoes = uInfoRepository.UserInfoes
                .Where(p=>p.modality==Modality)
                .OrderBy(p => p.ID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = uInfoRepository.UserInfoes.Where(p=>p.modality==Modality).Count()
                }

            };
            pageTotal = modelPart.PagingInfo.TotalPages;
            this.dgvPeople.DataSource = modelPart.UserInfoes.ToList();
            //加载完成
            LoadController.State = "检索完成...";
            Thread.Sleep(500);
            //关闭加载界面
            LoadController.Close();
        }

        private void cboModality_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //该方法领先于SelectedIndexChang方法的执行
            loadingFrm.Show();
            panelBottom.Show();
        }

        private void cboCurrentPage_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            loadingFrm.Show();
            sIndex = this.cboCurrentPage.SelectedIndex;
            int pTotal;
            currentPagePro(out pTotal);
            this.cboCurrentPage.Items.Clear();
            for (int i = 1; i <= pTotal; i++)
            {
                this.cboCurrentPage.Items.Add("" + i);
            }
            this.cboCurrentPage.SelectedIndex = sIndex;
            this.lblTotal.Text = string.Format("页,共{0}页", pTotal);
        }
        

    }
}
