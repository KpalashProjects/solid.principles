using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.priciples.OCP
{
    public class ReportGenerationSeviceRefactor
    {
        public void GenerateReport(string reportType, object data) {
            AbsReportGenerator absReportGenerator;

            switch (reportType) {
                case "Pdf":
                    absReportGenerator = new PdfReportGenerator();
                    break;
                case "Excel":
                    absReportGenerator = new ExcelReportGenerator();
                    break;
                case "Word":
                    absReportGenerator = new WordReportGenerator();
                    break;
                default:
                    throw new ArgumentException("Report type has not matched.");
            }

            absReportGenerator.GenerateReport(data);
        }
    }

    // Create new abstract class 
    public abstract class AbsReportGenerator {
        public string ReportType { get; set; }
        protected AbsReportGenerator(string reportType)
        {
            this.ReportType = reportType;
                
        }

        public virtual void GenerateReport(object data) { 
        
        }

    }

    // Pdf report generation class
    public class PdfReportGenerator : AbsReportGenerator {

        public PdfReportGenerator(): base("Pdf") {
                
        }

        public override void GenerateReport(object data)
        {
            Console.WriteLine("Generating PDF report...");
        }

    }

    // Excel report generation class
    public class ExcelReportGenerator : AbsReportGenerator
    {

        public ExcelReportGenerator() : base("Excel")
        {

        }

        public override void GenerateReport(object data)
        {
            Console.WriteLine("Generating Excel report...");
        }

    }

    // Word report generation class
    public class WordReportGenerator : AbsReportGenerator
    {

        public WordReportGenerator() : base("Word")
        {

        }

        public override void GenerateReport(object data)
        {
            Console.WriteLine("Generating Word report...");
        }

    }

}
