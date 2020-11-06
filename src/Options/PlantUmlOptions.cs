using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantUmlLanguageService.Options
{
    public class PlantUmlOptions : DialogPage
    {
        public PlantUmlOptions()
        {

        }
        private string plantUmlServiceUrl = "https://www.plantuml.com/plantuml";

        [Category("PlantUmlLanguageService")]
        [DisplayName("PlantUml service URL Setting")]
        [Description("User specifies the PlantUml URL address. ex) http://localhost:8081")]
        public string PlantUmlServiceUrl
        {
            get { return plantUmlServiceUrl; }
            set { plantUmlServiceUrl = value; }
        }

        private string pdfFileName = "PlantUML_Language_Reference_Guide_en.pdf";

        [Category("PlantUmlLanguageService")]
        [DisplayName("Pdf File Name")]
        [Description("Users specify the PDF file name to be downloaded instead of the default PDF file name.")]
        public string PlantUmlPdfFileName
        {
            get { return pdfFileName; }
            set { pdfFileName= value; }
        }

    }
}
