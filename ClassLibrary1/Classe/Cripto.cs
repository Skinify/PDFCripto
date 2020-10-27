using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Classe
{
    public class Cripto : IDisposable
    {
        private readonly char[] chars = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W','X', 
            'Y','Z', 'a', 'b', 'c', 'd', 'e', 'f', 
            'g','h', 'i', 'j', 'k', 'l', 'm', 'n', 
            'o','p', 'q', 'r', 's', 't', 'u', 'v', 
            'w', 'x','y', 'z', '0', '1', '2', '3', 
            '4', '5','6', '7', '8', '9',' ', '-',
            ',','.','(',')','\"','?','\'','{','}'/*,
            (char)10,(char) 9,(char)13*/
        };

        private readonly Random rand = new Random();

        public Cripto(){}

        public string GerarHash()
        {
            string hash = string.Empty;
            int hashSeal = 0;
            for (int count = 0; count < chars.Length;)
            {
                string letraTemp = CodigoPorLetra();
                if (!hash.Contains(letraTemp))
                {
                    hash += letraTemp;
                    count++;
                    hashSeal += StringToInt(letraTemp);
                }
            }
            return hash;
        }

        public string CodigoPorLetra()
        {
            string codigo = string.Empty;
            for(int count = 0; count < 3; count++)
            {
                codigo += chars[rand.Next(0, chars.Length)];
            }
            return codigo;
        }

        public string CriptografarTexto(string texto, string hash)
        {
            string textoCriptografado = string.Empty;
            Dictionary<char, string> map = MapearHash(hash);
            foreach (char letra in texto)
            {
                textoCriptografado += map.FirstOrDefault(x => x.Key == letra).Value;
            }
            return textoCriptografado;
        }

        private int StringToInt(string caracteres)
        {
            int caracterValues = 0;
            foreach(char c in caracteres)
            {
                caracterValues += c;
            }
            return caracterValues;
        }

        public string DescriptografarTexto(string texto, string hash)
        {
            try
            {
                string textoLimpo = texto;
                Dictionary<char, string> map = MapearHash(hash);
                foreach (KeyValuePair<char, string> entry in map)
                {
                    textoLimpo = textoLimpo.Replace(entry.Value, entry.Key.ToString());
                }
                return textoLimpo;
            }catch(Exception ex)
            {
                throw new Exception("Hash invalido");
            }
        }

        private Dictionary<char, string> MapearHash(string hash)
        {
            IEnumerable<string> hashParts = Split(hash, 3);
            Dictionary<char, string> map = new Dictionary<char, string>();
            for (int count = 0; count < chars.Length; count++)
            {
                map.Add(chars[count], hashParts.ElementAt(count));
            }
            return map;
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
