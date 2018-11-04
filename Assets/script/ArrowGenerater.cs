using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerater : MonoBehaviour {
    public GameObject arrowPrefab;
    float span = 0.5f;//フラグ
    float delta = 0;
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;//時間差を加算
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;//
            int px = Random.Range(-6, 7);//出現場所のランダム設定
            go.transform.position = new Vector3(px, 7, 0);//インスタンスにポジションを代入
        }
		
	}
}
