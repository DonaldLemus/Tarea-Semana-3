static void fragmento()
{
    int can, c200, c100, c50, c20, c10, c5, c1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;

    float can2,cen50, cen25, cen10, cen5, cen1;
    cen50 = cen25 = cen10 = cen5 = cen1 = 0.00f;
    string linea;

    Console.Write("Ingrese la cantidad: ");
    linea = Console.ReadLine();
    can2 = float.Parse(linea);
    can = (int)can2;
    can2 = can2 - can;

    if ((can >= 200))
    {
        c200 = (can / 200);
        can = can - (c200 * 200);
    }
    if ((can >= 100))
    {
        c100 = (can / 100);
        can = can - (c100 * 100);
    }
    if ((can >= 50))
    {
        c50 = (can / 50);
        can = can - (c50 * 50);
    }
    if ((can >= 20))
    {
        c20 = (can / 20);
        can = can - (c20 * 20);
    }
    if ((can >= 10))
    {
        c10 = (can / 10);
        can = can - (c10 * 10);
    }
    if ((can >= 5))
    {
        c5 = (can / 5);
        can = can - (c5 * 5);
    }
    if ((can >= 1))
    {
        c1 = (can / 1);
        can = can - c1;
    }

    if ((can2 >= 0.50))
    {
        cen50 = 1;
        can2 = (can2 - 0.50f);
    }
    if ((can2 >= 0.25))
    {
        cen25 = 1;
        can2 = (can2 - 0.25f);
    }
    if ((can2 >= 0.10))
    {
        cen10 = (can2 - (can2 % 0.10f)) / 0.10f;
        can2 = (can2 % 0.10f);
        cen10 = (float)Math.Round(cen10,2);
    }
    if ((can2 >= 0.05))
    {
        cen5 = (can2 - (can2 % 0.05f)) / 0.05f;
        can2 = can2 - (cen5 % 0.05f);
        cen5 = (float)Math.Round(cen5, 2);
    }
    if ((can2 >= 0.01))
    {
        cen1 = (can2 / 0.01f);
        cen1 = (float)Math.Round(cen1, 2);
    }
    Console.WriteLine($"Billetes de 200: {c200}");
    Console.WriteLine($"Billetes de 100: {c100}");
    Console.WriteLine($"Billetes de 50: {c50}");
    Console.WriteLine($"Billetes de 20: {c20}");
    Console.WriteLine($"Billetes de 10: {c10}");
    Console.WriteLine($"Billetes de 5: {c5}");
    Console.WriteLine($"Billetes de 1: {c1}");
    Console.WriteLine($"Monedas de 50 centavos: {cen50}");
    Console.WriteLine($"Monedas de 25 centavos: {cen25}");
    Console.WriteLine($"Monedas de 10 centavos: {cen10}");
    Console.WriteLine($"Monedas de 5 centavos: {cen5}");
    Console.WriteLine($"Monedas de 1 centavo: {cen1}");
}//fin fragmento

static void fragmento2()
{
    int can, c200, c100, c50, c20, c10, c5, c1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;

    float can2, cen50, cen25, cen10, cen5, cen1;
    cen50 = cen25 = cen10 = cen5 = cen1 = 0.00f;
    string linea;

    Console.Write("Ingrese la cantidad: ");
    linea = Console.ReadLine();
    can2 = float.Parse(linea);
    can2 = (float)Math.Round(can2, 2);
    can = (int)can2;
    can2 = can2 - can;
    do
    {
        switch (can)
        {
            case >= 200:

                c200 = (can / 200);
                can = can - (c200 * 200);
                break;

            case >= 100:
                c100 = (can / 100);
                can = can - (c100 * 100);
                break;

            case >= 50:
                c50 = (can / 50);
                can = can - (c50 * 50);

                break;

            case >= 20:
                c20 = (can / 20);
                can = can - (c20 * 20);
                break;
            case >= 10:
                c10 = (can / 10);
                can = can - (c10 * 10);

                break;

            case >= 5:
                c5 = (can / 5);
                can = can - (c5 * 5);
                break;
            case >= 1:
                c1 = (can / 1);
                can = can - c1;
                break;
            default:
                can = 0;
                break;
        }        
    } while (can != 0);

    do
    {
        switch (can2)
        {
            case >= 0.50f:
                cen50 = 1;
                can2 = (can2 - 0.50f);
                break;

            case >= 0.25f:
                cen25 = (can2 - (can2 % 0.25f)) / 0.25f;
                can2 = (can2 - 0.25f);
                break;

            case >= 0.10f:
                cen10 = (can2 - (can2 % 0.10f)) / 0.10f;
                can2 = (can2 % 0.10f);
                cen10 = (float)Math.Round(cen10, 2);
                break;

            case >= 0.05f:
                cen5 = (can2 - (can2 % 0.05f)) / 0.05f;
                can2 = can2 - (cen5 % 0.05f);
                cen5 = (float)Math.Round(cen5, 2);
                break;

            case >= 0.01f:
                cen1 = (can2 / 0.01f);
                cen1 = (float)Math.Round(cen1, 2);
                can2 = cen1;
                break;
        }
    } while (can2 != 0);
    Console.WriteLine($"Billetes de 200: {c200}");
    Console.WriteLine($"Billetes de 100: {c100}");
    Console.WriteLine($"Billetes de 50: {c50}");
    Console.WriteLine($"Billetes de 20: {c20}");
    Console.WriteLine($"Billetes de 10: {c10}");
    Console.WriteLine($"Billetes de 5: {c5}");
    Console.WriteLine($"Billetes de 1: {c1}");
    Console.WriteLine($"Monedas de 50 centavos: {cen50}");
    Console.WriteLine($"Monedas de 25 centavos: {cen25}");
    Console.WriteLine($"Monedas de 10 centavos: {cen10}");
    Console.WriteLine($"Monedas de 5 centavos: {cen5}");
    Console.WriteLine($"Monedas de 1 centavo: {cen1}");
}//fin fragmento2

static void fragmento3()
{
    int can, c200, c100, c50, c20, c10, c5, c1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;

    float Q, can2, cen50, cen25, cen10, cen5, cen1;
    cen50 = cen25 = cen10 = cen5 = cen1 = 0.00f;
    string linea;

    Console.Write("Ingrese la cantidad en dolares: $");
    linea = Console.ReadLine();
    can2 = float.Parse(linea);
    Q = can2 * 7.71f;
    Console.WriteLine("Tipo de cambio Q7.71 del día 24/02/2002");
    Q = (float)Math.Round(Q, 2);
    Console.WriteLine("Su cantidad convertida a Quetzales: Q"+Q);

    can2 = Q;
    can = (int)can2;
    can2 = can2 - can;

    if ((can >= 200))
    {
        c200 = (can / 200);
        can = can - (c200 * 200);
    }
    if ((can >= 100))
    {
        c100 = (can / 100);
        can = can - (c100 * 100);
    }
    if ((can >= 50))
    {
        c50 = (can / 50);
        can = can - (c50 * 50);
    }
    if ((can >= 20))
    {
        c20 = (can / 20);
        can = can - (c20 * 20);
    }
    if ((can >= 10))
    {
        c10 = (can / 10);
        can = can - (c10 * 10);
    }
    if ((can >= 5))
    {
        c5 = (can / 5);
        can = can - (c5 * 5);
    }
    if ((can >= 1))
    {
        c1 = (can / 1);
        can = can - c1;
    }

    if ((can2 >= 0.50))
    {
        cen50 = 1;
        can2 = (can2 - 0.50f);
    }
    if ((can2 >= 0.25))
    {
        cen25 = 1;
        can2 = (can2 - 0.25f);
    }
    if ((can2 >= 0.10))
    {
        cen10 = (can2 - (can2 % 0.10f)) / 0.10f;
        can2 = (can2 % 0.10f);
        cen10 = (float)Math.Round(cen10, 2);
    }
    if ((can2 >= 0.05))
    {
        cen5 = (can2 - (can2 % 0.05f)) / 0.05f;
        can2 = can2 - (cen5 % 0.05f);
        cen5 = (float)Math.Round(cen5, 2);
    }
    if ((can2 >= 0.01))
    {
        cen1 = (can2 / 0.01f);
        cen1 = (float)Math.Round(cen1, 2);
    }
    Console.WriteLine($"\nBilletes de 200: {c200}");
    Console.WriteLine($"Billetes de 100: {c100}");
    Console.WriteLine($"Billetes de 50: {c50}");
    Console.WriteLine($"Billetes de 20: {c20}");
    Console.WriteLine($"Billetes de 10: {c10}");
    Console.WriteLine($"Billetes de 5: {c5}");
    Console.WriteLine($"Billetes de 1: {c1}");
    Console.WriteLine($"Monedas de 50 centavos: {cen50}");
    Console.WriteLine($"Monedas de 25 centavos: {cen25}");
    Console.WriteLine($"Monedas de 10 centavos: {cen10}");
    Console.WriteLine($"Monedas de 5 centavos: {cen5}");
    Console.WriteLine($"Monedas de 1 centavo: {cen1}");
}//fin fragmento

//fragmento();
//fragmento2();
fragmento3();
