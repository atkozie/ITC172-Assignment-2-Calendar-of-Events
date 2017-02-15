using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[,] day = new string[6, 2]; //2-dimensional array, 10 rows and 2 columns
            


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)//prevent from repeating the GET on each click
            { //the day array:
                day[0, 0] = "Veterans Day";
                day[0, 1] = "11/11/2017";
                day[1, 0] = "MLK Jr Day";
                day[1, 1] = "1/16/2017";
                day[2, 0] = "Thanksgiving";
                day[2, 1] = "11/23/2017";
                day[3, 0] = "Memorial Day";
                day[3, 1] = "5/29/2017";
                day[4, 0] = "Labor Day";
                day[4, 1] = "9/4/2017";
                day[5, 0] = "Someone's Birthday Falls On Labor Day In 2017";
                day[5, 1] = "9/4/2017";

                //GetDay();//call the method below
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            day[0, 0] = "Veterans Day";
            day[0, 1] = "11/11/2017";
            day[1, 0] = "MLK Jr Day";
            day[1, 1] = "1/16/2017";
            day[2, 0] = "Thanksgiving";
            day[2, 1] = "11/23/2017";
            day[3, 0] = "Memorial Day";
            day[3, 1] = "5/29/2017";
            day[4, 0] = "Labor Day";
            day[4, 1] = "9/4/2017";
            day[5, 0] = "Someone's Birthday Falls On Labor Day In 2017";
            day[5, 1] = "9/4/2017";

            // DateTime vday = DateTime.Parse("11/11/2017");
            for (int i = 0; i < 6; i++)
            {
                //DayLabel.Text = Calendar1.SelectedDate.ToShortDateString();
                if (Calendar1.SelectedDate.ToShortDateString() == day[i,1])
                {

                    DayLabel.Text += day[i,0] + "<br/>";
                }
            }
        }
    }//end partial class
}//end namespace