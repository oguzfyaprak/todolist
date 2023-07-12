List<string> todolist = new List<string>();
var cikis = 0;

do
{
    Console.WriteLine(" Görev giriniz:  ");
    string yazı = Console.ReadLine();
    todolist.Add(yazı);
    if (todolist.Count > 0)
    {
        Console.WriteLine("Yapılacaklar listesi:");
        for (int i = 0; i < todolist.Count; i++)
        {
            Console.WriteLine("- " + todolist[i]);
        }
        Console.WriteLine("");
    }
    Console.WriteLine("Devam etmek için lütfen 1'e basınız: \nÇıkış yapmak için herhangi bir tuşa basınız: ");
    cikis = Convert.ToChar(Console.ReadKey().KeyChar);

}
while (cikis == '1');