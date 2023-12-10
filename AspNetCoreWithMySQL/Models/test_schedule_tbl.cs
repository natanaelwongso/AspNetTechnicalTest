using System;

namespace TestTechnical.Models
{
    public class test_schedule_tbl
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime TestDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
