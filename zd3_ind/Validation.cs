using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zd3_ind
{
    public static class Validation
    {
        public static string CarNull(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Поля пустые, заполните их";
            }
            return string.Empty;
        }
        public static string TolkoNum(string text)
        {
            if (!Regex.IsMatch(text, @"^\d+$"))
            {
                return "Неправильный ввод данных, ввод только цифрами";
            }
            return string.Empty;
        }
        public static string TolkoBukv(string text)
        {
            if (!Regex.IsMatch(text, @"^[a-zA-Zа-яА-Я]+$"))
            {
                return "Неправильный ввод данных, ввод только буквами";
            }
            return string.Empty;
        }
    }
}
