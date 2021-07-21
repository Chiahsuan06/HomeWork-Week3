using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseLicenseTax
{
    public partial class LicenseTax : Form
    {
        public LicenseTax()
        {
            InitializeComponent();
        }
        private void LicenseTax_Load(object sender, EventArgs e)
        {

        }
        #region 使用期間
        private void radioButtonYear_Click(object sender, EventArgs e)  //依年度
        {
            this.groupBox1.Visible = false;
        }
        private void radioButtonPeriod_Click(object sender, EventArgs e)  //依期間
        {
            this.groupBox1.Visible = true;
        }

        #region 選日期
        private void txtdate1_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.txtdate1.Text = this.dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }
        private void dateTimePicker1_CloseUp(object sender, EventArgs e)  //收起
        {
            this.dateTimePicker1.Visible = false;
        }

        private void txtdate2_Click(object sender, EventArgs e)
        {
            this.dateTimePicker2.Visible = true;
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.txtdate2.Text = this.dateTimePicker2.Value.ToString("yyyy/MM/dd");
        }
        private void dateTimePicker2_CloseUp(object sender, EventArgs e)  //收起
        {
            this.dateTimePicker2.Visible = false;
        }

        #endregion

        #endregion
        #region 用途
        private void cmbUse_SelectedIndexChanged(object sender, EventArgs e)  //選擇車種對應到CC數選單
        {
            string item = this.cmbUse.Text;
            if (item == "機車")
            {
                this.cmbCCscooter.Visible = true; 
                this.cmbCCtruck.Visible = false; 
                this.cmbCCcoach.Visible = false; 
                this.cmbCCcar.Visible = false; 
                this.cmbCCBusinesscar.Visible = false;
                this.comboBox1.Visible = false;
            }
            else if (item == "貨車")
            {
                this.cmbCCscooter.Visible = false; 
                this.cmbCCtruck.Visible = true; 
                this.cmbCCcoach.Visible = false; 
                this.cmbCCcar.Visible = false; 
                this.cmbCCBusinesscar.Visible = false;
                this.comboBox1.Visible = false;
            }
            else if (item == "大客車")
            {
                this.cmbCCscooter.Visible = false; 
                this.cmbCCtruck.Visible = false; 
                this.cmbCCcoach.Visible = true; 
                this.cmbCCcar.Visible = false; 
                this.cmbCCBusinesscar.Visible = false;
                this.comboBox1.Visible = false;
            }
            else if (item == "自用小客車")
            {
                this.cmbCCscooter.Visible = false; 
                this.cmbCCtruck.Visible = false; 
                this.cmbCCcoach.Visible = false; 
                this.cmbCCcar.Visible = true; 
                this.cmbCCBusinesscar.Visible = false;
                this.comboBox1.Visible = false;
            }
            else if (item == "營業用小客車")
            {
                this.cmbCCscooter.Visible = false; 
                this.cmbCCtruck.Visible = false; 
                this.cmbCCcoach.Visible = false; 
                this.cmbCCcar.Visible = false; 
                this.cmbCCBusinesscar.Visible = true;
                this.comboBox1.Visible = false;
            }
        }
        #endregion
        #region 確認送出
        private void butSend_Click(object sender, EventArgs e)   //確認送出
        {
            if (cmbUse.SelectedIndex == -1) //沒選擇 用途 跳出提醒
            {
                MessageBox.Show("~~請選擇 用途 ~~");
            }
            else if (cmbCCscooter.SelectedIndex == -1 && cmbCCtruck.SelectedIndex == -1 &&
                     cmbCCcoach.SelectedIndex == -1 && cmbCCcar.SelectedIndex == -1 && cmbCCBusinesscar.SelectedIndex == -1)  //沒選擇 汽缸CC數／馬達馬力 跳出提醒
            {
                MessageBox.Show("~~請選擇 汽缸CC數／馬達馬力 ~~");
            }
            else if (radioButtonYear.Checked)
            {
                int result = (int)TaxCCCalculate() * DayOfYear() / DayOfYear();
                this.lblresult.Visible = true;
                this.lblresult.Text =
                    $"使用期間 : {DateTime.Now.Year}.01.01 ~ {DateTime.Now.Year}.12.31 \n計算天數 : {DayOfYear()}天\n用途 : {cmbUse.SelectedItem}\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                    $"\n計算公式 : {TaxCCCalculate()} * {DayOfYear()} / {DayOfYear()} = {result}" + $"\n應納稅額 : 共 {result} 元";  
            }
            else
            {
                int result = (int)TaxCCCalculate() * DayOfPeriod() / DayOfYear();
                //this.lblresult.Text =
                //    $"使用期間 :  \n計算天數 :  天 \n用途 : {cmbUse.SelectedItem} \n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                //    $"\n計算公式 : {TaxCCCalculate()} * {DayOfYear()} / {DayOfYear()} = {result}" + $" \n應納稅額 : 共 {result} 元";
                this.lblresult.Visible = true;
                if (this.dateTimePicker1.Value.Year == this.dateTimePicker2.Value.Year) //同年
                {
                    if (this.dateTimePicker1.Value < this.dateTimePicker2.Value) //判斷填入日期 大於前面
                    {
                        this.lblresult.Text =
                        $"使用期間 : {this.dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {this.dateTimePicker2.Value.ToString("yyyy/MM/dd")} \n計算天數 : {DayOfPeriod()}天\n用途 : {cmbUse.SelectedItem}\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                        $"\n計算公式 : {TaxCCCalculate()} * {DayOfPeriod()} / {DayOfYear()} = {result}" + $"\n應納稅額 : 共 {result} 元";
                    }
                    else   //判斷填入日期 小於前面
                    {
                        this.lblresult.Text =
                        $"使用期間 : {this.dateTimePicker2.Value.ToString("yyyy/MM/dd")} ~ {this.dateTimePicker1.Value.ToString("yyyy/MM/dd")} \n計算天數 : {DayOfPeriod()}天\n用途 : {cmbUse.SelectedItem}\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                        $"\n計算公式 : {TaxCCCalculate()} * {DayOfPeriod()} / {DayOfYear()} = {result}" + $"\n應納稅額 : 共 {result} 元";
                    }
                }
                else if(this.dateTimePicker1.Value.Year != this.dateTimePicker2.Value.Year)  //若不同年 用for迴圈
                {
                    int yearstart = dateTimePicker1.Value.Year;

                    int yearend = dateTimePicker2.Value.Year;

                    int yearCount = Math.Abs(yearstart - yearend) - 1; //相差多少年  取絕對值   

                    if (this.dateTimePicker2.Value > this.dateTimePicker1.Value)  // 零散---->前段     前面時間(2020.03.15)   後面時間(2022.05.06)
                    {
                        DateTime endDate2 = new DateTime(dateTimePicker2.Value.Year, 12, 31);
                        DateTime pickDate2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
                        int days2 = pickDate2.Subtract(endDate2).Days;   //dateTimePicker2那年的天數
                        int result2 = (int)TaxCCCalculate() * days2 / dateTimePicker2.Value.DayOfYear;

                        for (int i = yearCount; i > 0; i--)  // 整年度--->中間
                        {
                            DateTime Allyear = dateTimePicker2.Value.AddYears(i);  //中間的年份  判斷閏年
                            int totalA = Allyear.DayOfYear;   //一年天數
                            //int totalDayOfYear = totalA.Sum();


                            //bool AllLeapYear = DateTime.IsLeapYear(Allyear);
                            //if (AllLeapYear == true)
                            //    return 366;
                            //else
                            //    return 365;
                        }


                        DateTime endDate1 = new DateTime(dateTimePicker1.Value.Year, 12, 31);  // 零散---->後段
                        DateTime pickDate1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                        int days1 = pickDate1.Subtract(endDate1).Days;  //dateTimePicker1那年的天數
                        int result1 = (int)TaxCCCalculate() * days1 / dateTimePicker1.Value.DayOfYear ;

                        //int totalresult = result1 + result2 + result3;
                        this.lblresult.Text =

                            $"使用期間 : {txtdate1.Text} ~ {dateTimePicker1.Value.Year}, 12, 31 " +    //前
                            $"\n計算天數 :{days1} 天 " +
                            $"\n用途 : {cmbUse.SelectedItem} " +
                            $"\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                            $"\n計算公式 : {TaxCCCalculate()} * {days1} / {dateTimePicker1.Value.DayOfYear} = {result1}" +

                            $"使用期間 : {dateTimePicker1.Value.AddYears(1)}, 01, 01 ~ {dateTimePicker2.Value.AddYears(-1)}, 12, 31 " +
                            //$"\n計算天數 :{} 天 " +
                            $"\n用途 : {cmbUse.SelectedItem} " +
                            $"\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                            //$"\n計算公式 : {TaxCCCalculate()} * {days1} / {dateTimePicker1.Value.DayOfYear} = {result3}" +

                            $"\n使用期間 : {txtdate2.Text} ~ {dateTimePicker2.Value.Year}, 12, 31 " +  //後
                            $"\n計算天數 :{days2} 天 " +
                            $"\n用途 : {cmbUse.SelectedItem} " +
                            $"\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                            $"\n計算公式 : {TaxCCCalculate()} * {days2} / {dateTimePicker2.Value.DayOfYear} = {result2}";
                            //+ $" \n應納稅額 : 共 {totalresult} 元";
                    }
                    else 
                    {
                        for (int i = yearCount; i > 0; i--)  // 整年度--->中間
                        {
                            DateTime endDate1 = new DateTime(dateTimePicker1.Value.Year, 12, 31);
                            DateTime pickDate1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                            int days1 = pickDate1.Subtract(endDate1).Days;   //dateTimePicker1那年的天數
                            int result1 = (int)TaxCCCalculate() * days1 / dateTimePicker1.Value.DayOfYear;

                            //bool isLeapYear = DateTime.IsLeapYear(dateTimePicker2.Value.Year); //閏年
                            //if (isLeapYear == true)
                            //    return 366;
                            //else
                            //    return 365;
                            //for (int i = yearCount; i > 0; i--)  // 整年度--->中間
                            {

                            }
                            DateTime endDate2 = new DateTime(dateTimePicker2.Value.Year, 12, 31);  // 零散---->後段
                            DateTime pickDate2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
                            int days2 = pickDate2.Subtract(endDate2).Days;  //dateTimePicker2那年的天數
                            int result2 = (int)TaxCCCalculate() * days2 / dateTimePicker2.Value.DayOfYear;


                            this.lblresult.Text =


                                    $"使用期間 : {txtdate2.Text} ~ {dateTimePicker1.Value.Year}, 12, 31 " +
                                    $"\n計算天數 :{days2} 天 " +
                                    $"\n用途 : {cmbUse.SelectedItem} " +
                                    $"\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                                    $"\n計算公式 : {TaxCCCalculate()} * {days2} / {dateTimePicker2.Value.DayOfYear} = {result2}" +

                                    $"\n使用期間 : {txtdate1.Text} ~ {dateTimePicker1.Value.Year}, 12, 31 " +
                                    $"\n計算天數 :{days1} 天 " +
                                    $"\n用途 : {cmbUse.SelectedItem} " +
                                    $"\n汽缸CC數應繳金額 : {TaxCCCalculate()}" +
                                    $"\n計算公式 : {TaxCCCalculate()} * {days1} / {dateTimePicker1.Value.DayOfYear} = {result1}";
                                    //+ $" \n應納稅額 : 共 {totalresult} 元";
                        }
                        // 零散---->後段
                    }

                }

                
                
            }   //待更新   不同年份分開計算
            
            //結果  閏年狀態 跨年分兩筆未做
        }
        #endregion

        private void butCancel_Click(object sender, EventArgs e)  //取消重填
        {
            this.Int();
        }
        private void Int()   //清除
        {
            this.radioButtonYear.Checked = true;
            this.groupBox1.Visible = false;
            this.txtdate1.Text = this.txtdate2.Text = string.Empty;
            this.dateTimePicker1.Value = this.dateTimePicker2.Value = DateTime.Today;
            this.cmbUse.SelectedIndex = -1;  //清除用途
            this.cmbCCscooter.Visible = this.cmbCCtruck.Visible = 
                this.cmbCCcoach.Visible = this.cmbCCcar.Visible = this.cmbCCBusinesscar.Visible = false;
            this.comboBox1.Visible = true;//  清除汽缸CC數／馬達馬力
            this.cmbCCscooter.SelectedIndex = this.cmbCCtruck.SelectedIndex =
                this.cmbCCcoach.SelectedIndex = this.cmbCCcar.SelectedIndex = this.cmbCCBusinesscar.SelectedIndex = -1;
            this.lblresult.Text = string.Empty;    //清除結果
        }
        private int DayOfYear() //回傳今年份天數
        {
            bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            if (isLeapYear == true)
                return 366;
            else 
                return 365;
        }
        private int DayOfPeriod()  //回傳期間天數
        {
            DateTime start = this.dateTimePicker1.Value;  //前面天數

            DateTime end = this.dateTimePicker2.Value;  //後面天數

            TimeSpan ts = end.Subtract(start); //兩時間天數相減

            int dayCount = Math.Abs(ts.Days); //相距天數  取絕對值
            return dayCount;
        }
        private decimal TaxCCCalculate()  //回傳汽缸價格
        {
            var cmbCar = this.cmbUse.SelectedItem.ToString();
            switch (cmbCar)
            {
                case "機車":
                    var cmbCCscooter = this.cmbCCscooter.SelectedItem.ToString(); //機車
                    switch (cmbCCscooter)  //選擇後回傳相應的價格
                            {
                                case "150以下 / 12HP以下(12.2PS以下)":
                                    return 0;

                                case "151-250 / 12.1-20HP(12.3-20.3PS)":
                                    return 800;

                                case "251-500 / 20.1HP以上(20.4PS以上)":
                                    return 1620;

                                case "501-600":
                                    return 2160;

                                case "601-1200":
                                    return 4320;

                                case "1201-1800":
                                    return 7120;

                                case "1801或以上":
                                    return 11230;

                                default:
                                    return 0;
                            }
                case "貨車":
                    var cmbCCtruck = this.cmbCCtruck.SelectedItem.ToString(); //貨車
                            switch (cmbCCtruck)  //選擇後回傳相應的價格
                            {
                                case "500以下":
                                    return 900;

                                case "501~600":
                                    return 1080;

                                case "601~1200":
                                    return 1800;

                                case "1201~1800":
                                    return 2700;

                                case "1801~2400":
                                    return 3600;

                                case "2401~3000":
                                    return 4500;

                                case "3001~3600":
                                    return 5400;

                                case "3601~4200":
                                    return 6300;

                                case "4201~4800":
                                    return 7200;

                                case "4801~5400":
                                    return 8100;

                                case "5401~6000":
                                    return 9000;

                                case "6001~6600":
                                    return 9900;

                                case "6601~7200":
                                    return 10800;

                                case "7201~7800":
                                    return 11700;

                                case "7801~8400":
                                    return 12600;

                                case "8401~9000":
                                    return 13500;

                                case "9001~9600":
                                    return 14400;

                                case "9601~10200":
                                    return 15300;

                                case "10201以上":
                                    return 16200;
                
                                default:
                                    return 0;
                            }
                case "大客車":
                    var cmbCCcoach = this.cmbCCcoach.SelectedItem.ToString(); //大客車
                            switch (cmbCCcoach)  //選擇後回傳相應的價格
                            {
                                case "501~600":
                                    return 1080;

                                case "601~1200":
                                    return 1800;

                                case "1201~1800":
                                    return 2700;

                                case "1801~2400":
                                    return 3600;

                                case "2401~3000":
                                    return 4500;

                                case "3001~3600":
                                    return 5400;

                                case "3601~4200":
                                    return 6300;

                                case "4201~4800":
                                    return 7200;

                                case "4801~5400":
                                    return 8100;

                                case "5401~6000":
                                    return 9000;

                                case "6001~6600":
                                    return 9900;

                                case "6601~7200":
                                    return 10800;

                                case "7201~7800":
                                    return 11700;

                                case "7801~8400":
                                    return 12600;

                                case "8401~9000":
                                    return 13500;

                                case "9001~9600":
                                    return 14400;

                                case "9601~10200":
                                    return 15300;

                                case "10201以上":
                                    return 16200;

                                default:
                                    return 0;
                            }
                case "自用小客車":
                    var cmbCCcar = this.cmbCCcar.SelectedItem.ToString();  //自用小客車
                            switch (cmbCCcar)  //選擇後回傳相應的價格
                            {
                                case "500以下":
                                    return 1620;
                   
                                case "501~600":
                                    return 2160;

                                case "601~1200":
                                    return 4320;

                                case "1201~1800":
                                    return 7120;

                                case "1801~2400":
                                    return 11230;

                                case "2401~3000":
                                    return 15210;

                                case "3001~4200":
                                    return 28220;

                                case "4201~5400":
                                    return 46170;

                                case "5401~6600":
                                    return 69690;

                                case "6601~7800":
                                    return 117000;

                                case "7801以上":
                                    return 151200;
                
                                default:
                                    return 0;
                            }
                case "營業用小客車":
                    var cmbCCBusinesscar = this.cmbCCBusinesscar.SelectedItem.ToString();   //營業用小客車
                            switch (cmbCCBusinesscar)  //選擇後回傳相應的價格
                            {
                                case "500以下":
                                    return 1620;
                
                                case "501~600":
                                    return 2160;
               
                                case "601~1200":
                                    return 4320;
                
                                case "1201~1800":
                                    return 7120;
               
                                case "1801~2400":
                                    return 11230;
                
                                case "2401~3000":
                                    return 15210;
               
                                case "3001~4200":
                                    return 28220;
                
                                case "4201~5400":
                                    return 46170;
                
                                case "5401~6600":
                                    return 69690;
                
                                case "6601~7800":
                                    return 117000;
               
                                case "7801以上":
                                    return 151200;
            
                                default:
                                    return 0;
                            }
                    default:
                        return 0;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)  // 直接選 汽缸CC數／馬達馬力 跳出提醒
        {
            MessageBox.Show("~~請先選擇用途~~");
        } 
    }
}
