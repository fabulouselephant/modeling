using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Selenium;
using System.Data;

namespace TESTguest
{

    public class Class1
    {
        object Apl;
        string str1, str2;
        int[] v;
        double[] v1;
        double[] v2;
        double[] x; ///WARNING  x:array of double;

        //data_array: array of array of Double;
        double AP, z, z1, h, OM, OD, S, d, m, max, min, x0, x1, y0, y1, fi, poch, kin;
        int k, l, f, i, j, n, pr, xm, o, xj, xk, rozmir;
        int lIndex, lCountR, lCountC, lCount, lTMP;
        string lStr;
        double lSum, lDob, lValue, M_Data, proc_Data;
        double M_Koef, high_pr_koef, low_pr_koef, Data_CO2;
        double M_Koef_1, M_Koef_2, M_Koef_3, high_pr_koef_1, high_pr_koef_2, high_pr_koef_3, low_pr_koef_1, low_pr_koef_2, low_pr_koef_3;
        double M_H, high_pr_H, low_pr_H;
        double xt, OD_m, OD_p;
        double Gen_D, Gen_Koef, Gen_H;
        double Gen_Koef_CO2, Gen_Koef_CH4, Gen_Koef_N2O;

        public double Get_R()
        {
            j = 2;
            lCountR = 0;
            /******************
            Код Адаміва
             * ****************/
            //  while ((Apl.Workbooks[1].WorkSheets[1].Cells[j, 2]).ToString() != "")
            //{
            //     lCountR++; 
            //     j++; 
            //}
            return lCountR;
        }

        public int Get_Num(int i, int j)
        {
            /******************
            Код Адаміва
             * ****************/
            //lStr = (Apl.Workbooks[1].WorkSheets[1].Cells[i, j]).ToString();
            //lValue = Convert.ToDouble(lStr);
            //return lValue;
            return 0;
        }


        public double Gen_Data(double M_Data, double proc_data)
        {
            Random r = new Random();
            double x1, x2, a, b, sigma, data;
            a = M_Data - (2.0 * proc_data * M_Data) / 100;
            b = M_Data + (2.0 * proc_data * M_Data) / 100;
            sigma = (proc_data * M_Data) / 100 / 1.96;
            do
            {
                x1 = r.Next();
                x2 = r.Next();
                data = a + (b - a) * x1;
            }
            while (func_normal(M_Data, sigma, data) > ((1.0 / (sigma * Math.Sqrt(2.0 * Math.PI))) * x2));

            return data;

        }

        public double Gen_Normal(double M_Koef, double low_pr_koef)
        {
            Random r = new Random();
            double x1, x2, a, b, sigma, data;
            a = M_Koef - (2.0 * low_pr_koef * M_Koef) / 100.0;
            b = M_Koef + (2.0 * low_pr_koef * M_Koef) / 100.0;
            sigma = (low_pr_koef * M_Koef) / 100.0 / 1.96;
            do
            {
                x1 = r.Next();
                x2 = r.Next();
                data = a + (b - a) * x1;
            } while (func_normal(M_Koef, sigma, data) > ((1.0 / (sigma * Math.Sqrt(2.0 * Math.PI))) * x2));
           
            return data;
        }

        public double Gen_Lognormal(double M_Koef, double low_pr_koef, double hight_pr_koef)
        {
            Random r = new Random();
            double x1, x2, data, a, b, d, sigma, mp, max_data;
            b = M_Koef + (2.0 * hight_pr_koef * M_Koef) / 100.0;
            a = M_Koef - (2.0 * low_pr_koef * M_Koef) / 100.0;

            if (a < 0)
                a = 0;

            d = Math.Sqrt(Math.Pow(3.92, 2) - 4.0 * Math.Log(a / M_Koef));
            sigma = (-3.92 + d) / 2;
            mp = Math.Log(M_Koef) - Math.Pow(sigma, 2) / 2.0;
            max_data = Math.Exp(mp = Math.Pow(sigma, 2));
            do
            {
                x1 = r.Next();
                x2 = r.Next();
                data = a + (b - a) * x1;
            }
            while (func_lognormal(mp, sigma, data) > (func_lognormal(mp, sigma, max_data) * x2));

            return data;
        }




        //ФУНКЦІЯ НОРМАЛЬНОГО ЗАКОНУ РОЗПОДІЛУ
        public double func_normal(double M, double S, double X)
        {
            // M математичне сподівання;
            // S середньоквадратичне відхилення

            double m1, m2;
            m1 = S * Math.Sqrt(2.0 * Math.PI);
            m2 = Math.Exp(-(Math.Pow(X - M, 2)) / (2.0 * Math.Pow(S, 2)));
            return m2 / m1;
        }



        public double func_lognormal(double MP, double S, double X)
        {
            double m1;
            double m2;
            m1 = X * S * Math.Sqrt(2.0 * Math.PI);
            m2 = Math.Exp(-(Math.Pow(Math.Log(X) - MP, 2)) / (2.0 * Math.Pow(S, 2)));
            return m2 / m1;
        }

        //ФУНКЦІЯ ВИБОРУ ЗАКОНУ РОЗПОДІЛУ ДЛЯ КОЕФІЦІЄНТА ЕМІСІЇ СО2
        public double Gen_Koef_CO2_func(double M_Koef, double low_pr_koef, double high_pr_koef)
        {
            throw new NotImplementedException();
            double koef;
            //RB = radio button

            if (rb1.Checked)
            {
                koef = Gen_Normal(M_Koef, low_pr_koef);
            }
            if (rb2.Checked)
            {
                koef = Gen_Lognormal(M_Koef, low_pr_koef, high_pr_koef);
            }
            return koef;

        }

        //ФУНКЦІЯ ВИБОРУ ЗАКОНУ РОЗПОДІЛУ ДЛЯ КОЕФІЦІЄНТА ЕМІСІЇ СH4
        public Double Gen_Koef_CH4_func(double M_Koef, double low_pr_koef, double high_pr_koef)
        {
            double koef;
            throw new NotImplementedException();
            //RB = radio button
            if (rb7.Checked)
            {
                koef = Gen_Normal(M_Koef, low_pr_koef);
            }
            if (rb8.Checked)
            {
                koef = Gen_Lognormal(M_Koef, low_pr_koef, high_pr_koef);
            }



            return koef;
        }

        //ФУНКЦІЯ ВИБОРУ ЗАКОНУ РОЗПОДІЛУ ДЛЯ ТЕПЛОВОГО ЗНАЧЕНЯ ПАЛИВА
        public Double Gen_Koef_N2O_func(double M_Koef, double low_pr_koef, double high_pr_koef)
        {
            double koef;
            {
                if (rb9.Checked)
                {
                    koef = Gen_Normal(M_Koef, low_pr_koef);
                }
                if (rb10.Checked)
                {
                    koef = Gen_Lognormal(M_Koef, low_pr_koef, high_pr_koef);
                }
                return koef;
            }


        }

        
//--------------------------------------------
        public Double Gen_H_func(double M_H, double low_pr_H, double high_pr_H)
        {
            double koef;
            {
                if (rb11.Checked)
                {
                    koef = Gen_Normal(M_H, low_pr_H);
                }
                if (rb12.Checked)
                {
                    koef = Gen_Lognormal(M_H, low_pr_H, high_pr_H);
                }
               return  koef;
            }
        }

    }
}

