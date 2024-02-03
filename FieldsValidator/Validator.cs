using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace FieldsValidator;
public static class Validator
{
    private static Regex _debtRegex;
    private static Regex _nameRegex;
    private static Regex _addressRegex;

    static Validator()
    {
        _debtRegex = new("^[1-9]\\d+([/,/.]\\d+)?$");
        _nameRegex = new("^[A-ZА-Я][a-zа-я]{1,31}$");
        _addressRegex = new("^([A-Z][a-z]{1,16}\\s)?([A-Z][a-z]{1,16}\\s)?[A-Z][a-z]{1,16}\\s\\d{1,3}([a-d])?$");
    }
    public static bool IsValidDebt(string debt) => _debtRegex.IsMatch(debt);
    public static bool IsValidName(string name) => _nameRegex.IsMatch(name);
    public static bool IsValidAddress(string address) => _addressRegex.IsMatch(address);

}
