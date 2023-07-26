using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //获取玩家对象
        GameObject Player = GameObject.FindWithTag("Player");
        if (Vector3.Distance(transform.position, Player.transform.position) < 3) //当敌人与玩家距离小于3
        {
           //获取玩家相对敌人的方向
            Vector3 dir = Player.transform.position - transform.position;
            //敌人转向
            transform.rotation = Quaternion.LookRotation(dir);
            //敌人往玩家方向靠近
            transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        }
    }
}
