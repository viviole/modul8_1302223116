using modul8_1302223116;

internal class Program
{
    private static void Main(string[] args)
    {
        Config_1302223116 config = new Config_1302223116();
        config.readJson();
        if (config.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
        }
        else if (config.config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
        }

        int biaya = 0;
        String jumlahTF = Console.ReadLine();        
        if (Convert.ToInt32(jumlahTF) <= Convert.ToInt32(config.config.transfer.treshold))
        {            
            biaya = Convert.ToInt32(config.config.transfer.low_fee);
            Console.WriteLine(biaya);
        }
        else
        {       
            biaya = Convert.ToInt32(config.config.transfer.low_fee);
        }

        if (config.config.lang == "en")
        {
            Console.WriteLine("Transfer fee = " + biaya + " and Total amount = " + (Convert.ToInt32(jumlahTF) + biaya));
        }
        else if (config.config.lang == "id")
        {
            Console.WriteLine("Biaya transfer = " + biaya + " dan Total biaya = " + (Convert.ToInt32(jumlahTF) + biaya));
        }

        if (config.config.lang == "en")
        {
            Console.WriteLine("Select transfer method: ");
        }
        else if (config.config.lang == "id")
        {
            Console.WriteLine("Pilih metode transfer: ");
        }

    }
}