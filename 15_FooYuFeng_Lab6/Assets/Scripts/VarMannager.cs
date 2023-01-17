using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VarMannager : MonoBehaviour
{
    public static VarMannager var;

    public float[] conversionRate;

    [Space]

    public InputField amountField;
    public InputField valueField;
    public Text debugText;

    public GameObject checkerGroup;

    [HideInInspector]
    public int checkerID = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (var == null)
        {
            var = this;
            debugText.text = "";
        }
        else
        {
            Destroy(this);
        }
    }
}
