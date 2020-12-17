using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombies_food : MonoBehaviour
{
    float i = 5;
    float zombies_score=0;
    public Text grade_text;//游戏界面
    public Text grade_text1;//next界面
    public GameObject beign_image;//开始游戏面板
    public GameObject next_image;//下一关面板
    public GameObject next_3;//进入下一关
    public GameObject restart;//重新开始此关
    // Start is called before the first frame update
    void Start()
    {
        //grade mygrade = grade.getInstance();
        beign_image.gameObject.SetActive(true);
        next_image.gameObject.SetActive(false);
        next_3.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            GameObject.Find("destory_audio").GetComponent<AudioSource>().Play();
            Destroy(other.gameObject,0.1f);
            zombies_score += i;
        }
        if (other.tag == "coin_10")
        {
            GameObject.Find("destory_audio").GetComponent<AudioSource>().Play();
            Destroy(other.gameObject,0.1f);
            zombies_score += 2*i;
        }
        if (other.tag == "harm")
        {
            GameObject.Find("attack_audio").GetComponent<AudioSource>().Play();            
            zombies_score -= i * 2;
        }
        
        if (other.tag == "destory")//当主角通过就销毁之前生成的金币
        {
            Destroy(other.transform.parent.gameObject);
        }
        if (other.tag == "end")
        {
            this.gameObject.GetComponent<zombies_move>().enabled = false;
            Time.timeScale = 0;
            beign_image.gameObject.SetActive(false);
            next_image.gameObject.SetActive(true);
            if(zombies_score >= 280)
            {
                next_3.gameObject.SetActive(true);
            }
            else
            {
                restart.gameObject.SetActive(true);
            }           

        }
    }
    // Update is called once per frame
    void Update()
    {

        grade_text.text = grade.score.ToString();
        grade_text1.text = zombies_score.ToString();
        grade.score = zombies_score;
    }
   

    

   
}
