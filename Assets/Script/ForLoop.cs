using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    // Start is called before the first frame update

    private int zeilenAnzahl = 3;
    void Start()
    {
        
        for (int zeile = 1; zeile <= zeilenAnzahl; zeile++)
        {
            string ausgabe = "";
            ausgabe = GeneriereMinuszeichen(ausgabe, zeile);

            for (int sterne = 1; sterne <= 2 * zeile - 1; sterne++)
            {
                ausgabe += "*";
            }

            ausgabe = GeneriereMinuszeichen(ausgabe, zeile);
            Debug.Log(ausgabe);
        }
    }

    private string GeneriereMinuszeichen(string ausgabe, int zeile)
    {
       
        for (int i = 1; i <= zeilenAnzahl - zeile; i++)
        {
            ausgabe += "-";
        }

        

        return ausgabe;
    }
}

   

