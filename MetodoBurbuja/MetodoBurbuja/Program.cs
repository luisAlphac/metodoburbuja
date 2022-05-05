// See https://aka.ms/new-console-template for more information
using MetodoBurbuja;
burbuja bu=new burbuja();
try
{
    bu.cargar();
    bu.metodo();
    bu.mostrar();
}
catch (Exception ex)
{
    Console.WriteLine("Ingrese valores numéricos");
}
