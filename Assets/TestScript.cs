using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{ 
    private int hp = 100;          
    private int power = 25;
    private int mp = 35;

    public void Magic() {
        if (mp >= 5){
            mp -= 5;
            Debug.Log("魔法攻撃をした。のこりMPは" + mp + "。");
        }else
            Debug.Log("mpが足りないので使えない…");
    }


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        
        this.hp -= damage;
    }

}


public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("Hello,World!");


        Boss lastboss = new Boss();
        int i;
        int num = 1;
        int val = (num == 1) ? -100 : 100;

        int []array = {800, 50, 20, 1, 3213 };

        for ( i = 0;i<5;i++) {
            Debug.Log(array[i]);
        }

        for (i = 4;i <= 0;i--){
            Debug.Log(array[i]);
        }

        for (i = 0; i < 11; i++){
            lastboss.Magic();
        }
        

        Debug.Log(val);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
