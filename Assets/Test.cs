using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; //マジックポイント

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	//魔法攻撃用の関数
	public void Magic(int usemp){
		// 残りmpを減らす


		if (mp >= usemp) {
			this.mp -= usemp;
				//消費MPより残MPが大きければ、文字列を表示
				Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");

		} else {
				//消費MPより残MPが地位さければ、文字列を表示
				Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);

		//処理を11回実行する
		for (int i = 0; i < 11; i++) {
			
			//魔法攻撃用の関数を呼び出す
			lastboss.Magic (5);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


//メモ
//Start関数でMagic関数呼び出し
//引数5（消費mpを渡す）
//Magic関数内で消費mpを全体mpから差し引いた値を残りの値とする
//for文でmagic関数を10回使わせる。その際に、消費mpが引数を下回ると表示内容の変更
//この表示内容をif文にて支持　mpより　上 or 下かの判定