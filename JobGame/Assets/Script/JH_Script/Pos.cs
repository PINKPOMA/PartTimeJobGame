using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pos : MonoBehaviour
{
    public GameObject Text_T;
    TextMeshProUGUI rt_T;
    private string money = "0";

    // Start is called before the first frame update
    void Start()
    {
        rt_T = Text_T.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void number9()
    {
        money += "9";
        rt_T.text = money.ToString();
    }

    public void number8()
    {
        money += "8";
        rt_T.text = money.ToString();
    }
    
    public void number7()
    {
        money += "7";
        rt_T.text = money.ToString();
    }

    public void number6()
    {
        money += "6";
        rt_T.text = money.ToString();
    }

    public void number5()
    {
        money += "5";
        rt_T.text = money.ToString();
    }

    public void number4()
    {
        money += "4";
        rt_T.text = money.ToString();
    }

    public void number3()
    {
        money += "3";
        rt_T.text = money.ToString();
    }

    public void number2()
    {
        money += "2";
        rt_T.text = money.ToString();
    }

    public void number1()
    {
        money += "1";
        rt_T.text = money.ToString();
    }

    public void numberDot()
    {
        money += ".";
        rt_T.text = money.ToString();
    }

    public void number00()
    {
        money += "00";
        rt_T.text = money.ToString();
    }

    public void number0()
    {
        money += "0";
        rt_T.text = money.ToString();
    }

    public void numberPlus()
    {
        money += "+";
        rt_T.text = money.ToString();
    }

    public void numberEqual()
    {
        string[] result= money.Split('+');
        
        int sum = 0;
        for (int i = 0; i < result.Length; i++)
        {
            sum += int.Parse(result[i]);
        }
        money = sum.ToString();
        rt_T.text = money.ToString();
        money = "0";
    }
}
