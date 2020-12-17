using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class xunlu : MonoBehaviour
{
    //public GameObject player;
    public LayerMask barrier;
    //public Transform targetpos;
    private NavMeshAgent nav;

    public Transform[] target;
    int index = 0;
    public float timer = 0;

    
    
    private void Awake()
    {
        //player = GameObject.Find("player");
    }
    void Start()
    {
        
        
        nav = GetComponent<NavMeshAgent>();
        //nav.SetDestination(targetpos.position);//只完成一次寻路到达目标初始的位置
        nav.SetDestination(target[index].position);//可以设置多个目标点
    }

    // Update is called once per frame
    void Update()
    {
        //循环寻路
        if (nav.remainingDistance <= 0.2f)
        {
            timer += Time.deltaTime;
            if (timer>=2)
            {
                timer = 0;
                index++;
                index %= target.Length;
                nav.SetDestination(target[index].position);
            }
        }
        


    }

    


}
