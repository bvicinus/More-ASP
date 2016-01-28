using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private int count = 0;


    //user added
    public void Write_Start_Time()
    {
        //picking up the application variable start_time
        DateTime startTime = (DateTime)Application["Start_Time"];

        //send something down to the browser
        //'puts its parameter into the output stream going to the browser'
        Response.Write("This application was started at " + startTime.ToString());
    }


    protected void Page_Load(object sender, EventArgs e)
    {

        //each page load, incriment count 
        //if this session/viewstate count hasnt been created, its null
        if (ViewState["ct"] == null) 
        {
            ViewState["ct"] = 0; //and needs to be created, here
        }
        count = (int)ViewState["ct"]; //need to type cast to get back an actual int
        ViewState["ct"] = ++count;

        //session state is retained in memory on the server 
        //for same tabs, and browser windows

        //viewstate will make a new viewstate variable for each tab!!
        //seperate instance of viewstate in every page


        if (!IsPostBack) //only on original page load 
        {
            lblGreeting.Text = "It's a new world!";
            lblGreeting.ForeColor = System.Drawing.Color.Blue;
        }
    }


    //button event for OK
    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblGreeting.Text = "Hello, " + tbName.Text; //change the name
        lblCount.Text = "Count = " + count.ToString();
        //need to call toString on the int 

    }

    //button event for CANCEL
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        tbName.Text = ""; //clear the text box 
        lblGreeting.Text = ""; //clear the string
        lblCount.Text = "Count = " + count.ToString();
        
    }
}