using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;

namespace wifiCon
{
    public partial class Form1 : Form
    {
        private static Wifi wifi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wifi = new Wifi();
            List<AccessPoint> aps = wifi.GetAccessPoints();
            foreach(AccessPoint ap in aps)
            {
                ListViewItem listobj = new ListViewItem(ap.Name);
                listobj.Tag = ap;
                listView1.Items.Add(listobj);
            }
        }

        private void wifiCon_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0 && wifiPass.Text.Length > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                AccessPoint ap = (AccessPoint)selectedItem.Tag;
                if (connectWifi(ap, wifiPass.Text))
                {
                    wifiStatus.Text = "网络连接成功";
                }
                else
                {
                    wifiStatus.Text = "网络连接失败";
                }
            }
            else
            {
                wifiStatus.Text = "请输入密码";
            }
            
        }


        private bool connectWifi(AccessPoint ap, string password)
        {
            AuthRequest authrequest = new AuthRequest(ap);
            authrequest.Password = password;
            return ap.Connect(authrequest);
        }

        private void wifiDis_Click(object sender, EventArgs e)
        {
            if (wifi.ConnectionStatus == WifiStatus.Connected)
            {
                wifi.Disconnect();
            }
        }
    }
}
