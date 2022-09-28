using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] Text txt_countertext;
    int counter = 0;
    public void IncreaseCounter()
    {
        counter++;
        txt_countertext.text = counter.ToString();
    }
}
