string frase = Console.ReadLine()!;
string baleia = frase.ToUpper().Replace("A","aaa").Replace("O","ooo").Replace("E","eee").Replace("I","iii").Replace("U","uuu");
string traducao =baleia.Substring(0,1).ToUpper()+baleia.Substring(1).ToLower();
Console.ForegroundColor = ConsoleColor.Blue;
for (int i = 0; i < traducao.Length; i++)
{
 Console.Write(traducao[i]);
 Thread.Sleep(75);   
}
Console.ResetColor();
