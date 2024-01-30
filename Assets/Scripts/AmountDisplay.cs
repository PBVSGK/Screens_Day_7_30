using UnityEngine;
using TMPro;

public class AcountDisplay : MonoBehaviour
{
    public TMP_InputField InputFieldTMP;
    public TextMeshProUGUI AmountTextTMP;
    public void AllButtonPress()
    {
        InputFieldTMP.text = AmountTextTMP.text;
        string[] d = InputFieldTMP.text.Split(" ");
        for (int i = 1; i < d.Length; i++)
        {
            print(d[0]);
            InputFieldTMP.text = d[0];
        }
    }
}
       
