using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using CCWin;
using TravelRegistrationSystem.Domain.Abstract;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using TravelRegistrationSystem.WinFormUI.Infrastructure;

namespace TravelRegistrationSystem.WinFormUI
{
    public partial class FrmModality : Skin_Metro
    {
        private IUserInfoRepository uInfoRepository;

        public FrmModality(IUserInfoRepository userInfoRepository)
        {
            uInfoRepository = userInfoRepository;
            InitializeComponent();
        }

        private void FrmModality_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadController.Show(typeof(FrmLoading));
            DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmManage>().ShowDialog(); }));
        }

        private void FrmModality_Load(object sender, EventArgs e)
        {
            //加载数据开始
            LoadController.State = "正在加载...";
            Thread.Sleep(500);
            //处理配置文件
            this.Text = ModalityConfig.getXmlCateCount();
            this.lblTitle.Text = ModalityConfig.getXmlCateCount();

            //显示图例
            Font myFont = new Font("黑体", 20);
            this.chartSubject.Series.Clear();

            List<int> value = new List<int>();
            List<String> str = new List<String>();
            foreach (DataRowView dr in ModalityConfig.getXmlSubjectData().Tables[0].DefaultView)
            {
                var tempStr = dr["name"].ToString();
                var tempValue = uInfoRepository.UserInfoes.Where(p => p.modality == tempStr).ToList().Count;
                value.Add(tempValue);
                str.Add(tempStr);
            }
            Series mySeries = new Series(ModalityConfig.getXmlCateCount());
            mySeries.Points.DataBindXY(str, value);
            mySeries.IsValueShownAsLabel = true;
            mySeries.LabelForeColor = Color.Red;
            mySeries.Font = myFont;
            this.chartSubject.Series.Add(mySeries);
            this.chartSubject.DataBind();
            //加载完成
            LoadController.State = "加载完成...";
            Thread.Sleep(500);
            //关闭加载界面
            LoadController.Close();
        }
    }
}
