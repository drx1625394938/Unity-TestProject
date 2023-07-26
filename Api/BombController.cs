using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BombController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //两秒钟后调用爆炸方法
        Invoke("Bang", 2);
    }
    void Bang() 
    {
        //将所有enemy放入对象数组中
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        //遍历enemy
        foreach (GameObject enemy in enemys) 
        {
            //如果enemy与炸弹之间的距离小于3
            if (Vector3.Distance(transform.position, enemy.transform.position) < 3) 
            {
                //摧毁enemy对象
                Destroy(enemy);
            }
        }
        //销毁炸弹
        Destroy(gameObject);
    }
}
