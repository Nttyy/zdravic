namespace ConsoleApp2
{
    /// <summary>
    /// Třída reprezentuje zdravič, který slouží ke zdravení uživatelů
    /// </summary>
    class Zdravic
    {
        /// <summary>
        /// Text pozdravu
        /// </summary>
        public string text;
        /// <summary>
        /// Pozdraví uživatele textem pozdravu a jeho jménem
        /// </summary>
        //// <param name="jmeno">Jméno uživatele</param>
        /// <returns>Text s pozdravem</returns>
        public string Pozdrav(string jmeno)
        {
            return String.Format("{0},{1}", text, jmeno);
        }
    }
}
