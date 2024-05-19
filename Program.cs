internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Veri Türleri ve minimum maximum değerleri");
        Console.WriteLine();
        // 8-bit integer
        Console.WriteLine(nameof(SByte));
        Console.WriteLine($"Minimum değer       :{SByte.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{SByte.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(SByte) + " byte",20}");
        Console.WriteLine();
       
        // 8-bit unsigned integer 
        Console.WriteLine(nameof(Byte));
        Console.WriteLine($"Minimum değer       :{Byte.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{Byte.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(Byte) + " byte",20}");
        Console.WriteLine();
     
        //signed 16 bit integer 
        Console.WriteLine(nameof(Int16));
        Console.WriteLine($"Minimum değer       :{Int16.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{Int16.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(Int16) + " byte",20}");
        Console.WriteLine();
        
        //unsigned 16 bit integer
        Console.WriteLine(nameof(Int16));
        Console.WriteLine($"Minimum değer       :{UInt16.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{UInt16.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(UInt16) + " byte",20}");
        Console.WriteLine();
        
        //signed 32 bit integer 
        Console.WriteLine(nameof(Int32));
        Console.WriteLine($"Minimum değer       :{Int32.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{Int32.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(Int32) + " byte",20}");
        Console.WriteLine();
      
        //unsigned 32 bit integer
        Console.WriteLine(nameof(UInt32));
        Console.WriteLine($"Minimum değer       :{UInt32.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{UInt32.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(UInt32) + " byte",20}");
        
        //Double ...
        Console.WriteLine(nameof(Double));
        Console.WriteLine($"Minimum değer       :{Double.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{Double.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(Double) + " byte",20}");
        Console.WriteLine();
    
        //Float ...
        Console.WriteLine(nameof(Single)); //float için system.Single Kullanılır
        Console.WriteLine($"Minimum değer       :{Single.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{Single.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(Single) + " byte",20}");
        Console.WriteLine();
        //Decimal ...
        Console.WriteLine(nameof(Decimal));
        Console.WriteLine($"Minimum değer       :{Decimal.MinValue,20}"); //iki nokta üstüste den sonra 20 karakter boş bırak
        Console.WriteLine($"Maximum değer       :{Decimal.MaxValue,20}");
        Console.WriteLine($"Boyut               :{sizeof(Decimal) + " byte",20}");
        Console.WriteLine();
        
        Console.ReadKey();
    }
}