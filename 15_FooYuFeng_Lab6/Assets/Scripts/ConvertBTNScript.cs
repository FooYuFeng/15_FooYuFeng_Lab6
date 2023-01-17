using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertBTNScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void buttonPushed()
    {
        try
        {
            VarMannager.var.valueField.text = "" + float.Parse(VarMannager.var.amountField.text) * VarMannager.var.conversionRate[VarMannager.var.checkerID];
            VarMannager.var.debugText.text = "";
        }
        catch
        {
            VarMannager.var.debugText.text = "Please enter a valid amount";
        }
    }
}
