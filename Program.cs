namespace Assessment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 program
            LicensePlateRegroup licensePlateRegroup = new LicensePlateRegroup();
            Console.WriteLine("The following the Output of First Problem : ");
            licensePlateRegroup.LicensePlate("5F3Z-2e-9-w", 4);
            licensePlateRegroup.LicensePlate("2-5g-3-J", 2);
            licensePlateRegroup.LicensePlate("2-4A0r7-4k", 3);
            licensePlateRegroup.LicensePlate("nlj-206-fv", 3);

            Console.WriteLine();
            Console.WriteLine();
            // 2 program
            CalculateTime calculateTime = new CalculateTime();
            Console.WriteLine("The following the Output of Second Problem : ");
            calculateTime.FindTime("Eric", 2, "Adam Caroline Rebecca Frank");
            calculateTime.FindTime("Zebediah", 1, "Bob Jim Becky Pat");
            calculateTime.FindTime("Aaron", 3, "Jane Max Olivia Sam");

        }
    }
}