using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyTabs : MonoBehaviour
{

    public GameObject tabbutton1;
    public GameObject tabbutton2;

    public GameObject tabcontent1;
   // public GameObject tabcontent2;
    public TextMeshProUGUI text;
   // private string TemText;
   // public textmeshprogui
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // TemText = Input.inputString;
        // Debug.Log(TemText); 
    }

    //  public void HideAllTabs()
    //{
    //  tabcontent1.SetActive(false);
    // tabcontent2.SetActive(false);

    //}

    public void ShowTab1()
    {
        //HideAllTabs();
        //Debug.Log("Log" + Input.inputString);
        tabcontent1.SetActive(true);
        text.GetComponent<TextMeshProUGUI>().text = "Hi Ganesh";
        
    }

    public void ShowTab2()
    {
       // HideAllTabs();
       // tabcontent2.SetActive(true);
        text.GetComponent<TextMeshProUGUI>().text = "tell me your number";

    }
}
   