namespace AppModelo.view.Windows.Helpers
{
    internal static partial class Componentes
    {
        internal static bool ExisteNumeroNoTexto(string texto)
        {
            foreach (var letra in texto)
            {
                if (char.IsNumber(letra))
                {      
                    return true;
                }
            }
            return false;
        }
    }
    
}
