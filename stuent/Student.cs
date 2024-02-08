namespace stuent
{
    public enum Year
    {
        first_year = 1,
        second_year = 2,
        third_year = 3
    }

    public class AbsenceDay
    {
        public DateTime formDate { get; set; }
        public int days { get; set; }
    }

    public class Test
    {
        public string nameOfTest { get; set; }
        public int mark { get; set; }
        public int kode { get; set; }
        public DateTime date { get; set; }
    }

    public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int avgMark { get; set; }
        //public DateTime departureDate { get; set; }
        public bool active { get; set; }
        public int professionsId { get; set; }
        public Year school_year { get; set; }
        public List<Test>? test { get; set; }

        //public string email { get; set; }
        //public List<AbsenceDay> absenceDays { get; internal set; }

    }

}