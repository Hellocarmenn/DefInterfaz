using System;


namespace INTERFACES
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hola");

        }
        int Propiedad1{
            get;
            set;

        }
    }
}
//Definicion de interfaz 
public interface IEjemplo{
    int Propiedad1{
        get;
        set;
    }
    void Metodo1();


}
