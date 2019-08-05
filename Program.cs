using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;



public class Example
{

    public static void Main(string[] args)
    {
        //calling method writes to console
        string filePath = @"Root.txt";
        WriteRead.WriteToFile(filePath);
        Console.ReadLine();
        
    }
    
}

    


