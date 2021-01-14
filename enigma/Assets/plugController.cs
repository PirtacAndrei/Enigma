using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class plugController : MonoBehaviour
{
    [SerializeField]
    GameObject enigma=null;
    [SerializeField]
    GameObject connectedTo = null;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TMP_InputField>().text = " ";
    }

    int letterToNumber(char c)
    {
        return ((int)c % 32) - 1;
    }

    public void TryToChange()
    {
       
        if(connectedTo.GetComponent<TMP_InputField>().text!=" ") 
        {
            if (this.GetComponent<TMP_InputField>().text.ToCharArray().Length == 1)
            {

                int j = letterToNumber(this.GetComponent<TMP_InputField>().text.ToCharArray()[0]);
                int k = letterToNumber(connectedTo.GetComponent<TMP_InputField>().text.ToCharArray()[0]);

                bool check = true;

                if (enigma.GetComponent<readInputScript>().plugs[j, k] == 1) check = false;
                else if (j == k) check = false;
                else if (this.GetComponent<TMP_InputField>().text.ToCharArray().Length != 1) check = false;
                else if (connectedTo.GetComponent<TMP_InputField>().text.ToCharArray().Length != 1) check = false;
                else check = true;

                if (check == true)
                {
                    enigma.GetComponent<readInputScript>().plugs[j, k] = 1;
                    enigma.GetComponent<readInputScript>().plugs[k, j] = 1;
                }
                else
                {
                    this.GetComponent<TMP_InputField>().text = " ";
                    connectedTo.GetComponent<TMP_InputField>().text = " ";
                }
            }   
        }    
    }


}
