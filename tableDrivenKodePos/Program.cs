using System;
using static KodePos;

public class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja};

    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] kodePosTiapKelurahan = { 40266 , 40287 , 40267 , 40256 , 40287 , 40286 , 40286 , 40286 , 40272 , 40274 , 40273 };
        return kodePosTiapKelurahan[(int) kelurahan];
    }
};

public class main
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukkan nama kelurahan yang ingin anda cari kode posnya");
        Console.Write("Nama Kelurahan: ");
        String inputKelurahan = Console.ReadLine();
        if (Enum.TryParse<KodePos.Kelurahan>(inputKelurahan, true, out KodePos.Kelurahan kelurahan))
        {
            Console.WriteLine($"Kode Pos: {KodePos.getKodePos(kelurahan)}");
        }
        else
        {
            Console.WriteLine("Nama kelurahan tidak valid.");
        }
    }
}