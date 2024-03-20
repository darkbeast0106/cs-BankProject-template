using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    /// <summary>
    /// Nem létező számla esetén dobhatjuk bármely függvényből
    /// </summary>
    public class HibasSzamlaszamException : Exception
    {
        /// <summary>
        /// Létrehozza a kivételt, amely Hibás számlaszám üzenetet fogja kiírni a megadott számlaszámmal
        /// </summary>
        /// <param name="szamlaszam">A számlaszám, ami nem létezik</param>
        public HibasSzamlaszamException(string szamlaszam)
            : base("Hibas szamlaszam: " + szamlaszam)
        {
        }
    }
}