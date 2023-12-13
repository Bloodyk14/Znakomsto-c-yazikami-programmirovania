/*Задача 2: Задайте строку, содержащую латинские буквы
в обоих регистрах. Сформируйте строку, в которой все
заглавные буквы заменены на строчные. 
“aBcD1ef!-” => “abcd1ef!-”*/

string OriginStr = "HeLLOWorld";

Console.WriteLine(OriginStr);
Console.WriteLine();
Console.WriteLine(ConverToLower(OriginStr));

string ConverToLower(string input)
{
    string result = string.Empty;
    
    foreach (char c in input) 
    {
        result += char.ToLower(c);
    }

    return result;
}