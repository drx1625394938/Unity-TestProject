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
        //��һ����ά����������
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir != Vector3.zero)
        {
            //���dir��Ϊ0����
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
       //������Χ���ˣ��������˵ľ���С��2���������
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
