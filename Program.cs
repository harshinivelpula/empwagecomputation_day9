namespace empwageday9
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage problem");
            attendance.CheckAttendance();
            dailywage.calwage();
            parttime.isparttime();
            @switch.usecases();
            monthlywage.monthwages();
            totalworkinghours.conditions();
        }
    }
}