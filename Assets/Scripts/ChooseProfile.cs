using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ChooseProfile : MonoBehaviour
{
    public GameObject image;
    public TextMeshProUGUI Text;
   string[] Names = {"ms", "kd", "vs", "rd", "sr", "f", "kw", "sg", "ys", "hs", "ip", "st"};
    public int i;
  
   /* private Image dummyImage;

    private void names()
    {
        dummyImage = image.GetComponent<Image>();
        //string[] Names = { "ms", "kd", "vs", "rd", "sr", "f", "kw", "sg", "ys", "hs", "ip", "st" };
        
    }*/
    public void Onclicked()
    {
       /* string concatenatedString = "";
        foreach (string str in Names)
        {
            concatenatedString += str + "\n";
        }
        Text.text = concatenatedString;*/
       for (int i = 0; i < Names.Length; i++)
        {
            string name = Names[i];
        }
        Text.text = Names[i];
        Debug.Log(Text.text);
        //playerimage.GetComponent<Image>()
        image.GetComponent<Image>().sprite=this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        print(this.gameObject.transform.GetChild(0));
        //Debug.Log(gameObject.name);
    } 
}