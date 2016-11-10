using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S_Des
{

    public partial class Form1 : Form
    {
        public string dlina8(string s)
        {
            int n = s.Length;
            if (n < 8)
            {
                for (int i = n; i < 8; i++)
                {
                    s = "0" + s;
                }
            }
            //Console.WriteLine(s);
            return s;
        }
        public string TolikShifrlau(string ashiktext, string kiltt)
        {
            //MessageBox.Show("salem");
            string wifr = ashiktext;
            //MessageBox.Show(wifr);
            string kilt = kiltt;
            /*
              S-bloktardi aniktau:S1,S2,S3
              
              */
            int[,] s1 = {
      {1,5,3,7},
      {0,6,3,2},
      {1,2,0,3},
      {4,6,1,5}
};
            int[,] s2 = {
      {4,2,1,6},
      {5,7,0,3},
      {6,5,4,2},
      {0,1,7,4}
};
            int[,] s3 = {
      {1,0,3,1},
      {2,0,0,3},
      {3,2,3,0},
      {1,0,3,1}
};

            //onjak jane soljak awik matin
            Form1 n = new Form1();
            string perestanovka1_2 = wifr.Substring(8, 8);
            string perestanovka1_1 = wifr.Substring(0, 8);
            // Console.WriteLine(perestanovka1_1+perestanovka1_2);
            String PerestonovkaIP = perestanovka1_1 + perestanovka1_2;

            //3 8 2 4 12 9 0 6 14 10 13 1 15 7 11 5

            PerestonovkaIP = PerestonovkaIP[3].ToString() + PerestonovkaIP[8].ToString() + PerestonovkaIP[2].ToString() + PerestonovkaIP[4].ToString() + PerestonovkaIP[12].ToString() + PerestonovkaIP[9].ToString() + PerestonovkaIP[0].ToString() + PerestonovkaIP[6].ToString() + PerestonovkaIP[14].ToString() + PerestonovkaIP[10].ToString() + PerestonovkaIP[13].ToString() + PerestonovkaIP[1].ToString() + PerestonovkaIP[15].ToString() + PerestonovkaIP[7].ToString() + PerestonovkaIP[11].ToString() + PerestonovkaIP[5].ToString();
            //Console.WriteLine(PerestonovkaIP);
            string rightblock = PerestonovkaIP.Substring(8, 8);
            string leftblock = PerestonovkaIP.Substring(0, 8);

           
            //cicl Doljen nachatsya sdes'
            for (int ciclraund = 0; ciclraund < 3; ciclraund++)
            {
                string rightblock12 = "";
                rightblock12 = rightblock[7].ToString() + rightblock[0].ToString() + rightblock[1].ToString() + rightblock[2].ToString() + rightblock[3].ToString() + rightblock[4].ToString() + rightblock[3].ToString() + rightblock[4].ToString() + rightblock[5].ToString() + rightblock[6].ToString() + rightblock[7].ToString() + rightblock[0].ToString();
                // Console.WriteLine(rightblock12);

                //kilt pen on bolikti XORlanu
                string EpKilt = "";
                for (int i = 0; i < 12; i++)
                {
                    if (rightblock12[i] == '0' && kilt[i] == '0')
                    {
                        EpKilt += "0";
                    }
                    if (rightblock12[i] == '1' && kilt[i] == '0')
                    {
                        EpKilt += "1";
                    }
                    if (rightblock12[i] == '0' && kilt[i] == '1')
                    {
                        EpKilt += "1";
                    }
                    if (rightblock12[i] == '1' && kilt[i] == '1')
                    {
                        EpKilt += "0";
                    }
                }
                //  Console.WriteLine(EpKilt);
                string Epkilt1 = EpKilt.Substring(0, 4);
                string Epkilt2 = EpKilt.Substring(4, 4);
                string Epkilt3 = EpKilt.Substring(8, 4);

                //Console.WriteLine(Epkilt1);
                //s block 4-3 (1wi blok)
                string Sblock1_Stroka = Epkilt1[0].ToString() + Epkilt1[3].ToString();
                string Sblock1_Stolbec = Epkilt1[1].ToString() + Epkilt1[2].ToString();

                //s block 4-3 (2wi blok)
                string Sblock2_Stroka = Epkilt2[0].ToString() + Epkilt2[3].ToString();
                string Sblock2_Stolbec = Epkilt2[1].ToString() + Epkilt2[2].ToString();

                //s block 4-2 (3wi blok)
                string Sblock3_Stroka = Epkilt3[0].ToString() + Epkilt3[3].ToString();
                string Sblock3_Stolbec = Epkilt3[1].ToString() + Epkilt3[2].ToString();
                // Console.WriteLine(kilt);

                //sootvetstvie v S-bloke soglasno Stroke-Kolonke
                //  Console.WriteLine(s1[n.StrokaBinaryToInt(Sblock1_Stroka), n.StrokaBinaryToInt(Sblock1_Stolbec)]);
                string s1Block = n.dlina3(Convert.ToString(s1[n.StrokaBinaryToInt(Sblock1_Stroka), n.StrokaBinaryToInt(Sblock1_Stolbec)], 2));
                string s2Block = n.dlina3(Convert.ToString(s2[n.StrokaBinaryToInt(Sblock2_Stroka), n.StrokaBinaryToInt(Sblock2_Stolbec)], 2));
                string s3Block = n.dlina2(Convert.ToString(s3[n.StrokaBinaryToInt(Sblock3_Stroka), n.StrokaBinaryToInt(Sblock3_Stolbec)], 2));
             
                string p = s1Block + s2Block + s3Block;
                
                String results = "";
                for (int i = 0; i < 8; i++)
                {
                    if (leftblock[i] == '0' && p[i] == '0')
                    {
                        results += "0";
                    }
                    if (leftblock[i] == '1' && p[i] == '0')
                    {
                        results += "1";
                    }
                    if (leftblock[i] == '0' && p[i] == '1')
                    {
                        results += "1";
                    }
                    if (leftblock[i] == '1' && p[i] == '1')
                    {
                        results += "0";
                    }
                }
               
                if (ciclraund != 2)
                {
                    leftblock = rightblock;
                    rightblock = results;
                }
                else
                {
                    leftblock = results;
                    
                }
            }
            String WifrResult = leftblock + rightblock;
            
            WifrResult = WifrResult[6].ToString() + WifrResult[11] + WifrResult[2] + WifrResult[0] + WifrResult[3] + WifrResult[15] + WifrResult[7] + WifrResult[13] + WifrResult[1] + WifrResult[5] + WifrResult[9] + WifrResult[14] + WifrResult[4] + WifrResult[10] + WifrResult[8] + WifrResult[12];
          
            return WifrResult;
          
        }

        public string dlina3(string s)
        {
            int n = s.Length;
            if (n < 3)
            {
                for (int i = n; i < 3; i++)
                {
                    s = "0" + s;
                }
            }
            //Console.WriteLine(s);
            return s;
        }
        public string dlina2(string s)
        {
            int n = s.Length;
            if (n < 2)
            {
                for (int i = n; i < 2; i++)
                {
                    s = "0" + s;
                }
            }
            //Console.WriteLine(s);
            return s;
        }
        public int StrokaBinaryToInt(string k)
        {

            int sum = 0;
            int s = k.Length;
            int[] temp = new int[s];
            for (int i = 0; i < s; i++)
            {
                temp[i] = (int)k[i] - 48;
                sum += (int)Math.Pow(2, s - i - 1) * temp[i];
            }

            return sum;

        }
        public string XOR3(string a, string b)
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                if (a[i] == '0' && b[i] == '0')
                {
                    result += "0";
                }
                if (a[i] == '1' && b[i] == '0')
                {
                    result += "1";
                }
                if (a[i] == '0' && b[i] == '1')
                {
                    result += "1";
                }
                if (a[i] == '1' && b[i] == '1')
                {
                    result += "0";
                }
            }
            return result;
        }
        public string XOR2(string a, string b)
        {
            string result = "";
            for (int i = 0; i < 2; i++)
            {
                if (a[i] == '0' && b[i] == '0')
                {
                    result += "0";
                }
                if (a[i] == '1' && b[i] == '0')
                {
                    result += "1";
                }
                if (a[i] == '0' && b[i] == '1')
                {
                    result += "1";
                }
                if (a[i] == '1' && b[i] == '1')
                {
                    result += "0";
                }
            }
            return result;
        }
        public string CniTabu1(string a)
        {
            string result = "";
            string katar = a.Substring(1, 2);
            string jol = a.Substring(0, 1) + a.Substring(3, 1);

            int i = 0, j = 0;
            string[,] arr =
{
   {"001","101","011","111"},
   {"000","110","011","010"},
   {"001","010","000","011"},
   {"100","110","001","101"}

};
            switch (jol)
            {
                case "00": i = 0; break;
                case "01": i = 1; break;
                case "10": i = 2; break;
                case "11": i = 3; break;
            }

            switch (katar)
            {
                case "00": j = 0; break;
                case "01": j = 1; break;
                case "10": j = 2; break;
                case "11": j = 3; break;
            }

            result = arr[i, j];
            return result;
        }
        public string CniTabu2(string a)
        {
            string result = "";
            string katar = a.Substring(1, 2);
            string jol = a.Substring(0, 1) + a.Substring(3, 1);

            int i = 0, j = 0;
            string[,] arr =
{
   {"100","010","001","110"},
   {"101","111","000","011"},
   {"110","101","100","010"},
   {"000","001","111","100"}

};
            switch (jol)
            {
                case "00": i = 0; break;
                case "01": i = 1; break;
                case "10": i = 2; break;
                case "11": i = 3; break;
            }

            switch (katar)
            {
                case "00": j = 0; break;
                case "01": j = 1; break;
                case "10": j = 2; break;
                case "11": j = 3; break;
            }

            result = arr[i, j];
            return result;
        }
        public string CniTabu3(string a)
        {
            string result = "";
            string katar = a.Substring(1, 2);
            string jol = a.Substring(0, 1) + a.Substring(3, 1);

            int i = 0, j = 0;
            string[,] arr =
{
   {"01","00","11","01"},
   {"10","00","00","11"},
   {"11","10","11","00"},
   {"01","00","11","01"}

};
            switch (jol)
            {
                case "00": i = 0; break;
                case "01": i = 1; break;
                case "10": i = 2; break;
                case "11": i = 3; break;
            }

            switch (katar)
            {
                case "00": j = 0; break;
                case "01": j = 1; break;
                case "10": j = 2; break;
                case "11": j = 3; break;
            }

            result = arr[i, j];
            return result;
        }
        public string XOR4(string a, string b)
        {
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                if (a[i] == '0' && b[i] == '0')
                {
                    result += "0";
                }
                if (a[i] == '1' && b[i] == '0')
                {
                    result += "1";
                }
                if (a[i] == '0' && b[i] == '1')
                {
                    result += "1";
                }
                if (a[i] == '1' && b[i] == '1')
                {
                    result += "0";
                }
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("salem");
            string wifr = textBox1.Text;
            //MessageBox.Show(wifr);
            string kilt = textBox3.Text;
            /*
              S-bloktardi aniktau:S1,S2,S3
              
              */
            int[,] s1 = {
      {1,5,3,7},
      {0,6,3,2},
      {1,2,0,3},
      {4,6,1,5}
};
            int[,] s2 = {
      {4,2,1,6},
      {5,7,0,3},
      {6,5,4,2},
      {0,1,7,4}
};
            int[,] s3 = {
      {1,0,3,1},
      {2,0,0,3},
      {3,2,3,0},
      {1,0,3,1}
};
           
            //onjak jane soljak awik matin
            Form1 n = new Form1();
            string perestanovka1_2 = wifr.Substring(8, 8);
            string perestanovka1_1 =wifr.Substring(0,8) ;
           // Console.WriteLine(perestanovka1_1+perestanovka1_2);
            String PerestonovkaIP = perestanovka1_1 + perestanovka1_2;
           
            //3 8 2 4 12 9 0 6 14 10 13 1 15 7 11 5

            PerestonovkaIP = PerestonovkaIP[3].ToString() + PerestonovkaIP[8].ToString() + PerestonovkaIP[2].ToString() + PerestonovkaIP[4].ToString() + PerestonovkaIP[12].ToString() + PerestonovkaIP[9].ToString() + PerestonovkaIP[0].ToString() + PerestonovkaIP[6].ToString() + PerestonovkaIP[14].ToString() + PerestonovkaIP[10].ToString() + PerestonovkaIP[13].ToString() + PerestonovkaIP[1].ToString()+PerestonovkaIP[15].ToString()+PerestonovkaIP[7].ToString()+PerestonovkaIP[11].ToString()+PerestonovkaIP[5].ToString();
            //Console.WriteLine(PerestonovkaIP);
            string  rightblock=PerestonovkaIP.Substring(8,8);
            string leftblock = PerestonovkaIP.Substring(0, 8);
            
           // Console.WriteLine(leftblock);
           // Console.WriteLine(rightblock);
           // Console.WriteLine(rightblock);
            //e-funkcia raswirenie
            /*
             dlya 12 bit:
              8 1 2 3 4 5 4 5 6 7 8 1
             * */
           // Console.WriteLine(rightblock);
            //cicl Doljen nachatsya sdes'
            for (int ciclraund = 0; ciclraund < 3; ciclraund++)
           {
               string rightblock12 = "";
                rightblock12 = rightblock[7].ToString() + rightblock[0].ToString() + rightblock[1].ToString() + rightblock[2].ToString() + rightblock[3].ToString() + rightblock[4].ToString() + rightblock[3].ToString() + rightblock[4].ToString() + rightblock[5].ToString() + rightblock[6].ToString() + rightblock[7].ToString() + rightblock[0].ToString();
               // Console.WriteLine(rightblock12);

                //kilt pen on bolikti XORlanu
                string EpKilt = "";
                for (int i = 0; i < 12; i++)
                {
                    if (rightblock12[i] == '0' && kilt[i] == '0')
                    {
                        EpKilt += "0";
                    }
                    if (rightblock12[i] == '1' && kilt[i] == '0')
                    {
                        EpKilt += "1";
                    }
                    if (rightblock12[i] == '0' && kilt[i] == '1')
                    {
                        EpKilt += "1";
                    }
                    if (rightblock12[i] == '1' && kilt[i] == '1')
                    {
                        EpKilt += "0";
                    }
                }
              //  Console.WriteLine(EpKilt);
                string Epkilt1 = EpKilt.Substring(0, 4);
                string Epkilt2 = EpKilt.Substring(4, 4);
                string Epkilt3 = EpKilt.Substring(8, 4);

                //Console.WriteLine(Epkilt1);
                //s block 4-3 (1wi blok)
                string Sblock1_Stroka = Epkilt1[0].ToString() + Epkilt1[3].ToString();
                string Sblock1_Stolbec = Epkilt1[1].ToString() + Epkilt1[2].ToString();

                //s block 4-3 (2wi blok)
                string Sblock2_Stroka = Epkilt2[0].ToString() + Epkilt2[3].ToString();
                string Sblock2_Stolbec = Epkilt2[1].ToString() + Epkilt2[2].ToString();

                //s block 4-2 (3wi blok)
                string Sblock3_Stroka = Epkilt3[0].ToString() + Epkilt3[3].ToString();
                string Sblock3_Stolbec = Epkilt3[1].ToString() + Epkilt3[2].ToString();
                // Console.WriteLine(kilt);

                //sootvetstvie v S-bloke soglasno Stroke-Kolonke
                //  Console.WriteLine(s1[n.StrokaBinaryToInt(Sblock1_Stroka), n.StrokaBinaryToInt(Sblock1_Stolbec)]);
                string s1Block = n.dlina3(Convert.ToString(s1[n.StrokaBinaryToInt(Sblock1_Stroka), n.StrokaBinaryToInt(Sblock1_Stolbec)], 2));
                string s2Block = n.dlina3(Convert.ToString(s2[n.StrokaBinaryToInt(Sblock2_Stroka), n.StrokaBinaryToInt(Sblock2_Stolbec)], 2));
                string s3Block = n.dlina2(Convert.ToString(s3[n.StrokaBinaryToInt(Sblock3_Stroka), n.StrokaBinaryToInt(Sblock3_Stolbec)], 2));
             //   Console.WriteLine(s1Block);
             //   Console.WriteLine(s2Block);
             //   Console.WriteLine(s3Block);
                string p = s1Block + s2Block + s3Block;
             //   Console.WriteLine(p);
                // Console.WriteLine(p);
                //operacia XOR s leftblock i P
                String results = "";
                for (int i = 0; i < 8; i++)
                {
                    if (leftblock[i] == '0' && p[i] == '0')
                    {
                        results += "0";
                    }
                    if (leftblock[i] == '1' && p[i] == '0')
                    {
                        results += "1";
                    }
                    if (leftblock[i] == '0' && p[i] == '1')
                    {
                        results += "1";
                    }
                    if (leftblock[i] == '1' && p[i] == '1')
                    {
                        results += "0";
                    }
                }
               // Console.WriteLine(results);
                if (ciclraund != 2)
                {
                    leftblock = rightblock;
                    rightblock = results;
                }
                else
                {
                    leftblock = results;
                    //rightblock = rightblock;
                }
            }
            String WifrResult = leftblock + rightblock;
            //Console.WriteLine(WifrResult);

            //poslednya perestonovka
         /*
          * 6 11 2 0 3 15 7 13 1 5 9 14 4 10 8 12
          */
            WifrResult=WifrResult[6].ToString()+WifrResult[11]+WifrResult[2]+WifrResult[0]+WifrResult[3]+WifrResult[15]+WifrResult[7]+WifrResult[13]+WifrResult[1]+WifrResult[5]+WifrResult[9]+WifrResult[14]+WifrResult[4]+WifrResult[10]+WifrResult[8]+WifrResult[12];
          /*  Console.WriteLine(leftblock);
            Console.WriteLine(p);
            Console.WriteLine(results);*/
         // Console.WriteLine(WifrResult);
          label2.Text = WifrResult;
         //   Console.ReadKey();
        
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string wifr = textBox2.Text;
            string kilt = textBox4.Text;
            /*
             * 0010110010010001
              S-bloktardi aniktau:S1,S2,S3
              
              */
            int[,] s1 = {
      {1,5,3,7},
      {0,6,3,2},
      {1,2,0,3},
      {4,6,1,5}
};
            int[,] s2 = {
      {4,2,1,6},
      {5,7,0,3},
      {6,5,4,2},
      {0,1,7,4}
};
            int[,] s3 = {
      {1,0,3,1},
      {2,0,0,3},
      {3,2,3,0},
      {1,0,3,1}
};
            Form1 n = new Form1();
            /* Console.Write("Shifrlau tekstin jaz:");
             wifr = Console.ReadLine();

             int left = (int)wifr[0];
             int right = (int)wifr[1];

             int mani;//bolindi kezindegi mani
             string on = "", sol = "";//eki bolikti aniktau

             // Console.WriteLine(left);
             //sol bolikti ekilikke austiru
             while (left >= 1)
             {
                 mani = left / 2;
                 sol += (left % 2).ToString();
                 left = mani;

             }
             string soljak = "";
             for (int i = sol.Length - 1; i >= 0; i--)
             {
                 soljak += sol[i];
             }
             //on bolikti ekilikke austiru 
             while (right >= 1)
             {
                 mani = right / 2;
                 on += (right % 2).ToString();
                 right = mani;

             }
             string onjak = "";
             for (int i = on.Length - 1; i >= 0; i--)
             {
                 onjak += on[i];
             }

             //onjak jane soljak awik matin
             Program n = new Program();
             string perestanovka1_1 = n.dlina8(onjak);
             string perestanovka1_2 = n.dlina8(soljak);
             String PerestonovkaIP = perestanovka1_1 + perestanovka1_2;
             //0 8 15 11 1 2 9 13 7 14 5 3 12 6 4 10 
             PerestonovkaIP = PerestonovkaIP[0].ToString() + PerestonovkaIP[8].ToString() + PerestonovkaIP[15].ToString() + PerestonovkaIP[11].ToString() + PerestonovkaIP[1].ToString() + PerestonovkaIP[2].ToString() + PerestonovkaIP[9].ToString() + PerestonovkaIP[13].ToString() + PerestonovkaIP[7].ToString() + PerestonovkaIP[14].ToString() + PerestonovkaIP[5].ToString() + PerestonovkaIP[3].ToString() + PerestonovkaIP[12].ToString() + PerestonovkaIP[6].ToString() + PerestonovkaIP[4].ToString() + PerestonovkaIP[10].ToString();
             Console.WriteLine(PerestonovkaIP);
             string rightblock = PerestonovkaIP.Substring(8, 8);
             string leftblock = PerestonovkaIP.Substring(0, 8);*/
            //Console.WriteLine(wifr);

            //perestonovka
            //3 8 2 4 12 9 0 6 14 10 13 1 15 7 11 5
            wifr = wifr[3].ToString() + wifr[8] + wifr[2] + wifr[4] + wifr[12] + wifr[9] + wifr[0] + wifr[6] + wifr[14] + wifr[10] + wifr[13] + wifr[1] + wifr[15] + wifr[7] + wifr[11] + wifr[5];
            Console.WriteLine(wifr);
            string rightblock = wifr.Substring(8, 8);
            string leftblock = wifr.Substring(0, 8);
     
            //e-funkcia raswirenie
            /*
             dlya 12 bit:
              8 1 2 3 4 5 4 5 6 7 8 1
             * */
            //cicl Doljen nachatsya sdes'
            for (int ciclraund = 0; ciclraund < 3; ciclraund++)
            {
                string rightblock12 = "";
                rightblock12 = rightblock[7].ToString() + rightblock[0].ToString() + rightblock[1].ToString() + rightblock[2].ToString() + rightblock[3].ToString() + rightblock[4].ToString() + rightblock[3].ToString() + rightblock[4].ToString() + rightblock[5].ToString() + rightblock[6].ToString() + rightblock[7].ToString() + rightblock[0].ToString();
               // Console.WriteLine(rightblock12);

                //kilt pen on bolikti XORlanu
                string EpKilt = "";
                for (int i = 0; i < 12; i++)
                {
                    if (rightblock12[i] == '0' && kilt[i] == '0')
                    {
                        EpKilt += "0";
                    }
                    if (rightblock12[i] == '1' && kilt[i] == '0')
                    {
                        EpKilt += "1";
                    }
                    if (rightblock12[i] == '0' && kilt[i] == '1')
                    {
                        EpKilt += "1";
                    }
                    if (rightblock12[i] == '1' && kilt[i] == '1')
                    {
                        EpKilt += "0";
                    }
                }
                Console.WriteLine(EpKilt);
                string Epkilt1 = EpKilt.Substring(0, 4);
                string Epkilt2 = EpKilt.Substring(4, 4);
                string Epkilt3 = EpKilt.Substring(8, 4);

                //Console.WriteLine(Epkilt1);
                //s block 4-3 (1wi blok)
                string Sblock1_Stroka = Epkilt1[0].ToString() + Epkilt1[3].ToString();
                string Sblock1_Stolbec = Epkilt1[1].ToString() + Epkilt1[2].ToString();

                //s block 4-3 (2wi blok)
                string Sblock2_Stroka = Epkilt2[0].ToString() + Epkilt2[3].ToString();
                string Sblock2_Stolbec = Epkilt2[1].ToString() + Epkilt2[2].ToString();

                //s block 4-2 (3wi blok)
                string Sblock3_Stroka = Epkilt3[0].ToString() + Epkilt3[3].ToString();
                string Sblock3_Stolbec = Epkilt3[1].ToString() + Epkilt3[2].ToString();
                // Console.WriteLine(kilt);

                //sootvetstvie v S-bloke soglasno Stroke-Kolonke
                //  Console.WriteLine(s1[n.StrokaBinaryToInt(Sblock1_Stroka), n.StrokaBinaryToInt(Sblock1_Stolbec)]);
                string s1Block = n.dlina3(Convert.ToString(s1[n.StrokaBinaryToInt(Sblock1_Stroka), n.StrokaBinaryToInt(Sblock1_Stolbec)], 2));
                string s2Block = n.dlina3(Convert.ToString(s2[n.StrokaBinaryToInt(Sblock2_Stroka), n.StrokaBinaryToInt(Sblock2_Stolbec)], 2));
                string s3Block = n.dlina2(Convert.ToString(s3[n.StrokaBinaryToInt(Sblock3_Stroka), n.StrokaBinaryToInt(Sblock3_Stolbec)], 2));
            
                string p = s1Block + s2Block + s3Block;
              
                //operacia XOR s leftblock i P
                String results = "";
                for (int i = 0; i < 8; i++)
                {
                    if (leftblock[i] == '0' && p[i] == '0')
                    {
                        results += "0";
                    }
                    if (leftblock[i] == '1' && p[i] == '0')
                    {
                        results += "1";
                    }
                    if (leftblock[i] == '0' && p[i] == '1')
                    {
                        results += "1";
                    }
                    if (leftblock[i] == '1' && p[i] == '1')
                    {
                        results += "0";
                    }
                }
                if (ciclraund != 2)
                {
                    leftblock = rightblock;
                    rightblock = results;
                }
                else
                {
                    leftblock = results;
                    //rightblock = rightblock;
                }
            }
            String WifrResult = leftblock + rightblock;
           
            //poslednya perestonovka
            /*
             * 6 11 2 0 3 15 7 13 1 5 9 14 4 10 8 12
             */
            WifrResult = WifrResult[6].ToString() + WifrResult[11] + WifrResult[2] + WifrResult[0] + WifrResult[3] + WifrResult[15] + WifrResult[7] + WifrResult[13] + WifrResult[1] + WifrResult[5] + WifrResult[9] + WifrResult[14] + WifrResult[4] + WifrResult[10] + WifrResult[8] + WifrResult[12];
          
            label5.Text = WifrResult;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //S block 1
            var dictionary1 = new Dictionary<string, string>
{
    { "0000", "001" },
    { "0001", "000" },
    { "0010", "101" },
    { "0011", "110" },
    { "0100", "011" },
    { "0101", "011" },
    { "0110", "111" },
    { "0111", "010" },
    { "1000", "001" },
    { "1001", "100" },
    { "1010", "010" },
    { "1011", "110" },
    { "1100", "000" },
    { "1101", "001" },
    { "1110", "011" },
    { "1111", "101" }
};

            Form1 n = new Form1();

            string[] deltaP_1 = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            string[] deltaC_1 = new string[] { "000", "001", "010", "011", "100", "101", "110", "111" };


            string[,] massiv1 = new string[256, 6];

            int[,] sani1 = new int[16, 4];
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 4; j++)
                {
                    sani1[i, j] = 0;
                }

            int k = 0;

            for (int i = 0; i < 16; i++)
            {

                for (int j = 0; j < 16; j++)
                {
                    //p1 p2 c1 c2 deltaP(P) deltaC(C)
                    string p1 = deltaP_1[i];
                    string p2 = deltaP_1[j];
                    string c1 = dictionary1[deltaP_1[i]];
                    string c2 = dictionary1[deltaP_1[j]];
                    string C = n.XOR3(c1, c2);
                    string P = n.XOR4(p1, p2);
                    massiv1[k, 0] = p1;
                    massiv1[k, 1] = p2;
                    massiv1[k, 2] = c1;
                    massiv1[k, 3] = c2;
                    massiv1[k, 4] = P;
                    massiv1[k, 5] = C;
                    k++;
                }

            }

            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 256; j++)
                {
                    if (deltaP_1[i] == massiv1[j, 4])
                    {
                        for (int d = 0; d < 4; d++)
                        {
                            if (deltaC_1[d] == massiv1[j, 5])
                            {
                                sani1[i, d]++;
                            }
                        }

                    }
                }

            double[,] veroyatnost1 = new double[16, 4];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    veroyatnost1[i, j] = sani1[i, j] / 128.0;
                    //Console.Write(veroyatnost[i, j] + "\t");
                }
               // Console.WriteLine();
            }

            double max1 = 0;
            int stroka1 = 0, stolbec1 = 0;
            for (int i = 1; i < 16; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (veroyatnost1[i, j] > max1)
                    {
                        max1 = veroyatnost1[i, j];
                        stroka1 = i;
                        stolbec1 = j;
                    }
                }

            }

          //  Console.WriteLine("\nMaximum= " + max1);
           // Console.WriteLine("Delta P-" + deltaP_1[stroka1]);
           // Console.WriteLine("Delta C-" + deltaC_1[stolbec1]);

            //string kilt_1_1 = "0111";
            string kilt_1_1 = textBox5.Text.Substring(0,4);

            string[,] massiv2_1 = new string[16, 2];

            Console.WriteLine();

            for (int i = 0; i < 16; i++)
            {
                massiv2_1[i, 0] = n.XOR4(deltaP_1[i], kilt_1_1);
                massiv2_1[i, 1] = n.CniTabu1(massiv2_1[i, 0]);
                //massiv2[i, 0] =deltaP[i];
                massiv2_1[i, 0] = deltaP_1[i];
                //Console.WriteLine(massiv2[i, 0] + "  " + massiv2[i, 1]);
            }

            k = 0;
            for (int i = 0; i < 16; i++)
            {

                for (int j = 0; j < 16; j++)
                {
                    //p1 p2 c1 c2 deltaP(P) deltaC(C)
                    string p1 = massiv2_1[i, 0];
                    string p2 = massiv2_1[j, 0];
                    string c1 = massiv2_1[i, 1];
                    string c2 = massiv2_1[j, 1];
                    string C = n.XOR3(c1, c2);
                    string P = n.XOR4(p1, p2);
                    massiv1[k, 0] = p1;
                    massiv1[k, 1] = p2;
                    massiv1[k, 2] = c1;
                    massiv1[k, 3] = c2;
                    massiv1[k, 4] = P;
                    massiv1[k, 5] = C;
                    k++;
                }

            }

            string[,] pari1 = new string[1, 6];
            // int number1, number2;
            int x1 = 0;
            for (int i = 0; i < 256; i++)
            {
                if (massiv1[i, 4] == deltaP_1[stroka1] && massiv1[i, 5] == deltaC_1[stolbec1])
                {

                    if (x1 < 1)
                    {
                        pari1[x1, 0] = massiv1[i, 0];
                        pari1[x1, 1] = massiv1[i, 1];
                        pari1[x1, 2] = massiv1[i, 2];
                        pari1[x1, 3] = massiv1[i, 3];
                        pari1[x1, 4] = massiv1[i, 4];
                        pari1[x1, 5] = massiv1[i, 5];
                        x1++;
                    }
                    else
                    { break; }
                }

            }
           // Console.WriteLine("\nTabilgan Jup:");
           // Console.WriteLine("P1\tP2\tC1\tC2\tDeltaP\tDeltaC");
            //for (int i = 0; i < 1; i++)
           // { Console.WriteLine(pari[i, 0] + " \t" + pari[i, 1] + " \t" + pari[i, 2] + " \t" + pari[i, 3] + " \t" + pari[i, 4] + " \t" + pari[i, 5]); }
            // Console.WriteLine(n.XOR4("1110","0011"));

          //  Console.WriteLine("\n1wi nuska (C1): " + pari[0, 2]);

            string[,] massiv3_1 = new string[16, 2] { 
    { "001","0000"  },
    { "000","0001"  },
    { "101","0010"  },
    { "110","0011" },
    {  "011","0100" },
    { "011" ,"0101"},
    { "111","0110" },
    { "010" ,"0111"},
    { "001","1000"},
    { "100","1001"},
    { "010","1010"},
    { "110","1011"},
    { "000","1100"},
    { "001","1101"},
    { "011" ,"1110"},
    { "101","1111"}
            
            };

            int jupsani1 = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_1[i, 0] == pari1[0, 2])
                {
                    jupsani1++;
                }
            }

            string[] Pjuptar1 = new string[jupsani1];
            int t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_1[i, 0] == pari1[0, 2])
                {
                    Pjuptar1[t] = massiv3_1[i, 1];
                    t++;
                }
            }

            int jupsani1_1 = 0;
            t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_1[i, 0] == pari1[0, 3])
                {
                    jupsani1_1++;
                }
            }

            string[] Pjuptar1_1 = new string[jupsani1_1];
            //  int t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_1[i, 0] == pari1[0, 3])
                {
                    Pjuptar1_1[t] = massiv3_1[i, 1];
                    t++;
                }
            }

            t = 0;
            for (int i = 0; i < jupsani1; i++)
            {
                for (int j = 0; j < jupsani1_1; j++)
                    if (pari1[0, 4] == n.XOR4(Pjuptar1[i], Pjuptar1_1[j]))
                    {
                        t++;
                    }
            }
            string[,] mumkinXter = new string[2, t];

            int w = 0;
            for (int i = 0; i < jupsani1; i++)
            {
                for (int j = 0; j < jupsani1_1; j++)
                    if (pari1[0, 4] == n.XOR4(Pjuptar1[i], Pjuptar1_1[j]))
                    {
                        mumkinXter[0, w] = Pjuptar1[i];
                        mumkinXter[1, w] = Pjuptar1_1[j];
                        w++;
                    }
            }

            string[] kiltter = new string[2 * t];
          //  Console.WriteLine("Mumkin bolatin kilt 1:");

            //mumkin kiltter jazilatin Massiv
            List<string> DainKiltter = new List<string>();
            int SblockKiltter1 = 0;
            int SblockKiltter2 = 0;
            int SblockKiltter3 = 0;

            for (int i = 0; i < t; i++)
            {
                kiltter[i] = n.XOR4(pari1[0, 0], mumkinXter[0, i]);
                listBox1.Items.Add(kiltter[i]);
                DainKiltter.Add(kiltter[i]);
                SblockKiltter1++;
               // Console.WriteLine(kiltter[i]);
            }

           // Console.WriteLine("Mumkin bolatin kilt 2:");

            for (int i = t; i < 2 * t; i++)
            {
                kiltter[i] = n.XOR4(pari1[0, 1], mumkinXter[1, i - t]);
                listBox1.Items.Add(kiltter[i]);
                DainKiltter.Add(kiltter[i]);
                SblockKiltter1++;
               // DainKiltterSani++;
               // Console.WriteLine(kiltter[i]);
            }

           // Console.ReadKey();
           

            

            //S block 2
            

            
            var dictionary2 = new Dictionary<string, string>
{
    { "0000", "100" },
    { "0001", "101" },
    { "0010", "010" },
    { "0011", "111" },
    { "0100", "001" },
    { "0101", "000" },
    { "0110", "110" },
    { "0111", "011" },
    { "1000", "110" },
    { "1001", "000" },
    { "1010", "101" },
    { "1011", "001" },
    { "1100", "100" },
    { "1101", "111" },
    { "1110", "010" },
    { "1111", "100" }
};

            //Form1 n = new Form1();

            string[] deltaP_2 = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            string[] deltaC_2 = new string[] { "000", "001", "010", "011", "100", "101", "110", "111" };


            string[,] massiv2 = new string[256, 6];

            int[,] sani2 = new int[16, 4];
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 4; j++)
                {
                    sani2[i, j] = 0;
                }

             k = 0;

            for (int i = 0; i < 16; i++)
            {

                for (int j = 0; j < 16; j++)
                {
                    //p1 p2 c1 c2 deltaP(P) deltaC(C)
                    string p1 = deltaP_2[i];
                    string p2 = deltaP_2[j];
                    string c1 = dictionary2[deltaP_2[i]];
                    string c2 = dictionary2[deltaP_2[j]];
                    string C = n.XOR3(c1, c2);
                    string P = n.XOR4(p1, p2);
                    massiv2[k, 0] = p1;
                    massiv2[k, 1] = p2;
                    massiv2[k, 2] = c1;
                    massiv2[k, 3] = c2;
                    massiv2[k, 4] = P;
                    massiv2[k, 5] = C;
                    k++;
                }

            }

            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 256; j++)
                {
                    if (deltaP_2[i] == massiv2[j, 4])
                    {
                        for (int d = 0; d < 4; d++)
                        {
                            if (deltaC_2[d] == massiv2[j, 5])
                            {
                                sani2[i, d]++;
                            }
                        }

                    }
                }

           
            double[,] veroyatnost2 = new double[16, 4];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    veroyatnost2[i, j] = sani2[i, j] / 128.0;
                    //Console.Write(veroyatnost[i, j] + "\t");
                }
                // Console.WriteLine();
            }

            double max2 = 0;
            int stroka2 = 0, stolbec2 = 0;
            for (int i = 1; i < 16; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (veroyatnost2[i, j] > max2)
                    {
                        max2 = veroyatnost2[i, j];
                        stroka2 = i;
                        stolbec2 = j;
                    }
                }

            }

            //  Console.WriteLine("\nMaximum= " + max1);
            // Console.WriteLine("Delta P-" + deltaP_1[stroka1]);
            // Console.WriteLine("Delta C-" + deltaC_1[stolbec1]);

            //string kilt_1_2 = "0010";
            string kilt_1_2 = textBox5.Text.Substring(4, 4);
            string[,] massiv2_2 = new string[16, 2];

            Console.WriteLine();

            for (int i = 0; i < 16; i++)
            {
                massiv2_2[i, 0] = n.XOR4(deltaP_2[i], kilt_1_2);
                massiv2_2[i, 1] = n.CniTabu2(massiv2_2[i, 0]);
                //massiv2[i, 0] =deltaP[i];
                massiv2_2[i, 0] = deltaP_2[i];
                //Console.WriteLine(massiv2[i, 0] + "  " + massiv2[i, 1]);
            }

            k = 0;
            for (int i = 0; i < 16; i++)
            {

                for (int j = 0; j < 16; j++)
                {
                    //p1 p2 c1 c2 deltaP(P) deltaC(C)
                    string p1 = massiv2_2[i, 0];
                    string p2 = massiv2_2[j, 0];
                    string c1 = massiv2_2[i, 1];
                    string c2 = massiv2_2[j, 1];
                    string C = n.XOR3(c1, c2);
                    string P = n.XOR4(p1, p2);
                    massiv2[k, 0] = p1;
                    massiv2[k, 1] = p2;
                    massiv2[k, 2] = c1;
                    massiv2[k, 3] = c2;
                    massiv2[k, 4] = P;
                    massiv2[k, 5] = C;
                    k++;
                }

            }

            string[,] pari2 = new string[1, 6];
            // int number1, number2;
            int x2 = 0;
            for (int i = 0; i < 256; i++)
            {
                if (massiv2[i, 4] == deltaP_2[stroka2] && massiv2[i, 5] == deltaC_2[stolbec2])
                {

                    if (x2 < 1)
                    {
                        pari2[x2, 0] = massiv2[i, 0];
                        pari2[x2, 1] = massiv2[i, 1];
                        pari2[x2, 2] = massiv2[i, 2];
                        pari2[x2, 3] = massiv2[i, 3];
                        pari2[x2, 4] = massiv2[i, 4];
                        pari2[x2, 5] = massiv2[i, 5];
                        x2++;
                    }
                    else
                    { break; }
                }

            }
            // Console.WriteLine("\nTabilgan Jup:");
            // Console.WriteLine("P1\tP2\tC1\tC2\tDeltaP\tDeltaC");
            //for (int i = 0; i < 1; i++)
            // { Console.WriteLine(pari[i, 0] + " \t" + pari[i, 1] + " \t" + pari[i, 2] + " \t" + pari[i, 3] + " \t" + pari[i, 4] + " \t" + pari[i, 5]); }
            // Console.WriteLine(n.XOR4("1110","0011"));

            //  Console.WriteLine("\n1wi nuska (C1): " + pari[0, 2]);

            string[,] massiv3_2 = new string[16, 2] { 
    { "100","0000" },
    { "101","0001"  },
    { "010","0010"  },
    { "111","0011" },
    {  "001","0100" },
    { "000" ,"0101"},
    { "110","0110" },
    { "011" ,"0111"},
    { "110","1000"},
    { "000","1001"},
    { "101","1010"},
    { "001","1011"},
    { "100","1100"},
    { "111","1101"},
    { "010" ,"1110"},
    { "100","1111"}
            
            };

            int jupsani2 = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_2[i, 0] == pari2[0, 2])
                {
                    jupsani2++;
                }
            }

            string[] Pjuptar2 = new string[jupsani2];
            t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_2[i, 0] == pari2[0, 2])
                {
                    Pjuptar2[t] = massiv3_2[i, 1];
                    t++;
                }
            }

            int jupsani1_2 = 0;
            t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_2[i, 0] == pari2[0, 3])
                {
                    jupsani1_2++;
                }
            }

            string[] Pjuptar1_2 = new string[jupsani1_2];
            t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_2[i, 0] == pari2[0, 3])
                {
                    Pjuptar1_2[t] = massiv3_2[i,1];
                    t++;
                }
            }

            t = 0;
            for (int i = 0; i < jupsani2; i++)
            {
                for (int j = 0; j < jupsani1_2; j++)
                    if (pari2[0, 4] == n.XOR4(Pjuptar2[i], Pjuptar1_2[j]))
                    {
                        t++;
                    }
            }
            string[,] mumkinXter2 = new string[2, t];

             w = 0;
            for (int i = 0; i < jupsani2; i++)
            {
                for (int j = 0; j < jupsani1_2; j++)
                    if (pari2[0, 4] == n.XOR4(Pjuptar2[i], Pjuptar1_2[j]))
                    {
                        mumkinXter2[0, w] = Pjuptar2[i];
                        mumkinXter2[1, w] = Pjuptar1_2[j];
                        w++;
                    }
            }

         


           
            string[] kiltter1 = new string[2 * t];
            //  Console.WriteLine("Mumkin bolatin kilt 1:");

            //mumkin kiltter jazilatin Massiv
           // List<string> DainKiltter = new List<string>();

            for (int i = 0; i < t; i++)
            {
                kiltter1[i] = n.XOR4(pari2[0, 0], mumkinXter2[0, i]);
                listBox2.Items.Add(kiltter1[i]);
                DainKiltter.Add(kiltter1[i]);
                SblockKiltter2++;
                // Console.WriteLine(kiltter[i]);
            }

           // Console.WriteLine("Mumkin bolatin kilt 2:");

            for (int i = t; i < 2 * t; i++)
            {
                kiltter1[i] = n.XOR4(pari2[0, 1], mumkinXter2[1, i - t]);
                listBox2.Items.Add(kiltter1[i]);
                DainKiltter.Add(kiltter1[i]);
                SblockKiltter2++;
                // DainKiltterSani++;
                // Console.WriteLine(kiltter[i]);
            }
             

            // S block 3
            var dictionary3 = new Dictionary<string, string>
{
    { "0000", "01" },
    { "0001", "10" },
    { "0010", "00" },
    { "0011", "00" },
    { "0100", "11" },
    { "0101", "00" },
    { "0110", "01" },
    { "0111", "11" },
    { "1000", "11" },
    { "1001", "01" },
    { "1010", "10" },
    { "1011", "00" },
    { "1100", "11" },
    { "1101", "11" },
    { "1110", "00" },
    { "1111", "01" }
};

            //Form1 n = new Form1();

            string[] deltaP_3 = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            string[] deltaC_3 = new string[] { "00", "01", "10", "11" 
            };


            string[,] massiv3 = new string[256, 6];

            int[,] sani3 = new int[16, 4];
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 4; j++)
                {
                    sani3[i, j] = 0;
                }

            k = 0;

            for (int i = 0; i < 16; i++)
            {

                for (int j = 0; j < 16; j++)
                {
                    //p1 p2 c1 c2 deltaP(P) deltaC(C)
                    string p1 = deltaP_3[i];
                    string p2 = deltaP_3[j];
                    string c1 = dictionary3[deltaP_3[i]];
                    string c2 = dictionary3[deltaP_3[j]];
                    string C = n.XOR2(c1, c2);
                    string P = n.XOR4(p1, p2);
                    massiv3[k, 0] = p1;
                    massiv3[k, 1] = p2;
                    massiv3[k, 2] = c1;
                    massiv3[k, 3] = c2;
                    massiv3[k, 4] = P;
                    massiv3[k, 5] = C;
                    k++;
                }

            }

            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 256; j++)
                {
                    if (deltaP_3[i] == massiv3[j, 4])
                    {
                        for (int d = 0; d < 4; d++)
                        {
                            if (deltaC_3[d] == massiv3[j, 5])
                            {
                                sani3[i, d]++;
                            }
                        }

                    }
                }


            double[,] veroyatnost3 = new double[16, 4];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    veroyatnost3[i, j] = sani3[i, j] / 16.0;
                    //Console.Write(veroyatnost[i, j] + "\t");
                }
                // Console.WriteLine();
            }

            double max3 = 0;
            int stroka3 = 0, stolbec3 = 0;
            for (int i = 1; i < 16; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (veroyatnost3[i, j] > max3)
                    {
                        max3 = veroyatnost3[i, j];
                        stroka3 = i;
                        stolbec3 = j;
                    }
                }

            }

            //  Console.WriteLine("\nMaximum= " + max1);
            // Console.WriteLine("Delta P-" + deltaP_1[stroka1]);
            // Console.WriteLine("Delta C-" + deltaC_1[stolbec1]);

           // string kilt_1_3 = "0110";
            string kilt_1_3 = textBox5.Text.Substring(8, 4);
            string[,] massiv2_3 = new string[16, 2];

           // Console.WriteLine();

            for (int i = 0; i < 16; i++)
            {
                massiv2_3[i, 0] = n.XOR4(deltaP_3[i], kilt_1_3);
                massiv2_3[i, 1] = n.CniTabu3(massiv2_3[i, 0]);
                //massiv2[i, 0] =deltaP[i];
                massiv2_3[i, 0] = deltaP_3[i];
                //Console.WriteLine(massiv2[i, 0] + "  " + massiv2[i, 1]);
            }

            k = 0;
            for (int i = 0; i < 16; i++)
            {

                for (int j = 0; j < 16; j++)
                {
                    //p1 p2 c1 c2 deltaP(P) deltaC(C)
                    string p1 = massiv2_3[i, 0];
                    string p2 = massiv2_3[j, 0];
                    string c1 = massiv2_3[i, 1];
                    string c2 = massiv2_3[j, 1];
                    string C = n.XOR2(c1, c2);
                    string P = n.XOR4(p1, p2);
                    massiv3[k, 0] = p1;
                    massiv3[k, 1] = p2;
                    massiv3[k, 2] = c1;
                    massiv3[k, 3] = c2;
                    massiv3[k, 4] = P;
                    massiv3[k, 5] = C;
                    k++;
                }

            }

            string[,] pari3 = new string[1, 6];
            // int number1, number2;
            int x3 = 0;
            for (int i = 0; i < 256; i++)
            {
                if (massiv3[i, 4] == deltaP_3[stroka3] && massiv3[i, 5] == deltaC_3[stolbec3])
                {

                    if (x3 < 1)
                    {
                        pari3[x3, 0] = massiv3[i, 0];
                        pari3[x3, 1] = massiv3[i, 1];
                        pari3[x3, 2] = massiv3[i, 2];
                        pari3[x3, 3] = massiv3[i, 3];
                        pari3[x3, 4] = massiv3[i, 4];
                        pari3[x3, 5] = massiv3[i, 5];
                        x3++;
                    }
                    else
                    { break; }
                }

            }
            // Console.WriteLine("\nTabilgan Jup:");
            // Console.WriteLine("P1\tP2\tC1\tC2\tDeltaP\tDeltaC");
            //for (int i = 0; i < 1; i++)
            // { Console.WriteLine(pari[i, 0] + " \t" + pari[i, 1] + " \t" + pari[i, 2] + " \t" + pari[i, 3] + " \t" + pari[i, 4] + " \t" + pari[i, 5]); }
            // Console.WriteLine(n.XOR4("1110","0011"));

            //  Console.WriteLine("\n1wi nuska (C1): " + pari[0, 2]);

            string[,] massiv3_3= new string[16, 2] { 
    { "01","0000"},
    { "10","0001"},
    {"00", "0010"},
    { "00","0011"},
    { "11","0100"},
    { "00","0101"},
    { "01","0110"},
    { "11","0111"},
    { "11","1000"},
    { "01","1001"},
    { "10","1010"},
    { "00","1011"},
    { "11","1100"},
    { "11","1101"},
    { "00","1110"},
    { "01","1111"}
            
            };

            int jupsani3 = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_3[i, 0] == pari3[0, 2])
                {
                    jupsani3++;
                }
            }
           // listBox3.Items.Add(jupsani3);
            string[] Pjuptar3 = new string[jupsani3];
             t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_3[i, 0] == pari3[0, 2])
                {
                    Pjuptar3[t] = massiv3_3[i, 1];
                    t++;
                }
            }

            int jupsani1_3 = 0;
            t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_3[i, 0] == pari3[0, 3])
                {
                    jupsani1_3++;
                }
            }

            string[] Pjuptar1_3 = new string[jupsani1_3];
            t = 0;
            for (int i = 0; i < 16; i++)
            {
                if (massiv3_3[i, 0] == pari3[0, 3])
                {
                    Pjuptar1_3[t] = massiv3_3[i, 1];
                    t++;
                }
            }

            t = 0;
            for (int i = 0; i < jupsani3; i++)
            {
                for (int j = 0; j < jupsani1_3; j++)
                    if (pari3[0, 4] == n.XOR4(Pjuptar3[i], Pjuptar1_3[j]))
                    {
                        t++;
                    }
            }
            string[,] mumkinXter3 = new string[2, t];

             w = 0;
            for (int i = 0; i < jupsani3; i++)
            {
                for (int j = 0; j < jupsani1_3; j++)
                    if (pari3[0, 4] == n.XOR4(Pjuptar3[i], Pjuptar1_3[j]))
                    {
                        mumkinXter3[0, w] = Pjuptar3[i];
                        mumkinXter3[1, w] = Pjuptar1_3[j];
                        w++;
                    }
            }





            string[] kiltter2 = new string[2 * t];
            //  Console.WriteLine("Mumkin bolatin kilt 1:");

            //mumkin kiltter jazilatin Massiv
            // List<string> DainKiltter = new List<string>();

            for (int i = 0; i < t; i++)
            {
                kiltter2[i] = n.XOR4(pari3[0, 0], mumkinXter3[0, i]);
                listBox3.Items.Add(kiltter2[i]);
                DainKiltter.Add(kiltter2[i]);
                SblockKiltter3++;
                // Console.WriteLine(kiltter[i]);
            }

            // Console.WriteLine("Mumkin bolatin kilt 2:");

            for (int i = t; i < 2 * t; i++)
            {
                kiltter2[i] = n.XOR4(pari3[0, 1], mumkinXter3[1, i - t]);
                listBox3.Items.Add(kiltter2[i]);
                DainKiltter.Add(kiltter2[i]);
                SblockKiltter3++;
                // DainKiltterSani++;
                // Console.WriteLine(kiltter[i]);
            }

           //dainkiltter
            int JalpiKiltSani = SblockKiltter1 + SblockKiltter2 + SblockKiltter3;
            string[] MumkinKiltter=new string[JalpiKiltSani];
            int v = 0;
            foreach (var d in DainKiltter)
            {
                MumkinKiltter[v] = d;
                v++;
            }

            List<string> FinalKiltter = new List<string>();

            for(int i=0;i<SblockKiltter1;i++)
                for (int j = SblockKiltter1; j < SblockKiltter2 + SblockKiltter1; j++)
                    for (int f = SblockKiltter2 + SblockKiltter1; f < SblockKiltter3 + SblockKiltter2 + SblockKiltter1; f++)
                    { 
                        string m=MumkinKiltter[i]+MumkinKiltter[j]+MumkinKiltter[f];
                        FinalKiltter.Add(m);
                    }

            //listBox5.Items.Add(SblockKiltter1);
            //listBox5.Items.Add(SblockKiltter2);
            //listBox5.Items.Add(SblockKiltter3);
            var WODuplicateKeys = FinalKiltter.Distinct().ToList();

            foreach (var i in WODuplicateKeys)
            {
                listBox4.Items.Add(i);
            }
            
            string negizgiKilt = textBox5.Text;
            string AshikMatin = textBox6.Text;
            string DurisShifr=TolikShifrlau(AshikMatin,negizgiKilt);
            textBox8.Text = DurisShifr;

            //List<string> ShifrlarNatijesi = new List<string>();
            k = 0;
            foreach (var i in WODuplicateKeys)
            {
                k++;
            }

            string[,] ShifrlauNatijesi=new string[k,2];
            v=0;
            foreach (var i in WODuplicateKeys)
            {
                ShifrlauNatijesi[v, 0] = TolikShifrlau(AshikMatin, i);
                listBox5.Items.Add(ShifrlauNatijesi[v, 0]);
                ShifrlauNatijesi[v, 1] = i;
                  v++;
            }

            for (int i = 0; i < k; i++)
            {
                if (DurisShifr == ShifrlauNatijesi[i, 0])
                {
                    textBox7.Text = ShifrlauNatijesi[i, 1];
                    break;
                }
            }
            
        }

       

       
    }
}
