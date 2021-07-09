using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int hp;
    public int power;
    public int mp;


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }


    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}



public class Test : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {


        Boss midboss = new Boss();

        midboss.hp = 50;
        midboss.power = 10;
        midboss.mp = 53;

        midboss.Attack();
        midboss.Defence(4);

        for (int i = 1; i < 12; i++)
        {
            midboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {



    }
}
