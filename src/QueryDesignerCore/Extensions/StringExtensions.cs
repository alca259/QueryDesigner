using System;

namespace QueryDesignerCore.Extensions
{
    /// <summary>
    /// Extensions for String
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Contains with StringComparison
        /// </summary>
        /// <param name="str">Original string</param>
        /// <param name="substring">Comparing string</param>
        /// <param name="comp">Comparing setting</param>
        /// <returns></returns>
        public static bool Contains(this string str,string substring, StringComparison comp)
        {
            if (substring == null)
                throw new ArgumentNullException("substring",
                                                "substring cannot be null.");
            else if (!Enum.IsDefined(typeof(StringComparison), comp))
                throw new ArgumentException("comp is not a member of StringComparison",
                                            "comp");

            return str.IndexOf(substring, comp) >= 0;
        }
    }
}
