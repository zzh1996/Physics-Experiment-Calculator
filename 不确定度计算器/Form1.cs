using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 不确定度计算器
{
    public partial class Form1 : Form
    {
        TextBox[] tData=new TextBox[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                tData[i] = new TextBox();
                tData[i].Left = 30;
                tData[i].Top = 50 + i * 25;
                this.Controls.Add(tData[i]);
            }
            cDataCount.SelectedIndex = 0;
            cP.SelectedIndex = 2;
            cC.SelectedIndex = 0;
        }

        private void cDataCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n=cDataCount.SelectedIndex+3;
            for (int i = 0; i < n; i++)
            {
                tData[i].Visible = true;
            }
            for (int i = n; i < 10; i++)
            {
                tData[i].Visible = false;
            }
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            int n = cDataCount.SelectedIndex + 3;
            int p = cP.SelectedIndex;
            int cc=cC.SelectedIndex;
            string ptext=cP.SelectedItem.ToString();
            double[] d=new double[n]; 
            for(int i=0;i<n;i++){
                try{
                    d[i]=double.Parse(tData[i].Text);
                }catch{
                    MessageBox.Show("第" + (i + 1).ToString() + "组数据输入有误！");
                    return;
                }
            }

            string r = "";
            r += "x平均值=(";
            double xsum=0;
            for(int i=0;i<n;i++){
                if(i>0)r+="+";
                r+=d[i].ToString();
                xsum+=d[i];
            }
            r+=")/"+n.ToString()+"=";
            double xavg=xsum/n;
            r += xavg.ToString() + Environment.NewLine + Environment.NewLine; ;

            r += "x标准差=√[(";
            double xs = 0;
            for (int i = 0; i < n; i++)
            {
                if (i > 0) r += "+";
                r += "(" + d[i].ToString() + "-" + xavg.ToString()+")²";
                xs += (d[i] - xavg) * (d[i] - xavg);
            }
            r += ")/(" + n.ToString() + "-1)]=";
            double xstd = Math.Sqrt(xs / (n - 1));
            r += xstd.ToString() + Environment.NewLine + Environment.NewLine; ;

            r += "uA=σ/√n=" + xstd.ToString() + "/√" + n.ToString() + "=";
            double xu = xstd / Math.Sqrt(n);
            r += xu.ToString() + Environment.NewLine + Environment.NewLine; ;

            double[,] tpdata = {
                            {1.32,1.20,1.14,1.11,1.09,1.08,1.07,1.06},
                            {2.92,2.35,2.13,2.02,1.94,1.86,1.83,1.76},
                            {4.30,3.18,2.78,2.57,2.46,2.37,2.31,2.26},
                            {9.93,5.84,4.60,4.03,3.71,3.50,3.36,3.25}
                           };

            double[,] kpdata ={
                                 {1.183,1.559,1.645,1.715},
                                 {1.000,1.650,1.960,2.580}
                             };

            double Δ仪,Δ估;
            try{
                Δ仪 = double.Parse(tDeltaYi.Text);
                Δ估 = double.Parse(tDeltaGu.Text);
            }catch{
                MessageBox.Show("请正确填写Δ仪和Δ估！");
                return;
            }
            r += "ΔB=√(Δ仪²+Δ估²)=√(" + Δ仪.ToString() + "²+" + Δ估.ToString() + "²)=";
            double ΔB = Math.Sqrt(Δ仪 * Δ仪 + Δ估 * Δ估);
            r += ΔB.ToString() + Environment.NewLine + Environment.NewLine; ;

            r += "U" + ptext + "=√[(t" + ptext + "*uA)²+(k" + ptext + "*ΔB/C)²]=";
            double tp = tpdata[p, n - 3];
            double kp = kpdata[cc, p];
            string Ctext = (cc == 0 ? "√3" : "3");
            double C = (cc == 0 ? Math.Sqrt(3) : 3.0);
            r += "√[(" + tp.ToString() + "*" + xu.ToString() + ")²+(" + kp.ToString() + "*" + ΔB + "/"+Ctext+")²]=";
            double U = Math.Sqrt(Math.Pow(tp * xu, 2) + Math.Pow(kp * ΔB / C, 2));
            r += U.ToString() + Environment.NewLine + Environment.NewLine; ;

            r += "x=" + xavg.ToString() + "±" + U.ToString() + " ,P=" + ptext;


            tOutput.Text = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                tData[i].Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string s = Clipboard.GetText();
                char[] sep = { '\n', '\t', '\r' };
                string[] data = s.Split(sep);
                int i = 0;
                foreach (string d in data)
                {
                    if (d.Length > 0 && i < 10)
                    {
                        tData[i].Text = d;
                        i++;
                    }
                }
                for (; i < 10; i++)
                {
                    tData[i].Clear();
                }
            }
            catch
            {
                MessageBox.Show("解析剪贴板内容出错！");
                return;
            }
        }
    }
}
