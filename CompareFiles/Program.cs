//guardo la ruta al archivo 
string filePath = Directory.GetCurrentDirectory() + "\\File_1.txt";

byte[] bFile1 = await getBytes(filePath);

//hago como que llamo a una API async
byte[] bFile2 = await getFileFromAPI();

//Comparo
Console.WriteLine($"Son Iguales?: {bFile1.SequenceEqual(bFile2)}");

static async Task<byte[]> getBytes(string fileName)
{
    byte[] result;
    using (FileStream stream = File.Open(fileName, FileMode.Open))
    {
        result = new byte[stream.Length];
        await stream.ReadAsync(result, 0, (int)stream.Length);
    }
    return result;
}

static async Task<byte[]> getFileFromAPI() 
{
    await Task.Delay(100);
    return new byte[] { 239, 187, 191, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32, 70, 73, 76, 69, 32, 49, 32 };
}
