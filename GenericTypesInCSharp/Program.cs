namespace GenericTypesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComparaClass compara = new ComparaClass();

            int numero1 = 1;
            int numero2 = 1;

            string string1 = "teste";

            // Aqui o tipo está sendo passado por inferência
            compara.ComparaParametrosDeUmTipo(numero1, numero2);
            // Aqui defino o tipo explicitamente
            compara.ComparaParametrosDeUmTipo<int>(numero1, numero2);

            // A chamada abaixo retorna erro pois não passa valor string no parametro 1
            compara.ComparaParametrosDeUmTipo<string>(numero1, string1);

            // Aqui o tipo está sendo passado por inferência
            compara.ComparaParametrosDeDoisTipos(numero1, string1);
            // Aqui defino o tipo explicitamente
            compara.ComparaParametrosDeDoisTipos<int, string>(numero1, string1);

            // A chamada abaixo retorna erro pois não passa valor int no parametro 2
            compara.ComparaParametrosDeDoisTipos<int, string>(numero1, numero2);

            Console.ReadKey();
        }
    }
}