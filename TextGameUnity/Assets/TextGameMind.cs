using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGameMind : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Witaj w grze");
        Debug.Log("Wymy�l w g�owie liczb� od 1 do 1000");
        Debug.Log("Czy liczba jest wieksza od 500?");
            Debug.Log("Naci�nij g�rn� strza�ke je�li twoja liczba jest wi�ksza od 500");
                Debug.Log("Naci�nij doln� strza�ke je�li twoja liczba jest mniejsza od 500");
        Debug.Log("Naci�nij enter je�eli liczba jest r�wna");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        { Debug.Log("Liczba wieksza"); }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        { Debug.Log("Liczba mniejsza"); }
        if (Input.GetKeyUp(KeyCode.Return))
        { Debug.Log("Liczba r�wna"); }
        if (Input.GetKeyUp(KeyCode.KeypadEnter))
        { Debug.Log("Liczba r�wna"); }

    }
}
