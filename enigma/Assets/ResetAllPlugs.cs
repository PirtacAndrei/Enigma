using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResetAllPlugs : MonoBehaviour
{
    [SerializeField]
    GameObject[] plugs;
    [SerializeField]
    GameObject enigma = null;
    public void ResetPlugs()
    {
        enigma.GetComponent<readInputScript>().plugs = new int[26, 26];
        foreach (GameObject plug in plugs)
        {
            plug.GetComponent<TMP_InputField>().text = " ";
        }
    }
}
