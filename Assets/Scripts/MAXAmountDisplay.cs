using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MAXAmountDisplay : MonoBehaviour
{
    public TMP_InputField InputFieldTMP;
    public TextMeshProUGUI MAXAmountDisplayTMP;
    public void MAXButtonPress()
    {
       // MAXAmountDisplayTMP.text = InputFieldTMP.text;
       // InputFieldTMP.text = MAXAmountDisplayTMP.text;
       string inputText=InputFieldTMP.text;
        MAXAmountDisplayTMP.text = inputText;
        print(inputText);
    }
}
