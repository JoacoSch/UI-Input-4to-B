using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sumayresultado : MonoBehaviour
{
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TextMeshProUGUI resultado;
    int num1;
    int num2;

    public void SumarMostrar()
    {
        num1 = int.Parse(input1.text);
        num2 = int.Parse(input2.text);
        resultado.text = (num1 + num2).ToString();
        Debug.Log("OK");
    }
    // Start is called before the first frame update
    void Start()
    {
        resultado.text = "";

    }
}
