using UnityEngine;
using UnityEngine.UI;

public class CheckBoxPanelButton : MonoBehaviour
{
    public Toggle option1Toggle;
    public Toggle option2Toggle;
    public Toggle option3Toggle;
    public Toggle option4Toggle;

    public void PrintSelectedOptions()
    {
        string selectedOptions = "";

        if (option1Toggle.isOn)
        {
            selectedOptions += "Pink ";
        }

        if (option2Toggle.isOn)
        {
            selectedOptions += "Orange ";
        }
        if (option3Toggle.isOn)
        {
            selectedOptions += "Blue ";
        }
        if (option4Toggle.isOn)
        {
            selectedOptions += "Yellow ";
        }

        if (!string.IsNullOrEmpty(selectedOptions))
        {
            Debug.Log("Selected options: " + selectedOptions);
        }
        else
        {
            Debug.Log("No option selected.");
        }
    }
}