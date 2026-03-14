using System;
public class KodePos
{
    string[] kelurahan =
    {
        "Batununggal","Kujangsari","Mengger","Wates","Cijaura",
        "Jatisari","Margasari","Sekejati","Kebonwaru","Maleer"
    };

    int[] kodePos =
    {
        40266,40287,40267,40256,40287,
        40286,40286,40286,40272,40274
    };

    public int getKodePos (string namaKelurahan)
    {
        for(int i = 0; i < kelurahan.Length; i++)
        {
            if (kelurahan[i] == namaKelurahan)
            {
                return kodePos[i];
            }
        }
        return -1;
    }
}

class DoorMachine
{
    enum State {Terkunci, Terbuka}

    private State state;

    public DoorMachine()
    {
        state = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (state == State.Terkunci)
        {
            state = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.WriteLine("Batununggal : " + kode.getKodePos("Batununggal"));
        Console.WriteLine("Kujangsari  : " + kode.getKodePos("Kujangsari"));
        Console.WriteLine("Mengger     : " + kode.getKodePos("Mengger"));
        Console.WriteLine("Wates       : " + kode.getKodePos("Wates"));
        Console.WriteLine("Cijaura     : " + kode.getKodePos("Cijaura"));
        Console.WriteLine("Jatisari    : " + kode.getKodePos("Jatisari"));
        Console.WriteLine("Margasari   : " + kode.getKodePos("Margasari"));
        Console.WriteLine("Sekejati    : " + kode.getKodePos("Sekejati"));
        Console.WriteLine("Kebonwaru   : " + kode.getKodePos("Kebonwaru"));
        Console.WriteLine("Maleer      : " + kode.getKodePos("Maleer"));


        Console.WriteLine("\nSimulasi DoorMachine:");

        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.BukaPintu();
       
    }
}





