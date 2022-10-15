namespace L10_MARH_1077822
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 9");
            Console.WriteLine("Ingrese su usuario: ");
            for (int x = 0; x < 3; x++)
            {
                string contraseña = Convert.ToString(Console.ReadLine());
                if (contraseña == "usuario1")
                {
                    Console.WriteLine("verdad");
                }
            }
            Console.WriteLine("Ingrese su contraseña: ");
            for (int x = 0; x < 3; x++)
            {
                string contraseña = Convert.ToString(Console.ReadLine());
                if (contraseña == "asdasd")
                {
                    Console.WriteLine("verdad");
                }
            }
        }
    }
}       
