namespace GenericTypesInCSharp
{
    public class ComparaClass
    {
        public void ComparaParametrosDeUmTipo<tipo1>(tipo1 parametro1, tipo1 parametro2) 
        {
            bool resultado;

            resultado = parametro1.Equals(parametro2);

            if (resultado)
            {
                Console.WriteLine("Os parametros são iguais");
            }
            else
            {
                Console.WriteLine("Os parametros não são iguais");
            }
        }

        public void ComparaParametrosDeDoisTipos<tipo1, tipo2>(tipo1 parametro1, tipo2 parametro2)
        {
            bool resultado;

            resultado = parametro1.Equals(parametro2);

            if (resultado)
            {
                Console.WriteLine("Os parametros são iguais");
            }
            else
            {
                Console.WriteLine("Os parametros não são iguais");
            }
        }
    }
}
