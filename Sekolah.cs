using System;
namespace Sekolah_nmspc
{
    class Sekolah_cls
    {
        public delegate double v(params int[] o);
        public interface Sekolah_face
        {
            //public delegate double Lingkaran_V(int o,int o2);      
                    public static string V(v dua,params int[] inm)
                    {
                        return dua(inm).ToString();
                    }
                    
            public static void Pilih()
            {
                string rumus;
                        Console.WriteLine("1. Luas Segitiga");
                        Console.WriteLine("2. Luas Persegi Panjang");
                        Console.WriteLine("3. Luas Lingkaran");
                        Console.WriteLine("4. Volume Balok");
                        Console.WriteLine("5. Keluar");
                        do
                        {     
                            System.Console.Write("Masukkan Pilihan Anda : ");
                            rumus = System.Console.ReadLine();
                        }
                        while (rumus != "01" && rumus != "02" && rumus != "03" && rumus != "04");
                        int[] xr;
                        xr =  rumus == "04" ? xr = new int[3] : xr = new int[2];
                        
                        switch(rumus)
                        {
                            case "01":
                                    
                                        for(int i = xr.Length - 1; i >= 0; i--)
                                        {
                                            System.Console.Write("Masukkan Inputan: ");
                                            xr[i] = Convert.ToInt32(Console.ReadLine());
                                        }
                                        System.Console.WriteLine("luas : " + V((x) => x[0] * x[1] * 0.5f,xr));
                            break;
                            case "02":
                                    
                                        for(int i = xr.Length - 1; i >= 0; i--)
                                        {
                                            System.Console.Write("Masukkan Inputan: ");
                                            xr[i] = Convert.ToInt32(Console.ReadLine());
                                        }
                                        System.Console.WriteLine("luas : " + V((x) => x[0] * x[1],xr));
                            break;
                            
                            case "03":
                                    
                                        for(int i = xr.Length - 1; i >= 0; i--)
                                        {
                                            System.Console.Write("Masukkan Inputan: ");
                                            xr[i] = Convert.ToInt32(Console.ReadLine());
                                        }
                                        System.Console.WriteLine("luas : " + V((x) => x[0] * x[1] * 3.14f,xr));
                            break;
                            case "04":
                                    
                                        for(int i = xr.Length - 1; i >= 0; i--)
                                        {
                                            System.Console.Write("Masukkan Inputan: ");
                                            xr[i] = Convert.ToInt32(Console.ReadLine());
                                        }
                                        System.Console.WriteLine("volume : " + V((x) => x[0] * x[1] * x[2],xr));
                            break;
                            default : System.Console.WriteLine("Keluar ");
                            break;
                        };
            }
        }
    }

    class Runner_Bro : Sekolah_cls,Sekolah_cls.Sekolah_face
    {
        public static void Main()
        {
          Sekolah_face.Pilih();
        }
    }
}
