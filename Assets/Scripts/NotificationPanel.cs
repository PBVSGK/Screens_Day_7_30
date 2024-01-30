using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationPanel : MonoBehaviour
{
    public void CrossButton()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
