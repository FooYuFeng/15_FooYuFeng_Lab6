using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckerScript : MonoBehaviour
{
    [HideInInspector]
    public bool runScriptChecker = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void onCheckOn()
    {
        if (runScriptChecker == false)
        {
            return;
        }

        for (int loop = 0; loop < VarMannager.var.checkerGroup.transform.childCount; loop++)
        {
            VarMannager.var.checkerGroup.transform.GetChild(loop).GetComponent<Toggle>().enabled = false;
            VarMannager.var.checkerGroup.transform.GetChild(loop).GetComponent<CheckerScript>().runScriptChecker = false;
            VarMannager.var.checkerGroup.transform.GetChild(loop).GetComponent<Toggle>().isOn = false;

            if (VarMannager.var.checkerGroup.transform.GetChild(loop).gameObject == gameObject)
            {
                GetComponent<Toggle>().isOn = true;
                VarMannager.var.checkerID = loop;
            }

            VarMannager.var.checkerGroup.transform.GetChild(loop).GetComponent<Toggle>().enabled = true;
            VarMannager.var.checkerGroup.transform.GetChild(loop).GetComponent<CheckerScript>().runScriptChecker = true;
        }
    }
}
