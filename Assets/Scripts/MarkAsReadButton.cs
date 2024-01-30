using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkAsReadButton : MonoBehaviour
{
    public List<GameObject> and = new List<GameObject>();
    public void OnClick()
    {
       for (int i = 0; i < and.Count; i++)
        {
            Destroy(and[i]);
        }
           
    }
} 
