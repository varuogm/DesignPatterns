using SingletonCheck;
using System.Reflection;

void createTastySamosa(string value)
{
    Samosa kaisaHaiSamosa = Samosa.BanaLeyEkObject(value);
    Console.WriteLine(kaisaHaiSamosa.ChutneyTaste);
}

//2 threads ko samosa ki filling taste assign karke Race kara dete he and dekhte he locking sahi se kaam karrhi he ki nahi

// if both the vaules are same that means locking is working 
Thread process1 = new Thread(() =>
{
    createTastySamosa("meetha");
});
Thread process2 = new Thread(() =>
{
    createTastySamosa("mirchi");
});


process1.Start();
process2.Start();

process1.Join();
process2.Join();


Console.ReadLine();


//check last commit for these below example
//Lazy loading of samosa chutneys

//Samosa samosa = Samosa.BanaLeyEkObject(); //first instance of samosa

//Console.WriteLine(samosa.GetSamosaChutney("green"));
//Console.WriteLine(samosa.GetHashCode());

//Samosa samosa2 = Samosa.BanaLeyEkObject();  //second instance of samosa

//Console.WriteLine(samosa2.GetSamosaChutney("red"));
//Console.WriteLine(samosa2.GetHashCode());


//Console.WriteLine("-----------------------------------\n");

//Eager loading behavior

//Jalebi jalebi = Jalebi.BanaLeyEkObject();

//Console.WriteLine(jalebi.GetJalebiChaasni("meetha"));
//Console.WriteLine(jalebi.GetHashCode());

//Jalebi jalebi2 = Jalebi.BanaLeyEkObject();

//Console.WriteLine(jalebi2.GetJalebiChaasni("teekha"));
//Console.WriteLine(jalebi2.GetHashCode());

