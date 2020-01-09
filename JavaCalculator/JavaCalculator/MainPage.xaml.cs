using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JavaCalculator
{
   

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            float M1 = (float)Convert.ToDecimal(MCQ1.Text);
            float M2 = (float)Convert.ToDecimal(MCQ2.Text);
            float LabEx = (float)Convert.ToDecimal(LabExam.Text);
            float Attend = (float)Convert.ToDecimal(Attendance.Text);

            float overallGrade = (((M1 / 20) + (M2 / 20) + (LabEx / 50) + (Attend / 10)) * 100) / 4;
            TotalGrade.Text = "Your overall grade is: " + overallGrade.ToString();

        }
    }
}
