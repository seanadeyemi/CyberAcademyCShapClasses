//for loop

//for(int i = 0; i < 1000; i++)
//{
//    Console.WriteLine("Hello, World!");
//}

//foreach

List<string> namesOfSoftwareDevs = new List<string>();

namesOfSoftwareDevs.Add("Felix");
namesOfSoftwareDevs.Add("Victor");
namesOfSoftwareDevs.Add("Caleb");
namesOfSoftwareDevs.Add("Anita");
namesOfSoftwareDevs.Add("Jonathan");

//for (int i = 0; i < namesOfSoftwareDevs.Count; i++)
//{
    
//    Console.WriteLine(namesOfSoftwareDevs[i] + " Software");
//}


foreach (string name in namesOfSoftwareDevs)
{
    //if (name.EndsWith("a"))
    //{
    //   Console.WriteLine(name);  
    //}
    Console.WriteLine(name.Replace("Vic", " ").ToUpper());
   
}

//int k = 0;
//while(k < 5)
//{
//    Console.WriteLine("Hello");
//    k++;
//}

//int j = 0;
//do 
//{
//    Console.WriteLine("Hi");
//} while (j < 5);



Console.ReadKey();