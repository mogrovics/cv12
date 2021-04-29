using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv12web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Calculator_Service(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client calculatorService = new ServiceReference1.Service1Client();

            decimal first = decimal.Parse(firstNumber.Text);
            decimal second = decimal.Parse(secondNumber.Text);
            string operation = operationsList.Text;
            decimal result = calculatorService.Compute(first, second, operation);

            Response.Write(String.Format("{0} {1} {2} = {3}", first, operation, second, result));
        }
    }
}