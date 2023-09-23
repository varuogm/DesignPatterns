using SingletonCheck;


//Lazy loading of samosa chutneys

Samosa samosa = Samosa.BanaLeyEkObject(); //first instance of samosa

Console.WriteLine(samosa.GetSamosaChutney("green"));
Console.WriteLine(samosa.GetHashCode());

Samosa samosa2 = Samosa.BanaLeyEkObject();  //second instance of samosa

Console.WriteLine(samosa2.GetSamosaChutney("red"));
Console.WriteLine(samosa2.GetHashCode());


Console.WriteLine("-----------------------------------\n");

//Eager loading behavior

Jalebi jalebi = Jalebi.BanaLeyEkObject();

Console.WriteLine(jalebi.GetJalebiChaasni("meetha"));
Console.WriteLine(jalebi.GetHashCode());

Jalebi jalebi2 = Jalebi.BanaLeyEkObject();

Console.WriteLine(jalebi2.GetJalebiChaasni("teekha"));
Console.WriteLine(jalebi2.GetHashCode());



Console.ReadLine();

