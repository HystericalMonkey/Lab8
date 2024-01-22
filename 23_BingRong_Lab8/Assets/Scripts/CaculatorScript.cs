using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaculatorScript : MonoBehaviour
{
    [SerializeField] private InputField InputAmt;
    [SerializeField] private InputField OutputAmt;
    [SerializeField] private ToggleGroup toggleGroup;
    [SerializeField] private Toggle USDollars;
    [SerializeField] private Toggle JapaneseYen;
    [SerializeField] private Toggle MalaysianRM;
    [SerializeField] private Toggle EuropeanEuro;
    [SerializeField] private Toggle KoreanWon;
    [SerializeField] private Toggle TaiwanDollar;
    public Text DebuggingText;
    private float USConversion = 0.74f;
    private float JpyConversion = 82.78f;
    private float RMConversion = 3.08f;
    private float EuroConversion = 0.63f;
    private float WonConversion = 881.54f;
    private float TaiwanConversion = 20.73f;
    private float inputAmount = 0f;

    public void Convert() 
    {
        try
        {
            inputAmount = float.Parse(InputAmt.text);
            if (USDollars.isOn)
            {
                OutputAmt.text = "$" + (inputAmount * USConversion);
            }
            if (JapaneseYen.isOn)
            {
                OutputAmt.text = "¥" + (inputAmount * JpyConversion);
            }
            if (MalaysianRM.isOn)
            {
                OutputAmt.text = (inputAmount * RMConversion) + "RM";
            }
            if (EuropeanEuro.isOn)
            {
                OutputAmt.text = "€" + (inputAmount * EuroConversion);
            }
            if (KoreanWon.isOn)
            {
                OutputAmt.text = "₩" + (inputAmount * WonConversion);
            }
            if (TaiwanDollar.isOn)
            {
                OutputAmt.text = "元" + (inputAmount * TaiwanConversion);
            }
        }
        catch (System.FormatException)
        {
            OutputAmt.text = "";
            DebuggingText.text = "Pleave Enter Valid Amount.";
        }
    }
    public void Clear()
    {
        InputAmt.text = "";
        OutputAmt.text = "";
        USDollars.isOn = false;
        JapaneseYen.isOn = false;
    }
}
