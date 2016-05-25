using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patronDecorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lomito lomo1 = new BaseLomito();
            lomo1 = new PapasFritas(lomo1);
            lomo1 = new Simple(lomo1);

            Lomito lomo2 = new BaseLomito();
            lomo2 = new Vegetariano(lomo2);

            Lomito lomo3 = new BaseLomito();
            lomo3 = new Completo(lomo3);

            Lomito lomo4 = new BaseLomito();
            lomo4 = new Macho(lomo4);

            Lomito lomo5 = new BaseLomito();
            lomo5 = new Macho(lomo5);
            lomo5 = new PapasFritas(lomo5);
            lomo5 = new Simple(lomo5);
            lomo5 = new Completo(lomo5);

            var precio1 = lomo1.precio();
            var precio2 = lomo2.precio();
            var precio3 = lomo3.precio();
            var precio4 = lomo4.precio();
            var precio5 = lomo5.precio();

            string cadena = "El lomo ";

            Console.WriteLine(cadena + "simple con papas cuesta: " + precio1);
            Console.WriteLine(cadena + "vegetariano cuesta: " + precio2);
            Console.WriteLine(cadena + "completo cuesta: " + precio3);
            Console.WriteLine(cadena + "macho cuesta: " + precio4);
            Console.WriteLine("EL combo reventar cuesta: " + precio5);
            Console.ReadLine();
        }
    }
}

public abstract class Lomito
{
    public abstract int precio();
}

public class BaseLomito : Lomito
{
    public override int precio()
    {
        return 60;
    }
}

public class PapasFritas : Lomito
{
    private Lomito l;

    public PapasFritas(Lomito l)
    {
        this.l = l;
    }
    public override int precio()
    {
        return this.l.precio() + 10;
    }
}

public class Completo : Lomito
{
    private Lomito l;

    public Completo(Lomito l)
    {
        this.l = l;
    }
    public override int precio()
    {
        return this.l.precio() + 20;
    }
}

public class Macho : Lomito
{
    private Lomito l;
    
    public Macho(Lomito l)
    {
        this.l = l;
    }
    public override int precio()
    {
        return this.l.precio() + 70;
    }
}

public class Simple : Lomito
{
    private Lomito l;

    public Simple(Lomito l)
    {
        this.l = l;
    }
    public override int precio()
    {
        return this.l.precio ()+ 10;
    }
}

public class Vegetariano : Lomito
{
    private Lomito l;

    public Vegetariano(Lomito l)
    {
        this.l = l;
    }
    public override int precio()
    {
        return this.l.precio ()+ 20;
    }
}






