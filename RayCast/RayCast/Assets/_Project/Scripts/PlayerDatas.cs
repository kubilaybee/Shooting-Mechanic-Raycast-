using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDatas : MonoBehaviour
{
    public Enemy playerDatas;

    public int damage;
    public int range;

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = playerDatas.enemyColor;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            shoot();
        }

        if (Input.GetKey("a"))
        {
            Vector3 nextPos = this.gameObject.transform.position;
            nextPos.x -= 1;
            this.gameObject.transform.position = Vector3.Lerp(transform.position, nextPos, Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            Vector3 nextPos = this.gameObject.transform.position;
            nextPos.x += 1;
            this.gameObject.transform.position = Vector3.Lerp(transform.position, nextPos, Time.deltaTime);
        }

        Debug.DrawRay(transform.position, transform.forward * range, Color.black);
    }

    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward,out hit,range))
        {

            if (hit.transform.gameObject.GetComponent<EnemyDatas>())
            {
                hit.transform.gameObject.GetComponent<EnemyDatas>().TakeDamage(damage);
            }
        }
    }
}
