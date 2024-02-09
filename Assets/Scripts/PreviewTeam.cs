using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour
{
    public List<GameObject> players;
    public Image captainButton;
    public Image viceCaptainButton;

    void Start()
    {
        SelectCaptains();
    }

    void SelectCaptains()
    {
        Shuffle(players);

       
        players[0].transform.Find("CImage").gameObject.SetActive(true);
        players[1].transform.Find("VCImage").gameObject.SetActive(true);
    }

    void Shuffle(List<GameObject> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            GameObject value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}

