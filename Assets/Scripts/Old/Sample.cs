using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// SampleクラスでEnemyクラスの関数を実行する
public class Sample : MonoBehaviour
{

    public Enemy enemy; // enemyの窓口

    int hp;

    void Attack()
    {
        Debug.Log("攻撃");
    }

    void Heal()
    {
        Debug.Log("回復");
    }

    void Start()
    {
        //Attack();
        //Heal();
        //Debug.Log(hp);
        enemy.Attack();
    }

}
