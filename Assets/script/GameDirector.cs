using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {
    GameObject hpGauge;
    GameObject hptext;

	// Use this for initialization
	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
        this.hptext = GameObject.Find("Hptext");
		
	}
	
	// Update is called once per frame
	public void DecreaseHp () {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
		
	}
    public void updateHp(float deltaHP)
    {
        this.hptext.GetComponent<Text>().text = (deltaHP).ToString("F2");
    }
}
