using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearBTNScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void resetButton()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        VarMannager.var.amountField.text = "";
        VarMannager.var.valueField.text = "";
        VarMannager.var.debugText.text = "";
        VarMannager.var.checkerID = 0;
        Toggle temp = VarMannager.var.checkerGroup.transform.GetChild(0).GetComponent<Toggle>();
        temp.isOn = !temp.isOn;
    }
}
