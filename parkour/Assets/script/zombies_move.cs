using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombies_move : MonoBehaviour
{
    public float speed;
    public GameObject zombies;
    public Animator zombies_ani;//动画控制器
    public int ani;//控制动画播放条件的int值
    bool isjump ;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
        zombies_ani = zombies.GetComponentInChildren<Animator>();
       
    }
    
    public void endjump()
    {
        ani = 2;
        zombies_ani.SetInteger("pass", ani);
    }
    // Update is called once per frame
    void Update()
    {
        //跳跃
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani = 1;
            zombies_ani.SetInteger("pass", ani);
            Invoke("endjump", 1f);
        }
        //向前跑
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //旋转 y轴 AD
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal")*1.5f, 0));
        //加速、减速
        if (Input.GetKey("w"))       
        {
            speed = 6f;           
        }
        if (Input.GetKeyUp("w"))
        {
            speed = 3f;
        }   
          
              

        
    }
}
