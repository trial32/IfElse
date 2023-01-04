// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program başladı..");

int time =DateTime.Now.Hour;

if (time >= 6 && time < 12)
    Console.WriteLine("Günaydın");
else if (time <= 18)
    Console.WriteLine("İyi günler");
else
    Console.WriteLine("İyi geceler");

string sonuc = time >= 6 && time < 12 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi geceler";

Console.WriteLine(sonuc);