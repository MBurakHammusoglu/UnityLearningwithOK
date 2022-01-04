using UnityEngine;
public class Ogrenci
{

    protected void ogrenciAdiVer(string ogrenciad)  //erişim belirtecini belirtmezsek varsayılan olarak private atanır.
    {
        Debug.Log("ogrenci ad" +ogrenciad);
    }








  /*  protected void ogrenciYasVer()  //miras alan sınıf sanki o sınıfta yazılmış bir fonk gibi kullanabilir ve aynı fonk gibi çağırılır yani ogrenciYasVer(); yaparak cagrılır
    {
        Debug.Log("Ogrenci Yası 20");
    }
    private void ogrenciTCVer()  // Sadece bu sınıfta kullanılabilir diğer sınıflar kullanamaz.
    {
        Debug.Log("Ogrenci TC 202132131"); 
    }
  */


}
