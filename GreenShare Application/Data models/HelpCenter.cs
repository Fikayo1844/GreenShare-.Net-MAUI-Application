using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShare_Application.Data_models
{
    public class HelpCenter
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }
        public List<string> FAQs { get; set; }
        public List<string> Tutorials { get; set; }
    }
}
