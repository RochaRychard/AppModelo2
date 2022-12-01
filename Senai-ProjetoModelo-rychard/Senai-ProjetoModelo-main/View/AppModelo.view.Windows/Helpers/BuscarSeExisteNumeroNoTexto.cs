namespace AppModelo.view.Windows.Helpers
{
    /// <summary>
    /// MÉTODO PARA SABER SE FOI DIGITADO ALGUN NÚMERO NO CAMPO 'NOME' DO FORMULÁRIO
    /// </summary>
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
