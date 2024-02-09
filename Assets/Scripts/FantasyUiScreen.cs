using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class FantasyUiScreen : MonoBehaviour
{
    // public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Button CButton;
    public Color newColor;
    // Start is called before the first frame update
    void Start()
    {
       // CButton.GetComponent<Image>().sprite = newSprite;
    }
    public void ChangeSprite(Sprite newSprite)
    {
        Debug.Log("sprite newSprite");
        CButton.GetComponent<Image>().sprite = newSprite;
        CButton.GetComponentInChildren<TextMeshProUGUI>().color = newColor;
    }

    // Update is called once per frame
    public Sprite jump_Image;

    public void Jump()
    {
        CButton.GetComponent<Image>().sprite = newSprite;
    }   
}
