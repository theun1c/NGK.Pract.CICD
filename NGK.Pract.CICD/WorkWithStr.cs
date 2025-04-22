namespace NGK.Pract.CICD
{
    public class WorkWithStr
    {
        /// <summary>
        /// Поиск всех вхождений подстроки в строке (регистрозависимый)
        /// </summary>
        /// <param name="source">Исходная строка</param>
        /// <param name="substring">Подстрока для поиска</param>
        /// <returns>Массив индексов начала вхождений</returns>
        public static int[] FindAllOccurrences(string source, string substring)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(substring))
                return new int[0];

            var indices = new List<int>();
            int index = 0;

            while ((index = source.IndexOf(substring, index)) != -1)
            {
                indices.Add(index);
                index += substring.Length;
            }

            return indices.ToArray();
        }

        /// <summary>
        /// Замена всех вхождений подстроки в строке
        /// </summary>
        public static string ReplaceAll(string source, string oldValue, string newValue, bool ignoreCase = false)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(oldValue))
                return source;

            return source.Replace(oldValue, newValue, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
        }

        /// <summary>
        /// Переворачивание строки
        /// </summary>
        public static string Reverse(string source)
        {
            if (string.IsNullOrEmpty(source))
                return source;

            char[] charArray = source.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
