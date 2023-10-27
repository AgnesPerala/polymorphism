namespace polymorfoism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // make an obejkt geomtry that refrence to all classes 
            // also print out area in all classes
            Geometry geometry = new Circle();
            Console.WriteLine($"Area cirkel {geometry.Area():F2}\n"); 

            geometry = new ellipse();
            Console.WriteLine($"Area eliips: {geometry.Area():F2}\n");

            geometry = new Parallellogram();
            Console.WriteLine($"Area parallellogram: {geometry.Area():F2}\n");

            geometry = new Rectangle();
            Console.WriteLine($"Area rektangel: {geometry.Area():F2}\n");

            geometry = new Square();
            Console.WriteLine($"Area fyrkant: {geometry.Area():F2}\n");

        }
    }
}