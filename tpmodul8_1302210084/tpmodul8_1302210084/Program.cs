using tpmodul8_1302210084;

CovidConfig config = CovidConfig.LoadConfig();

Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai" + config.satuan_suhu);
string inputSuhu = Console.ReadLine();
Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
string inputHari = Console.ReadLine();

double suhu = double.Parse(inputSuhu);
int hari = int.Parse(inputHari);

if (config.satuan_suhu == "celcius")
{
    if (suhu >= 36.5 && suhu <= 37.5 && hari < config.batas_hari_demam)
    {
        Console.WriteLine(config.pesan_diterima);
    }
    else
    {
        Console.WriteLine(config.pesan_ditolak);
    }
}
else
{
    double suhuF = (suhu * 9 / 5) + 32;
    if (suhuF >= 97.7 && suhuF <= 99.5 && hari < config.batas_hari_demam)
    {
        Console.WriteLine(config.pesan_diterima);
    }
    else
    {
        Console.WriteLine(config.pesan_ditolak);
    }
}