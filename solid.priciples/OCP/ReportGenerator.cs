using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.priciples.OCP
{
    public class ReportGenerator
    {
        public ReportGenerator(string reportType)
        {
                this.ReportType = reportType;
        }
        public string ReportType { get; set; }

        public void GenerateReport (object data){

            if (ReportType == "Excel")
            {
                // report generation custom code here
            }
            else if (ReportType == "PDF")
            {
                // pdf report generation custom code here
            }
            else if (ReportType == "CSV") { 
            // CSV report generation custom code here
            }

            // for the new report type code here
        
        }
    }
}
