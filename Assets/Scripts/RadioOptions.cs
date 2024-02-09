using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class RadioButtonScript : MonoBehaviour
{
    ToggleGroup toggleGroup;


    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();

        //Debug.Log(toggle.name + "__" + toggle.GetComponentInChildren<Text>().text);
        print(toggle.GetComponentInChildren<Text>().text); 
    }
}