using System.Text;
using System.Text.RegularExpressions;

namespace TD.KCN.WebApi.Application.Common;

public static class Utils
{
    /// <summary>
    /// Loại bỏ dấu diacritics (dấu tiếng Việt) và chuyển đổi các ký tự đặc biệt.
    /// </summary>
    public static string RemoveDiacriticsAndConvertSpecialChars(string input)
    {
        Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
        string normalizedString = input.Normalize(NormalizationForm.FormD);
        return regex
            .Replace(normalizedString, string.Empty)
            .Replace('\u0111', 'd')
            .Replace('\u0110', 'D');
    }
}