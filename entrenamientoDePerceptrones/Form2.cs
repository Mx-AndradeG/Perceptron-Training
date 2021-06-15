using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrenamientoDePerceptrones
{
    public partial class Form2 : Form
    {
        double mWO = 0, mW1 = 0, mW2 = 0 ,mfa =0;
        double[,] tVerdadAND = new double[4, 4] { { 1, 1, 1, 1 },{1,1,-1,-1},{1,-1,1,-1 },{1,-1,-1,-1}};
        double[,] tVerdadOR  = new double[4, 4] { { 1, 1, 1, 1 }, { 1, 1, -1, 1 }, { 1, -1, 1, 1 }, { 1, -1, -1, -1 } };
        double[,] tVerdadNOT = new double[2, 3] { { 1, -1, 1 }, { 1, 1, -1 } };
        string mCompuerta = "";
        int renglon = 0;

        public Form2()
        {
            InitializeComponent();
            mWO = Form1.w0;
            mW1 = Form1.w1;
            mW2 = Form1.w2;
            mfa = Form1.fa;
            mCompuerta = Form1.compuerta;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                switch (mCompuerta)
                {
                    case "AND":
                        iteracionesAnd();
                        break;
                    case "OR":
                        iteracionesOR();
                        break;
                    case "NOT":
                        iteracionesNOT();
                    break;

                    default:
                        MessageBox.Show("Compuerta invalida");
                        this.Close();
                        break;
                }
        }

        private void iteracionesAnd()
        {
            int nIteraciones = 1;
            double y = 0;
            double error = 0;

            while (renglon < 4)
            {
                double yD = tVerdadAND[renglon, 3];
                y = (mWO * tVerdadAND[renglon, 0]) + (mW1 * tVerdadAND[renglon, 1]) + (mW2 * tVerdadAND[renglon, 2]);
                if (y >= 0)
                {
                    y = 1;
                    error = yD - y;
                }
                else
                {
                    y = -1;
                    error = yD - y;
                }

                if (error == 0)
                {
                    renglon++;
                }
                else
                {
                    //RECALCULAMOS LOS PESOS SINAPTICOS
                    mWO = mWO + (mfa * error * tVerdadAND[renglon, 0]);
                    mW1 = mW1 + (mfa * error * tVerdadAND[renglon, 1]);
                    mW2 = mW2 + (mfa * error * tVerdadAND[renglon, 2]);
                    nIteraciones++;
                    renglon = 0;
                    
                }
            }
            label6.Text = "" + mWO;
            label7.Text = "" + mW1;
            lbw2r.Text = "" + mW2;
            label9.Text = "Se encontro despues de : " + nIteraciones + " iteraciones";
        }

        private void iteracionesOR() {
            int nIteraciones = 1;
            double y = 0;
            double error = 0;

            while (renglon < 4)
            {
                double yD = tVerdadOR[renglon, 3];
                y = (mWO * tVerdadOR[renglon, 0]) + (mW1 * tVerdadOR[renglon, 1]) + (mW2 * tVerdadOR[renglon, 2]);
                if (y >= 0)
                {
                    y = 1;
                    error = yD - y;
                }
                else
                {
                    y = -1;
                    error = yD - y;
                }

                if (error == 0)
                {
                    renglon++;
                }
                else
                {
                    //RECALCULAMOS LOS PESOS SINAPTICOS
                    mWO = mWO + (mfa * error * tVerdadOR[renglon, 0]);
                    mW1 = mW1 + (mfa * error * tVerdadOR[renglon, 1]);
                    mW2 = mW2 + (mfa * error * tVerdadOR[renglon, 2]);
                    nIteraciones++;
                    renglon = 0;

                }
            }
            label6.Text = "" + mWO;
            label7.Text = "" + mW1;
            lbw2r.Text = "" + mW2;
            label9.Text = "Se encontro despues de : " + nIteraciones + " iteraciones";
        }

        private void iteracionesNOT() {
            int nIteraciones = 1;
            double y = 0;
            double error = 0;

            while (renglon < 2)
            {
                double yD = tVerdadNOT[renglon, 2];
                y = (mWO * tVerdadNOT[renglon, 0]) + (mW1 * tVerdadNOT[renglon, 1]);
                if (y >= 0)
                {
                    y = 1;
                    error = yD - y;
                }
                else
                {
                    y = -1;
                    error = yD - y;
                }

                if (error == 0)
                {
                    renglon++;
                }
                else
                {
                    //RECALCULAMOS LOS PESOS SINAPTICOS
                    mWO = mWO + (mfa * error * tVerdadNOT[renglon, 0]);
                    mW1 = mW1 + (mfa * error * tVerdadNOT[renglon, 1]);
                    nIteraciones++;
                    renglon = 0;

                }
            }
            label6.Text = "" + mWO;
            label7.Text = "" + mW1;
            label9.Text = "Se encontro despues de : " + nIteraciones + " iteraciones";
        }

    }
}
