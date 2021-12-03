using System; 

namespace CLASES 
{
    class Program
    {
        static void Main (string[]args )
        {
         Circulo miCirculo;
         miCirculo =new Circulo (); 
         Console.WriteLine("El area del circulo es: ");
          Console.WriteLine(miCirculo.CalcularArea(5));

          double yarea; 
          Triangulo objTriangulo = new Triangulo(); 
          yarea = objTriangulo.Area();
          Console.WriteLine("AREA DEL TRIANGULO: {0}", yarea); 
          Console.WriteLine();


          double xarea;  
          Rectangulo objRectangulo = new Rectangulo();
          xarea = objRectangulo.area();
          Console.WriteLine("AREA DEL RECTANGULO: {0}", xarea); 
          Console.WriteLine(); 

        }
          
    }
    class Circulo
    {
        //declaramos los datos 
        public double pi=3.1416;

        //metodo de clase
        public double CalcularArea(int radio)
        {
            return  pi*(radio*radio);
        }
    }

    class Triangulo 
    {
        //declaramos los datos  
        public int b; 
        public int h; 

        public Triangulo()
        {
            h = 4; 
            b = 2; 
        }

        //metodo de clase
        public double Area()
        {
            double Tarea; 
            Tarea= b*h/2; 
            return Tarea;
        }
    }
    class Rectangulo
    {
        //declaramos los datos
        public int b; 
        public int h; 

        //metodos

        public Rectangulo()
        {
            b = 8; 
            h = 4; 
        }

        public double area()
        {
            double Rarea; 
            Rarea = b * h; 
            return Rarea;

        }

    }
}

