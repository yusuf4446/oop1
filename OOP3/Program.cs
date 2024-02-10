using OOP3;
using System.ComponentModel.DataAnnotations;
// INTERFACELERDE CLASLARIN BELLEKTEKI REFERANS NUMARASINI TUTABILIYOR
IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();
IKrediManager tasıtKrediManager = new TasıtKrediManager();
//tasıtKrediManager.Hesapla();
IKrediManager konutKreddiManager = new KonutKreddiManager();
//konutKreddiManager.Hesapla();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.basvuruyap(konutKreddiManager);

List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager};
basvuruManager.KrediOnBilgilendirmesiYap(krediler);