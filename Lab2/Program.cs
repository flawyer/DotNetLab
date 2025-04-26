using FirstVB;
using System;
using System.Linq;

    class Program 
    {
       
        static void Main()
        {
        
        string[] filenames = new string[]
      {
            "c71d1cd4-252e-48a5-94bf-c71ca7f68e4a_CustomerName.C1.D20230115-T082015",
            "f335d3e8-7ddc-42d2-9dc1-e456c80fd758_CustomerName.C2.D20201015-T120511",
            "f3e26374-fe23-459f-8567-c586715d18ae_CustomerName.C4.D20210414-T111220"
      };

        DateTime utcNow = DateTime.UtcNow;
        TimeSpan nptOffset = new TimeSpan(5, 45, 0);
        DateTime nptNow = utcNow.Add(nptOffset);

        string newTimestamp = $"D{nptNow:yyyyMMdd}-T{nptNow:HHmmss}";

        Console.WriteLine("Updated Filenames:\n");

        for (int i = 0; i < filenames.Length; i++)
        {
            string[] parts = filenames[i].Split('.');

            if (parts.Length >= 3)
            {
                parts[2] = newTimestamp;
                filenames[i] = string.Join(".", parts);
            }
            Console.WriteLine(filenames[i]);
        }

        MathOperations math = new MathOperations();
        var addR = math.Add(2, 3);
        Console.WriteLine("The add  of int is" + addR);
        var addDouble = math.Add(3.0, 3.0);
        Console.WriteLine("The add  of double is" + addDouble);
        var MultiplyR = math.Multiply(5, 2);
        Console.WriteLine("The multiply  of int is" + MultiplyR);
        var MultiplyD = math.Multiply(5.0, 2.0);
        Console.WriteLine("The multiply  of double is" + MultiplyD);


        CallInterface cI = new CallInterface();
       
        var addcIDouble = cI.Add(3.0, 3.0);
        Console.WriteLine("The add  of double using Interface is" + addcIDouble);
        var subcIDouble = cI.Substract(3.0, 3.0);
        Console.WriteLine("The sub  of double using Interface is" + subcIDouble);
        var MultiplyCD = math.Multiply(5.0, 2.0);
        Console.WriteLine("The multiply  of double using Interface is" + MultiplyCD);
        var Division = math.Multiply(5.0, 2.0);
        Console.WriteLine("The divivion  of double using Interface is" + Division);

        var PalString = "cat";
        var PalLength = PalString.Length-1;
        var CheckPalString = "";
        for(var i = PalLength; i >= 0; i--)
        {
            CheckPalString += PalString[i];
        }

        Console.WriteLine(CheckPalString);
        if(PalString == CheckPalString)
        {
            Console.WriteLine("this is Palindrome");
        }
        else
        {
            Console.WriteLine("this is not Palindrome");
        }
        Console.ReadKey();

    
    }


}
                            