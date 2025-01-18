// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// eğitimi ortaöğretim olanlara 3000 tl diğer tüm durumlar için 1000 tl burs verilecektir.
// eğitim durumunu kullanıcıdan alıp burs miktarını hesaplayan programı yazınız. (Switch case kullanınız)
// switch case yapısında operatorler kullanılamaz. sabit değerler kullanılabilir. when kullanılabilir.
start:
Console.WriteLine("Eğitim durumunuzu giriniz: ");
string egitimDurumu = Console.ReadLine();

// switch (egitimDurumu)
// {
//     case "1":
//     case "ortaöğretim":
//         Console.WriteLine("Burs miktarınız: 3000 TL");
//         break;
//     default:
//         Console.WriteLine("Burs miktarınız: 1000 TL");
//         break;
// }

switch (egitimDurumu)
{
    case "1":
    case "ortaöğretim":
        Console.WriteLine("Burs miktarınız: 3000 TL");
        break;
    case "5":
    case "lise":
    case "2":
    case "lisans":
    case "3":
    case "yükseklisans":
    case "4":
    case "doktora":
        Console.WriteLine("Burs miktarınız: 1000 TL");
        break;
    case string x when x == "6" || x == "7" || x == "8" :
        Console.WriteLine("Burs miktarınız: 0 TL (Diğer)");
        break;
    default:
        Console.WriteLine("Geçersiz eğitim durumu girdiniz.");
        break;
}
