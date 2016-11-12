using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GetDataWeb
    {
        public List<string> depositlist = new List<string> { };
        public List<string> withaw_list=new List<string> { };
        public  void init()
        {
            depositlist.Add("Total invested");
            depositlist.Add("Total Investments");
            depositlist.Add("Total invest");
            depositlist.Add("Total Deposit");
            depositlist.Add("Funds Invested");
            depositlist.Add("Deposit funds");
            depositlist.Add("Total accepted funds");
            depositlist.Add("Attracted capital");
            depositlist.Add("Total accepted");
            depositlist.Add("Accepted funds");
            depositlist.Add("Total Deposit:");

            ///
            withaw_list.Add("Total Payout");
            withaw_list.Add("Total paid");
            withaw_list.Add("Total Withdraw");
            withaw_list.Add("Total Withdrawls");
            withaw_list.Add("Total Payments");
            withaw_list.Add("Funds Paid");
            withaw_list.Add("Total Withdrawal:");
        }
        public GetDataWeb()
        {
            init();
        }
        int GetPositionDepAndWithdraw(string strinput,List<string> listdepwith)
        {
            int max = 0;
            for(int i =0;i< listdepwith.Count();i++)
            {
                string temp = listdepwith[i];
                int temp_vitri = strinput.IndexOf(temp, StringComparison.OrdinalIgnoreCase);
                if (temp_vitri > max)
                    max = temp_vitri;
            }
            return max;
        }
        public int GetRunningDay(string result)
        {
            int run = 0;
            List<int> kq = new List<int>();
            List<string> key = new List<string>();
            key.Add("Running Days");
            key.Add("DAYS ONLINE");
            key.Add("started");

            foreach (var item in key)
            {

                int tem = result.IndexOf(item, StringComparison.OrdinalIgnoreCase);
                kq.Add(tem);

            }
            return kq.Max();

        }
        public Tuple<string, string> GetDepositAndWithdraw(string url)
        {
            string result = null;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
                return Tuple.Create("", "");
            }
            //Detect cloudfare
            int detect_cloudfare = result.IndexOf("Please allow up to 5 seconds", StringComparison.OrdinalIgnoreCase);
            if (detect_cloudfare != -1)
            {
                return Tuple.Create("cloudfare", "use cookies");
            }
            /*
            int vitri_Total_invested = result.IndexOf("Total invested", StringComparison.OrdinalIgnoreCase);
            int vitri_Total_Investments = result.IndexOf("Total Investments", StringComparison.OrdinalIgnoreCase);
            int vitri_Total_invest = result.IndexOf("Total invest", StringComparison.OrdinalIgnoreCase);
            int vitri_duphong = result.IndexOf("Total Deposit", StringComparison.OrdinalIgnoreCase);
            */

            int vitridepTamthoi = GetPositionDepAndWithdraw(result,depositlist);//=Math.Max(vitri_duphong, Math.Max(vitri_Total_invest, Math.Max(vitri_Total_invested, vitri_Total_Investments)));

            /*
            int vitri_Payout = result.IndexOf("Total Payout", StringComparison.OrdinalIgnoreCase);
            int vitri_paid_duphong = result.IndexOf("Total paid", StringComparison.OrdinalIgnoreCase);            
            int vitri_with_duphong = result.IndexOf("Total Withdraw", StringComparison.OrdinalIgnoreCase);
            int vitri_withdrawls = result.IndexOf("Total Withdrawls", StringComparison.OrdinalIgnoreCase);
            int vitri_Payments = result.IndexOf("Total Payments", StringComparison.OrdinalIgnoreCase);
            */
            int vitriwithTamthoi = GetPositionDepAndWithdraw(result, withaw_list); // Math.Max(vitri_Payments,Math.Max(vitri_withdrawls, Math.Max(vitri_paid_duphong, Math.Max(vitri_Payout, vitri_with_duphong))));
           // int vitriwithTamthoi = vitri_Payout > vitri_with_duphong ? vitri_Payout : vitri_with_duphong;

            if (vitridepTamthoi == -1 || vitriwithTamthoi == -1)
            {
                return Tuple.Create("Something Wrong", "Use manul please !");
            }

            ///running days
          //  int running = GetRunningDay(result);
            string sub = "";
            string subd1 = "";
            string subd2 = "";
            string subw = "";
            string subw1 = "";
            string subw2 = "";
            if (vitridepTamthoi > 0)
            {
                int vtdolla1 = result.IndexOf("$", vitridepTamthoi);
                int vtdolla2 = result.LastIndexOf("$", vitridepTamthoi);
                int kcdolla1 = Math.Abs(vtdolla1 - vitridepTamthoi);
                int kcdolla2 = Math.Abs(vtdolla2 - vitridepTamthoi);
                if (vtdolla1 != -1)
                {
                    if (kcdolla1 <= 200)
                    {
                        int vtkethuc1 = result.IndexOf("<", vtdolla1);
                        subd1 = result.Substring(vtdolla1 + 1, vtkethuc1 - vtdolla1 - 1);
                        //modify
                        try
                        {
                            float v = float.Parse(subd1);
                        }
                        catch (Exception)
                        {

                            string resultString = Regex.Match(subd1, @"\d+\.\d+").Value;
                            subd1 = resultString;
                        }
                      
                    }
                    else
                    {
                        subd1 = "";
                    }
                }
                if (vtdolla2 != -1)
                {
                    if (kcdolla2 <= 300)
                    {
                        int vtkethuc2 = result.IndexOf("<", vtdolla2);
                        subd2 = result.Substring(vtdolla2 + 1, vtkethuc2 - vtdolla2 - 1);
                        ///mdify
                        try
                        {
                            float v = float.Parse(subd2);
                        }
                        catch (Exception)
                        {

                            string resultString = Regex.Match(subd2, @"\d+\.\d+").Value;
                            subd2 = resultString;
                        }
                    }
                    else
                    {
                        subd2 = "";
                    }
                }
                if (subd1 != "" && subd2 != "")
                {
                    float v1 = 0, v2 = 0;
                    try
                    {
                        v1 = float.Parse(subd1);
                    }
                    catch (Exception)
                    {
                        sub = subd2;

                    }

                    try
                    {
                        v2 = float.Parse(subd2);
                    }
                    catch (Exception)
                    {
                        sub = subd1;

                    }
                    if (v1 < v2 && (subd1 != sub) && (subd2 != sub))
                        sub = subd2;
                    else
                    {
                        sub = subd1 == sub ? subd2 : subd1;
                    }

                }
                else
                {
                    sub = subd1 == "" ? subd2 : subd1;
                }
            }
            if (vitriwithTamthoi > 0)
            {
                int vtdolla1 = result.IndexOf("$", vitriwithTamthoi);
                int vtdolla2 = result.LastIndexOf("$", vitriwithTamthoi);
                int kcdolla1 = Math.Abs(vtdolla1 - vitriwithTamthoi);
                int kcdolla2 = Math.Abs(vtdolla2 - vitriwithTamthoi);
                if (vtdolla1 != -1)
                {
                    if (kcdolla1 <= 200)
                    {
                        int vtkethuc1 = result.IndexOf("<", vtdolla1);
                        subw1 = result.Substring(vtdolla1 + 1, vtkethuc1 - vtdolla1 - 1);
                        //modify
                        try
                        {
                            float v = float.Parse(subw1);
                        }
                        catch (Exception)
                        {

                            string resultString = Regex.Match(subw1, @"\d+\.\d+").Value;
                            subw1 = resultString;
                        }
                    }else
                    {
                        subw1 = "";
                    }
                }
                if (vtdolla2 != -1)
                {
                    if (kcdolla2 <= 300)
                    {
                        int vtkethuc2 = result.IndexOf("<", vtdolla2);
                        subw2 = result.Substring(vtdolla2 + 1, vtkethuc2 - vtdolla2 - 1);

                        try
                        {
                            float v = float.Parse(subw2);
                        }
                        catch (Exception)
                        {

                            string resultString = Regex.Match(subw2, @"\d+\.\d+").Value;
                            subw2 = resultString;
                        }
                    }
                    else
                    {
                        subw2 = "";
                    }
                }
                if (subw1 != "" && subw2 != "")
                {
                    float v1 = 0, v2 = 0;
                    float v3 = 0;
                    try
                    {
                        v1 = float.Parse(subw1);
                        v3 = float.Parse(sub);
                    }
                    catch (Exception)
                    {
                        subw = subw2;

                    }

                    try
                    {
                        v2 = float.Parse(subw2);
                    }
                    catch (Exception)
                    {

                        subw = subw1;
                    }
                    if (v1 < v2 && (subw1 != sub) && (subw2 != sub))
                        subw = subw2;
                    else
                    {
                        subw = subw1 == sub ? subw2 : subw1;
                    }

                }
                else
                {
                    subw = subw1 == "" ? subw2 : subw1;
                }


            }
            return Tuple.Create(sub, subw);
        }
    }
}
