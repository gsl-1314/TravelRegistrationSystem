using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using System.Data;
using System.Windows.Forms;

namespace TravelRegistrationSystem.WinFormUI
{
    public static class ModalityConfig
    {
        private static DataSet ds;

        public static DataSet getXmlSubjectData()
        {
            ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\ModalityType.xml");
            return ds;
        }

        public static string getXmlTitle()
        {
            ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\PersonalizedCustomization.xml");
            string tempTitle="";
            foreach (DataRowView dr in ds.Tables[0].DefaultView)
            {
                tempTitle = dr["title"].ToString();
            }
            return tempTitle;
        }
        public static string getXmlCate()
        {
            ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\PersonalizedCustomization.xml");
            string tempTitle = "";
            foreach (DataRowView dr in ds.Tables[0].DefaultView)
            {
                tempTitle = dr["labelCate"].ToString();
            }
            return tempTitle;
        }
        public static string getXmlCateCount()
        {
            ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\PersonalizedCustomization.xml");
            string tempTitle = "";
            foreach (DataRowView dr in ds.Tables[0].DefaultView)
            {
                tempTitle = dr["labelCateCount"].ToString();
            }
            return tempTitle;
        }
        public static int getXmlPageSize()
        {
            ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\PersonalizedCustomization.xml");
            string tempTitle = "";
            foreach (DataRowView dr in ds.Tables[0].DefaultView)
            {
                tempTitle = dr["PageSize"].ToString();
            }
            return Convert.ToInt32(tempTitle);
        }
    }
}
