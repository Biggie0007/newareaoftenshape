internal class areaofteunshape
{
    private static void Main(string[] args)
    {
        do
        {

            double solution = 0;


            Console.WriteLine("Area of ten different shape");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Select shape");
            Console.WriteLine("1:Square");
            Console.WriteLine("2:Circle");
            Console.WriteLine("3:Rectangle");
            Console.WriteLine("4:Triangle");
            Console.WriteLine("5:Cone");
            Console.WriteLine("6:Hexagon");
            Console.WriteLine("7:Cylinder");
            Console.WriteLine("8:Kite");
            Console.WriteLine("9:Cube");
            Console.WriteLine("10:Octagon");
            Console.Write("Enter selection 1,2,3,4,5,6,7,8,9,10:");
            int selection = Convert.ToInt32(Console.ReadLine());

            if (selection == 1)
            {
                Console.WriteLine("Square");
                Console.Write("Length:");
                double side = double.Parse(Console.ReadLine());
                solution = side * side;
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 2)
            {
                Console.WriteLine("Circle");
                Console.Write("radius:");
                double radius = double.Parse(Console.ReadLine());
                solution = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 3)
            {
                Console.WriteLine("Rectangle");
                Console.Write("Length:");
                double Length = double.Parse(Console.ReadLine());
                Console.Write("Width:");
                double Width = double.Parse(Console.ReadLine());
                solution = Length * Width;
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 4)
            {
                Console.WriteLine("Triangle");
                Console.Write("Base:");
                double Base = double.Parse(Console.ReadLine());
                Console.Write("Height:");
                double Height = double.Parse(Console.ReadLine());
                solution = 0.5 * Base * Height;
                Console.WriteLine("Answer:" + solution);
            }

            else if (selection == 5)
            {
                Console.WriteLine("Cone");
                Console.Write("Cone radius:");
                double Coneradius = double.Parse(Console.ReadLine());
                Console.Write("Cone height:");
                double Coneheight = double.Parse(Console.ReadLine());
                solution = Math.PI * Coneradius * (Coneradius + Math.Sqrt(Coneheight * Coneheight + Coneradius * Coneradius));
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 6)
            {
                Console.WriteLine("Hexagon");
                Console.Write("Hexagon length:");
                double Hlength = double.Parse(Console.ReadLine());
                solution = 3 * Math.Sqrt(3) / 2 * (Hlength * Hlength);
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 7)
            {
                Console.WriteLine("Cylinder");
                Console.Write("Cylinder radius:");
                double Cynradius = double.Parse(Console.ReadLine());
                Console.Write("Cylinder height:");
                double Cynheight = double.Parse(Console.ReadLine());
                solution = 2 * Math.PI * Cynradius * Cynheight + 2 * Math.PI * (Cynradius * Cynradius);
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 8)
            {
                Console.WriteLine("Kite");
                Console.Write("p Diagonal:");
                double pDiagonal = double.Parse(Console.ReadLine());
                Console.Write("q Diagonal:");
                double qDiagonal = double.Parse(Console.ReadLine());
                solution = pDiagonal * qDiagonal / 2;
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 9)
            {
                Console.WriteLine("Cube");
                Console.Write("Edge:");
                double Edge = double.Parse(Console.ReadLine());
                solution = 6 * (Edge * Edge);
                Console.WriteLine("Answer:" + solution);
            }
            else if (selection == 10)
            {
                Console.WriteLine("Octagon");
                Console.Write("Octagon length:");
                double Olength = double.Parse(Console.ReadLine());
                solution = 2 * (1 + Math.Sqrt(2) * (Olength * Olength));
                Console.WriteLine("Answer:" + solution);
            }
            else
            {
                Console.WriteLine("invalid selectiom");

            }

            Console.Write("Would you like to calculate another shape?(Y=yes , N=no):");
        } while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine("see ya!");


     Console.ReadKey();
    
    }  
    
    
}