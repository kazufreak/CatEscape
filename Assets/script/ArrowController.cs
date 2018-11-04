using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {
    GameObject player;
    int Hp;
    int deltaHP;
	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player");
        this.Hp = 360;
        this.deltaHP = 15;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.1f, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;//矢のポジション
        Vector2 p2 = this.player.transform.position;//プレイヤーのポジション
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;//距離の計算
        float r1 = 0.5f;//矢の当たり判定半径
        float r2 = 1.0f;//playerの当たり判定半径

        if(d < r1 + r2)
        {
            //矢が当たったらHPゲージを減らす
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            this.Hp -= this.deltaHP;

            director.GetComponent<GameDirector>().updateHp(this.Hp);

            //距離が半径以下であればオブジェクト削除
            Destroy(gameObject);
        }
		
	}
}
