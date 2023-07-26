using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public GameObject Bomb;
    float CD = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        Dead();
        CD += Time.deltaTime;
        if (CD > 2)
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                setBomb();
                CD = 0;
            }
        }
    }
    void move() 
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //用一个三维向量来接受
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir != Vector3.zero)
        {
            //如果dir不为0，则将
            transform.rotation = Quaternion.LookRotation(dir);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }

    }
    void setBomb() 
    {
                Instantiate(Bomb, this.transform.position, Quaternion.identity);
    }

    void Dead()
    {
       //遍历周围敌人，如果与敌人的距离小于2，玩家死亡
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemys)
        {
            if (Vector3.Distance(transform.position, enemy.transform.position) < 2) 
            {
                Debug.Log("You are Died");
                Time.timeScale = 0;
            }
        }   
    }
}
