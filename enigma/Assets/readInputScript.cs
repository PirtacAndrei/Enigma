using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class readInputScript : MonoBehaviour
{
    [SerializeField]
    AudioSource sound;
    //interactibles
    [SerializeField]
    GameObject[] lights;
    [SerializeField]
    Text input;
    [SerializeField]
    Text output;
    [SerializeField]
    GameObject inputText1; //input text for rotor 1
    [SerializeField]
    GameObject inputText2; //input text for rotor 2
    [SerializeField]
    GameObject inputText3; //input text for rotor 3

    //Rotor settings
    [SerializeField]
    string r1 = "PEZUOHXSCVFMTBGLRINQJWAYDK";
    [SerializeField]
    string r2 = "ZOUESYDKFWPCIQXHMVBLGNJRAT";
    [SerializeField]
    string r3 = "EHRVXGAOBQUSIMZFLYNWKTPDJC";
    [SerializeField]
    string r4 = "IMETCGFRAYSQBZXWLHKDVUPOJN"; //reflector

    //rotor vectors we will use
    int[] rotor1;
    int[] rotor2;
    int[] rotor3;
    int[] rotor4;

    //the rotation for each rotor
    int r1Rotation=1;
    int r2Rotation=1;
    int r3Rotation=1;

    //checks if another menu uses the alphabetical input 
    bool plugsOn = true;
    public void changePlugsOn()
    {
        if (plugsOn) plugsOn = false;
        else plugsOn = true;
    }

    //a matrix for the connected plugs
    public int[,] plugs;

    //the output letter should be a global variable because we use it in update and we cand initiate it each frame
    int letterOutput = 0;        //numeric version
    string letterOutputS = "a";  //string version


    //check if there is a plug connected to the letter
    int CheckPlugs(int letter)
    {
        for(int i=0;i<26;i++)
        {
            if (plugs[letter, i] == 1) return i;
        }
        return letter;
        
    }

    //function used to update the rotors after the user changes the value using the input box in UI
    //we dont update the UI with the new version because the user changed it
    public void updateRotors()
    {

        while (inputText3.GetComponent<TMP_InputField>().text != r3Rotation.ToString()) 
        {
            rotateRotors(3);
        }
        while (inputText2.GetComponent<TMP_InputField>().text != r2Rotation.ToString())
        {
            rotateRotors(2);
        }
        while (inputText1.GetComponent<TMP_InputField>().text != r1Rotation.ToString())
        {
            rotateRotors(1);
        }
    }

    //simple conversion from char to int forr a letter
    int letterToNumber(char c)
    {
        return ((int)c % 32)-1;
    }

    //simple conversion from int to string for a letter
    string numberToLetter(int n)
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        return letters[n].ToString();
    }

    //transform the rotor settings to int so we an use it later as int instead of string
    void InitializeRotors()
    {
        rotor1 = new int[26];
        rotor2 = new int[26];
        rotor3 = new int[26];
        rotor4 = new int[26];



        int count = 0;
        foreach(char letter in r1)
        {
            rotor1[count] = letterToNumber(letter);
            count++;
        }
        count = 0;
        foreach (char letter in r2)
        {
            rotor2[count] = letterToNumber(letter);
            count++;
        }
        count = 0;
        foreach (char letter in r3)
        {
            rotor3[count] = letterToNumber(letter);
            count++;
        }
        count = 0;
        foreach (char letter in r4)
        {
            rotor4[count] = letterToNumber(letter);
            count++;
        }

    }

    //function used to rotate the rotors by simply moving the elements of the vectors
    //bool update checks is we want to modify the UI or not
    void rotateRotors(int ignore)
    {
        int aux;
        if (r1Rotation < 26)
        {
            r1Rotation++;
            aux = rotor1[0];
            for(int i=1;i<26;i++)
            {
                rotor1[i - 1] = rotor1[i];
            }
            rotor1[25] = aux;
        }
        else
        {
            r1Rotation = 1;
            aux = rotor1[0];
            for (int i = 1; i < 26; i++)
            {
                rotor1[i - 1] = rotor1[i];
            }
            rotor1[25] = aux;

            //----------R2-----------
            if (r2Rotation < 26)
            {
                r2Rotation++;
                aux = rotor2[0];
                for (int i = 1; i < 26; i++)
                {
                    rotor2[i - 1] = rotor2[i];
                }
                rotor2[25] = aux;
            }
            else
            {
                r2Rotation = 1;
                aux = rotor2[0];
                for (int i = 1; i < 26; i++)
                {
                    rotor2[i - 1] = rotor2[i];
                }
                rotor2[25] = aux;

                //--------R3---------
                if (r3Rotation < 26)
                {
                    r3Rotation++;
                    aux = rotor3[0];
                    for (int i = 1; i < 26; i++)
                    {
                        rotor3[i - 1] = rotor3[i];
                    }
                    rotor3[25] = aux;
                }
                else
                {
                    r3Rotation = 1;
                    aux = rotor3[0];
                    for (int i = 1; i < 26; i++)
                    {
                        rotor3[i - 1] = rotor3[i];
                    }
                    rotor3[25] = aux;
                }
            }
        }

        if (ignore == 1)
        {
            inputText2.GetComponent<TMP_InputField>().text = r2Rotation.ToString();
            inputText3.GetComponent<TMP_InputField>().text = r3Rotation.ToString();
        }
        else if(ignore==2)
        {
            inputText3.GetComponent<TMP_InputField>().text = r3Rotation.ToString();
        }
        else if(ignore==3){}
        else
        {
            inputText1.GetComponent<TMP_InputField>().text = r1Rotation.ToString();
            inputText2.GetComponent<TMP_InputField>().text = r2Rotation.ToString();
            inputText3.GetComponent<TMP_InputField>().text = r3Rotation.ToString();
        }
        
        
        
    }

    //function that goes through the rotors to change the letter
    int UseRotors(int letter)
    {
        letter = rotor1[letter];
        letter = rotor2[letter];
        letter = rotor3[letter];
        letter = rotor4[letter];


        int n = 0;
        foreach (int l in rotor3)
        {
            if (l == letter)
            {
                letter = n;
                break;
            }
            n++;
        }

        n = 0;
        foreach (int l in rotor2)
        {
            if (l == letter)
            {
                letter = n;
                break;
            }
            n++;
        }

        n = 0;
        foreach (int l in rotor1)
        {
            if (l == letter)
            { 
                letter = n;
                break;
            }
            n++;
        }



        rotateRotors(0);
        return letter;
    }

    //Start function is called when the user starts the program and here we initialize variables
    void Start()
    {
        plugs = new int[26,26];
        inputText1.GetComponent<TMP_InputField>().text = "1";
        inputText2.GetComponent<TMP_InputField>().text = "1";
        inputText3.GetComponent<TMP_InputField>().text = "1";
        input.text = "Here is the input text";
        output.text = "Here is the output text";
        InitializeRotors();
    }

    // Update is called once per frame
    void Update()
    {   
        char[] letters=new char[] {'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
        
        if(!plugsOn)
        {

            if (Input.GetKeyDown("space") == true)
            {
                sound.Play();

                if (input.text == "Here is the input text") input.text = " ";
                else input.text += " ";

                if (output.text == "Here is the output text") output.text = " ";
                else output.text += " ";
            }
            
            foreach (char letter in letters)
            {
                string letterS = letter.ToString();
                int letterN = letterToNumber(letter);


                if (Input.GetKeyDown(letterS) == true)
                {
                    sound.Play();
                    
                    letterN = CheckPlugs(letterN);

                    letterOutput = UseRotors(letterN);

                    letterOutput = CheckPlugs(letterOutput);
                    
                    lights[letterOutput].SetActive(true);
                }
                if (Input.GetKeyUp(letterS) == true)
                {

                    letterOutputS = numberToLetter(letterOutput);
                    lights[letterOutput].SetActive(false);

                    if (input.text == "Here is the input text") input.text = letterS;
                    else input.text += letterS;

                    if (output.text == "Here is the output text") output.text = letterOutputS;
                    else output.text += letterOutputS;

                }
            }
        }
        

    }
}
