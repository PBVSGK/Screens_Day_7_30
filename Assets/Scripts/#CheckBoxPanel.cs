using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class CheckBoxPanel : MonoBehaviour
{
    Toggle toggle;

    void Start()
    {
        toggle = GetComponentInChildren<UnityEngine.UI.Toggle>();
        if (toggle != null)
            toggle.onValueChanged.AddListener(OnValueChanged);
        else
            Debug.LogError("No togggle component in children", this);
    }
    public void OnValueChanged(bool isOn)
    {
        toggle.onValueChanged.RemoveListener(OnValueChanged);
        toggle.interactable = true;
        //Debug.Log(toggle.transform.GetChild(1).gameObject.GetComponent<Text>().text);

    }

}