/*Задача 3: Задайте произвольную строку. Выясните,
является ли она палиндромом.

“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да*/

static bool IsPalindrome(string str)
{
    int i = 0;
    int j = str.Length - 1;

    while (i < j)
    {
        if (str[i] != str[j])
        {
            return false;
        }
        i++;
        j--;
    }
    return true;
}

string str = "hahahahahah";
bool isPalindrome = IsPalindrome(str.ToLower().Replace(" ", "").Replace(",", "").Replace(".", ""));

if (isPalindrome)
{
    Console.WriteLine("=> Да");
}
else
{
    Console.WriteLine("=> Нет");
}