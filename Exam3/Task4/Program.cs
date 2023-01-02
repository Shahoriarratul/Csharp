var path = "../../../text.txt";
var content = "hello from the computer";

if (!File.Exists(path))
    File.Create(path);


FileInfo f = new FileInfo(path);
using FileStream stream = f.Open(FileMode.Open);

for (int i = 0; i < f.Length; i++)
{
    char[] c = new char[8];
    c = stream.ReadByte();
    Console.WriteLine(c);
}
