using OOP2;

GerçekMüsteri müsteri1 = new GerçekMüsteri();
müsteri1.Id= 1;
müsteri1.TcNo = "16483184843843";
müsteri1.MusteriNo = "789454";
müsteri1.Adi = "yusuf";
müsteri1.Soyadi = "yıldız";

TuzelMusteri musteri2 = new TuzelMusteri(); 
musteri2.Id = 2;
musteri2.MusteriNo = "5484";
musteri2.VergiNo = "54454";
musteri2.SirketAdi = "yıldız ltdt.şti";

Musteri musteri3 = new GerçekMüsteri();
Musteri Musteri4 = new TuzelMusteri();

CustomerManager customerManager= new CustomerManager();
customerManager.Add(müsteri1);
customerManager.Add(musteri2);
