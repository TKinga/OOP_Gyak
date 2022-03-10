
using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    /*
Házi feladat kiinduló pont (4. hét):

Készítsen Book osztályt és egy Book osztályt 
használó osztályt az adatrejtés elvének betartásával. 
Az adattagjait és a metódusait a megadott
néven nevezze el.
 
A Book osztály adattagjai: 
title (könyv címe), author (könyv szerzője),
yearOfPublication (megjelenés éve), price (ára forintban)

A Book osztály metódusai:
1. IncreasePrice: egy paraméterként kapott százalékos értékkel növeli a könyv árát. Pl. input 15 -> a könyv árát 15%-al növeli
Ha az input 0 vagy negatív, akkor ne változzon a könyv ára.

2. DisplayInfo: egy  String-be összefűzi a könyv összes adatát és ezt adja vissza. 

3. Setter metódusok az adattagok beállításához, és getter metódusok az adattagok lekérdezéséhez.
Értékadás előtt ellenőrzések:
- a megjelenés éve, ha nem 1950 és 2021 között van, legyen 2021, egyébként a megadott érték
- az ár legyen 1000 forint 1000-nél kisebb értékekre, egyébként a megadott érték

A Book osztályt használó osztályban (Homework) hozzon 
létre egy könyvet, majd
- adjon értéket az adattagjainak,
- jelenítse meg az adatait,
- növelje meg az árát 10%-al,
- jelenítse meg ismét az adatait.      */
    public class Book
    {
        string title;
        string author;
        int yearOfPublicaton;
        int price;


//2. DisplayInfo: egy String-be összefűzi a könyv összes adatát és ezt adja vissza.

       public string DisplayInformation()
        {

            return author + ": " + title + " (" + yearOfPublicaton + "), " + price + "Ft";
        }


        /*A Book osztály metódusai:
1. IncreasePrice: egy paraméterként kapott százalékos értékkel növeli a könyv árát.Pl.input 15 -> a könyv árát 15%-al növeli
Ha az input 0 vagy negatív, akkor ne változzon a könyv ára. */


        public void IncreasePrice(int value)
        {
            if (value > 0)
            {
                price += (int)Math.Round(price * value / 100.0); //100.0 mert így nem egész 
            }
        }


/*3. Setter metódusok az adattagok beállításához, és getter metódusok az adattagok lekérdezéséhez.
Értékadás előtt ellenőrzések:
- a megjelenés éve, ha nem 1950 és 2021 között van, legyen 2021, egyébként a megadott érték
- az ár legyen 1000 forint 1000-nél kisebb értékekre, egyébként a megadott érték*/


        public void SetAuthor(string author)
        {
            this.author= author;
        }


        public void SetPrice(int v)
        {
            if (v >1000)
            {
                price = v;
            }
            
            else
            {
                price = 1000;
            }
        }




        public int GetPrice()
        {
            return price;
        }


        public void SetTitle(string v)
        {
            title = v;
        }




        public void SetYearOfPublication(int v)
        {
            if (v >= 1950 && v < 2021)
            {
               yearOfPublicaton = v;
            }

            else
            {
                yearOfPublicaton = 2021;
            }
        }



        public int GetYearOfPublication()
        {
            return yearOfPublicaton;
        }




    }
}
