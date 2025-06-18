Console.WriteLine("Lütfen 5 adet kahve ismi giriniz.");
List<string> kahveListesi = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Kahve {i + 1}: ");
    string kahve = Console.ReadLine();

    // İlk harfi büyük, kalanları küçük yap
    string duzenliIsim = char.ToUpper(kahve[0]) + kahve.Substring(1).ToLower();

    // DÜZENLENMİŞ ismi listeye ekle
    kahveListesi.Add(duzenliIsim);
}

Console.WriteLine("------- KAHVE LİSTENİZ -------");
foreach (var item in kahveListesi)
{
    Console.WriteLine(item);
}