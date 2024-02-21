using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ChooseProfile : MonoBehaviour
{
    public GameObject image;

    public void Onclicked()
    {
        //playerimage.GetComponent<Image>()
        image.GetComponent<Image>().sprite=this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        //Debug.Log(gameObject.name);
    }
    private void Start()
    {
        string = string { "ms", "kd", "vs", "rd", "sr", "f", "kw", "sg", "ys", "hs", "ip", "st"};
         
    }
}