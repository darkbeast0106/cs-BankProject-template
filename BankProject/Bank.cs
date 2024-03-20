namespace BankProject
{
    /// <summary>
    /// Bank műveleteit végrehajtó osztály.
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// Új számlát nyit a megadott névvel, számlaszámmal, 0 Ft egyenleggel
        /// </summary>
        /// <param name="nev">A számla tulajdonosának neve</param>
        /// <param name="szamlaszam">A számla számlaszáma</param>
        /// <exception cref="ArgumentNullException">A név és a számlaszám nem lehet null</exception>
        /// <exception cref="ArgumentException">A név és a számlaszám nem lehet üres
        /// A számlaszámmal nem létezhet számla
        /// A számlaszám számot, szóközt és kötőjelet tartalmazhat</exception>
        public void UjSzamla(string nev, string szamlaszam)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lekérdezi az adott számlán lévő pénzösszeget
        /// </summary>
        /// <param name="szamlaszam">A számla számlaszáma, aminek az egyenlegét keressük</param>
        /// <returns>A számlán lévő egyenleg</returns>
        /// <exception cref="ArgumentNullException">A számlaszám nem lehet null</exception>
        /// <exception cref="ArgumentException">A számlaszám számot, szóközt és kötőjelet tartalmazhat</exception>
        /// <exception cref="HibasSzamlaszamException">A megadott számlaszámmal nem létezik számla</exception>
        public ulong Egyenleg(string szamlaszam)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Egy létező számlára pénzt helyez
        /// </summary>
        /// <param name="szamlaszam">A számla számlaszáma, amire pénzt helyez</param>
        /// <param name="osszeg">A számlára helyezendő pénzösszeg</param>
        /// <exception cref="ArgumentNullException">A számlaszám nem lehet null</exception>
        /// <exception cref="ArgumentException">Az összeg csak pozitív lehet.
        /// A számlaszám számot, szóközt és kötőjelet tartalmazhat</exception>
        /// <exception cref="HibasSzamlaszamException">A megadott számlaszámmal nem létezik számla</exception>
        public void EgyenlegFeltolt(string szamlaszam, ulong osszeg)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Két számla között utal.
        /// Ha nincs elég pénz a forrás számlán, akkor false értékkel tér vissza
        /// </summary>
        /// <param name="honnan">A forrás számla számlaszáma</param>
        /// <param name="hova">A cél számla számlaszáma</param>
        /// <param name="osszeg">Az átutalandó egyenleg</param>
        /// <returns>Az utalás sikeressége</returns>
        /// <exception cref="ArgumentNullException">A forrás és cél számlaszám nem lehet null</exception>
        /// <exception cref="ArgumentException">Az összeg csak pozitív lehet.
        /// A számlaszám számot, szóközt és kötőjelet tartalmazhat</exception>
        /// <exception cref="HibasSzamlaszamException">A megadott számlaszámmal nem létezik számla</exception>
        public bool Utal(string honnan, string hova, ulong osszeg)
        {
            throw new NotImplementedException();
        }
    }
}