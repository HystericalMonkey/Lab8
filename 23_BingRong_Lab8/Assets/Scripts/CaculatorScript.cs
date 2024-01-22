using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaculatorScript : MonoBehaviour
{
    [SerializeField] private InputField InputAmt;
    [SerializeField] private InputField OutputAmt;
    [SerializeField] private Toggle USDollars;
    [SerializeField] private Toggle JapaneseYen;
    public Text DebuggingText;
    private float USConversion = 0.74f;
    private float JpyConversion = 82.78f;
    private float inputAmount = 0f;

    public void Convert()
    {
        //try
        //{
            inputAmount = float.Parse(InputAmt.text);
            if (USDollars.isOn == true && JapaneseYen.isOn == false)
            {
                OutputAmt.text = "$" + (inputAmount * USConversion);
            }
            else if (USDollars.isOn == false && JapaneseYen.isOn == true)
            {
                OutputAmt.text = "$" + (inputAmount * JpyConversion);
            }
            else if (USDollars.isOn == true && JapaneseYen.isOn == true)
            {
                DebuggingText.text = "Please Select Only one Conversion Currency";
            }
        //}
        //catch (System.FormatException)
        //{
        //    DebuggingText.text = "Pleave Enter Valid Amount.";
        //}

        
    }
    public void Clear()
    {
        InputAmt.text = "";
        OutputAmt.text = "";
        USDollars.isOn = false;
        JapaneseYen.isOn = false;
    }
}
