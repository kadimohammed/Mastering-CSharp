using System.IO.Compression;
using System.Text;
using ZE__Stream_IO;

//methode 1   ///////////////////////////////////////////////////////
/*
CurenciesService cs1 = null;
try
{
    cs1 = new CurenciesService();
    Console.WriteLine(cs1.GetCurencies());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    cs1?.Dispose();
}*/

//methode 2  ///////////////////////////////////////////////////////


using (CurenciesService cs2 = new CurenciesService())
{
    try
    {
        Console.WriteLine(cs2.GetCurencies());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


// FileStream/////////////////////////////////////////////////////////

string filePath = "C:\\Users\\MO KADI\\Desktop\\.net course\\Mastering-CSharp\\ZE- Stream IO\\example.txt";

// Écriture dans un fichier
using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    byte[] data = Encoding.UTF8.GetBytes("Hello, kadi!");
    fileStream.Write(data, 0, data.Length);
}



// lecture  d'un fichier
using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
{
    byte[] data = new byte[fileStream.Length];
    fileStream.Read(data, 0, data.Length);
    string content = Encoding.UTF8.GetString(data);
    Console.WriteLine("Contenu du fichier : " + content);
}













/*

static void Example02()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample.txt";
    using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
    {
        byte[] data = new byte[fs.Length];
        int numBytesToRead = (int)fs.Length;
        int numBytesRead = 0;
        while (numBytesToRead > 0)
        {
            int n = fs.Read(data, numBytesRead, numBytesToRead);

            if (n == 0)
                break;

            numBytesToRead -= n;
            numBytesRead += n;
        }

        foreach (var b in data)
        {
            Console.WriteLine(b);
        }

        var newPath = "C:\\Users\\Youya\\Desktop\\sample1.txt";
        using (var fsw = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            fsw.Write(data, 0, data.Length);
        }

    }

}

static void Example03()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample2.txt";
    using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
    {
        fs.Seek(20, SeekOrigin.Begin);
        fs.WriteByte(65);
        fs.Position = 0;
        for (int i = 0; i < fs.Length; i++)
        {
            Console.WriteLine(fs.ReadByte());
        }
    }
}

static void Example04()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample3.txt";
    using (var sw = new StreamWriter(path))
    {
        sw.WriteLine("This");
        sw.WriteLine("Is");
        sw.WriteLine("C#");

    }
}

static void Example05()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample3.txt";
    using (var sr = new StreamReader(path))
    {
        while (sr.Peek() > 0)
        {
            Console.Write((char)sr.Read());
        }
    }
}
static void Example06()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample3.txt";
    using (var sr = new StreamReader(path))
    {
        string line;
        while ((line = sr.ReadLine()) is not null) // != null
        {
            Console.WriteLine(line);
        }
    }
}
static void Example07()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample4.txt";

    string[] lines =
    {
                "C#",
                "Is",
                "Amazing",
                "Language"
            };

    File.WriteAllLines(path, lines);

}

static void Example08()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample5.txt";

    string text = "C# Is Amazing Language";

    File.WriteAllText(path, text);

}

static void Example09()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample5.txt";

    var result = File.ReadAllText(path);

    Console.WriteLine(result);
}

static void Example10()
{
    string path = "C:\\Users\\Youya\\Desktop\\sample4.txt";

    var lines = File.ReadAllLines(path);

    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}
*/


// decorator - Compress/Decompress File ////////////////////////////////////////////////

using (var stream = File.Create("C:\\Users\\MO KADI\\Desktop\\.net course\\Mastering-CSharp\\ZE- Stream IO\\data.bin"))
{
    using (var ds = new DeflateStream(stream, CompressionMode.Compress))
    {
        ds.WriteByte(65);
        ds.WriteByte(66);
    }
}

using (var stream = File.OpenRead("C:\\Users\\MO KADI\\Desktop\\.net course\\Mastering-CSharp\\ZE- Stream IO\\data.bin"))
{
    using (var ds = new DeflateStream(stream, CompressionMode.Decompress))
    {
        for (int i = 0; i < stream.Length; i++)
        {
            Console.WriteLine(ds.ReadByte());
        }
    }
}