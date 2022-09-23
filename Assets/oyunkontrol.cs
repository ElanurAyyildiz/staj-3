using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrol : MonoBehaviour
{
    int minsayi = 1;
    int maxsayi = 100;
    int tahmin ;
    bool oyunBasladi=false;
    bool oyunBitti=false;

    void Start()
    {
        print("Benim ile oyun oynamak ister misin?(E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        if(! oyunBasladi)
        {
            //-------------------------Baslangic------------
            if (Input.GetKeyDown(KeyCode.E))
            {
                print ("Harika! Aklinda 1 - 100 arasinda bir  sayi tut ve enter tusuna bas!");
            }
            else if(Input.GetKeyDown(KeyCode.H))
            {
                print("Sen bilirsin !");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Kontrol();
                oyunBasladi = true;
            }
            //----------------------Baslangic-------------------
        }
        else if(!oyunBitti)
        {
        //-------------------------Oyun----------------

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            minsayi =tahmin;
            Kontrol();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxsayi=tahmin;
            Kontrol();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Yasasin,aklindaki sayiyi buldum!");
            oyunBitti=true;
        }
        //---------------------oyun----------------
        }
        void Kontrol(){
            tahmin = (minsayi + maxsayi)/2;
            print("Aklinda tutugun sayi"+ tahmin +" mi? Daha buyuk ise yukari,daha kucuk ise asagi yon tusuna bas!Dogruysa bosluk tusuna bas!"); 
        } 
    }
}

