// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Deklarasi Pustaka 
using System;
using System.Reflection;

// Kelas
class Tugas{
    // Fungsi utama / gerbang masuk coding mulai di baca dari sini
    static void Main(String[] args){
        //System.Console.WriteLine("Hello World!");// buat print kata (kayak cout);
        // Variable
        /*
        string devisi = "Game";
        var angka = 4; // variable otomatis
        const float phi = 3.14f; // const tetap ga bisa di ubah
        System.Console.WriteLine(devisi);
        System.Console.WriteLine(angka);
        System.Console.WriteLine(phi);
        */

        //System.Console.WriteLine("Hello World!"); // Sintaks komentar 1 line

        /*
        System.Console.WriteLine("Hello World!"); // Komentar banyak line
        */

        /*
        int bil = 10; // Tipe data bilangan bulat
        double bil1 = 3.14; // Tipe data ada koma
        float bil2 = 3.14f; // kurang lebih sama
        System.Console.WriteLine(bil);
        System.Console.WriteLine(bil1);
        System.Console.WriteLine(bil2);
        */

        /*
        string firstName = "DNCC";
        string lastName = "Game";

        firstName += lastName; // menambahkan variable

        System.Console.WriteLine(firstName);

        string nama = "Richard\tChristoper\tSubianto\r"; // \t jarak \r baris baru
        System.Console.WriteLine(nama);
        */

        /*
        string teks = "Ini Bukan Teks";
        System.Console.WriteLine(teks.ToLower()); // Manipulasi String untuk kecil semua
        System.Console.WriteLine(teks.ToUpper()); // Manipulasi String untuk besar semua
        System.Console.WriteLine("Panjang teks adalah " + teks.Length); // mencari panjang string
        System.Console.WriteLine(teks + " teks tambahan"); // tambahan teks

        var date = DateTime.Now;
        string name = "Aulia";
        Console.WriteLine($"Halo, {name}! hari ini adalah {date.DayOfWeek}, Jam {date:HH:mm} WIB.");
        */

        /*
        bool benar = true; // boolean variable true atau false

        if(benar == true) // if else jika maka
        {
            System.Console.WriteLine("Benarrrrrrrr");
        }
        else
        {
            System.Console.WriteLine("Salahhhhhhh");
        }
        */

        /*
        float first = 14.5f;
        int second = (int) first;// konversi tipe data
        System.Console.WriteLine(second);

        int sepulu = 10;
        float koma = 9.8f;
        System.Console.WriteLine($"{sepulu.ToString()}{koma.ToString()}");// konversi angka ke string
        */

        /*
        string satu = "1";
        string dua = "2";
        int sum = int.Parse(satu) + int.Parse(dua);
        System.Console.WriteLine(sum);
        */

        /*
        // Operator Aritmatika
        int angka1 = 10;
        int angka2 = 3;
        int plus = angka1 + angka2; // Penjumlahan
        System.Console.WriteLine(plus);
        int min = angka1 - angka2;// Pengurangan
        System.Console.WriteLine(min);
        int kali = angka1*angka2; // Kali
        System.Console.WriteLine(kali);
        int bagi = angka1 / angka2; // Bagi
        System.Console.WriteLine(bagi);
        int modulo = angka1 % angka2; // Sisa bagi
        System.Console.WriteLine(modulo);

        // Operator Penugasan
        angka1 += 8;
        System.Console.WriteLine(angka1);
        angka1 -= 8;
        System.Console.WriteLine(angka1);
        angka1 *= 8;
        System.Console.WriteLine(angka1);
        angka1 /= 8;
        System.Console.WriteLine(angka1);
        angka1 %=4;
        System.Console.WriteLine(angka1);
        */

        /*
        // increment dan decrement
        int a = 5;
        ++a; System.Console.WriteLine(a);
        a++; System.Console.WriteLine(a);
        a--; System.Console.WriteLine(a);
        --a; System.Console.WriteLine(a);
        */

        // Operator Perbandingan
        // == : Sama Dengan
        //  > : Lebih Dari
        //  < : Kurang Dari
        // >= : Lebih Dari atau Sama Dengan
        // <= : Kurang Dari atau Sama Dengan

        // Operator Logika
        // && : Dan
        // || : Atau
        //  ! : Kebalikan

        /*
        // Array 1D
        string[] devisi = {"Web","Mobile","Jaringan","Game","Mulmed"};
        System.Console.WriteLine(devisi[0]);
        System.Console.WriteLine(devisi[1]);
        System.Console.WriteLine(devisi[2]);
        System.Console.WriteLine(devisi[3]);
        System.Console.WriteLine(devisi[4]);
        System.Console.WriteLine(devisi[5]);
        */

        /*
        // Array 2D
        int[,] number = new int[2,3];
        int[,] numbers = 
        {
            {
                1 , 2 , 3
            },
            {
                4 , 5 , 6
            }
        };
        System.Console.WriteLine(numbers[0,1]);
        System.Console.WriteLine(numbers[1,2]);
        */
        
        /*
        //Array 3D
        int[,,] number = new int[2,2,3];
        int[,,] numbers = {{{1 , 2 , 3},{4 , 5 , 6}},{{7 , 8 , 9},{10 , 11 , 12}}};
        System.Console.WriteLine(numbers[0,0,0]);
        System.Console.WriteLine(numbers[1,1,2]);
        */

        /*
        // List
        var names = new List<string>{"Game","Mobile","Web"};
        for (int i = 0; i < names.Count; i++){
            System.Console.WriteLine(names[i]);
        }

        List<int> angka = new List<int>();
        // Menambahkan Data Pada List
        angka.Add(1);
        angka.Add(2);
        angka.Add(3);
        // Menambahkan sekaligus beberapa data
        angka.AddRange(new int[3]{4 , 5 , 6});
        // Menghapus angka / item
        angka.Remove(1);
        // Menghapus data berdasarkan index
        angka.RemoveAt(0);
        // Mengetahui index pada suatu data
        angka.IndexOf(3);
        // Mengecek apakah ada data yang sesuai
        System.Console.WriteLine(angka.Contains(10));
        // Mengetahui panjang suatu list
        System.Console.WriteLine(angka.Count());

        foreach (var a in angka)
        {
            System.Console.WriteLine(a + " ");
        }
        */

        /*
        // Pengkondisian
        int i = 5;
        if (10 > 5){
            System.Console.WriteLine("Benar ! ");
        }else
        {
            System.Console.WriteLine("Salah ! ");
        }

        int nilai = 75;
        if ( nilai >= 90){
            System.Console.WriteLine("Anda Mendapat A.");
        }else if ( nilai >= 80){
            System.Console.WriteLine("Anda Mendapat B.");
        }else if ( nilai >= 70){
            System.Console.WriteLine("Anda Mendapat C.");
        }else{
            System.Console.WriteLine("Anda Mendapat D atau E");
        }

        switch (nilai)
        {
            case > 95 :
                System.Console.WriteLine("Memuaskan");
            break;
            
            case > 80 :
                System.Console.WriteLine("Baik");
            break;
            
            case > 75 : 
                System.Console.WriteLine("Cukup");
            break;

            default : 
                System.Console.WriteLine("Kurang");
            break;
        }
        */

        /*
        // Ternary Operator
        int angka = 10; 
        string hasil = (angka % 2 == 0) ? "Genap" : "Ganjil";
        System.Console.WriteLine(hasil);
        */

        /*
        // Perulangan
        for (int i = 0; i < 5; i++){
            System.Console.WriteLine("Perulangan Ke-" + i);
        }

        int j =  0;
        while (j < 5){
            System.Console.WriteLine("Perulangan Ke-" + j);
            j++;
        }

        int k = 5;
        do
        {
            System.Console.WriteLine("Perulangan Ke-" + k);
            k++;
        }while (k < 5);
        
        int l = 0;
        int[] angka = new int[5]{1,2,3,4,5};
        foreach (int a in angka)
        {
            System.Console.WriteLine("Ini adalah isi array urut dari indeks ke " + l++ + " yaitu " + a);
        } 
        */
        
        /*
        // Break dan Continue
        for (int i = 0; i < 10; i++){
            System.Console.WriteLine(i);

            if (i==5){
                break;
            }
        }

        for (int i = 0; i < 10; i++){
            if (i % 2 == 0){
                continue;
            }
            System.Console.WriteLine(i);
        }
        */

        /*
        Tampil();

        int hasil = Return();
        System.Console.WriteLine(hasil);

        int Hp = counter(10);
        System.Console.WriteLine(Hp);
        */
    }

    /*
    public static void Tampil(){
        System.Console.WriteLine("Game !");
    }

    public static int Return(){
        return 5;
    }

    public static int counter(int damage){
        return damage + 5;
    }
    */
}