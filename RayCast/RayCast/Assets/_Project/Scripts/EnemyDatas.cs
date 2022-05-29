using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDatas : MonoBehaviour
{
    public Enemy enemyType;

    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = enemyType.enemyColor;
    }

    public void TakeDamage(int dmg)
    {
        Debug.Log("Enemy Health: " + enemyType.vitality);
        enemyType.vitality -= dmg;
        if (enemyType.vitality <= 0)
        {
            die();
        }
    }

    void die()
    {
        Destroy(gameObject, 2f);
    }
}
