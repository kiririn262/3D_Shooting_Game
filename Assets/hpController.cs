using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpController : MonoBehaviour
{
    private Image bar_hp;

    void Start()
    {
       bar_hp = this.gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bar_hp.fillAmount <= 0.2){
            bar_hp.color = Color.red;
        }
        else if(bar_hp.fillAmount <= 0.5){
            bar_hp.color = Color.yellow;
        }
        else{
            bar_hp.color = Color.green;
        }
    }
}
