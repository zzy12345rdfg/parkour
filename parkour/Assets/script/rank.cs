using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rank : MonoBehaviour
{
    public Text game_text1;//关卡
    public Text game_text2;
    public Text game_text3;
    public Text score1;//分数
    public Text score2;
    public Text score3;
    float[] array;   
    // Start is called before the first frame update
    void Start()
    {

        float game1_score = PlayerPrefs.GetFloat("game1_score", final_score.game1_score);        
        float game2_score = PlayerPrefs.GetFloat("game2_score", final_score.game2_score);        
        float game3_score = PlayerPrefs.GetFloat("game3_score", final_score.game3_score);       

        array = new float[]{ game1_score, game2_score, game3_score };
        float[] original = { game1_score, game2_score, game3_score };
       
        //希尔排序
        for (int i = 1; i < array.Length; i++)
        {
            float temp = array[i];
            for (int j = i - 1; j >= 0; j--)
            {
                if (array[j] > temp)
                {
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
                else
                    break;
            }
        }
        foreach (int i in array)
        {
            Debug.Log(i + "");
        }
        bool isFind = false;
        //查找最大值
        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] == array[2])
            {
                game_text1.text = "第" + (i + 1) + "关";                
                Debug.Log(game_text1.text);
                score1.text = array[2].ToString();
                Debug.Log("10:遍历查找：这个随机数：" + array[2] + " 在数组中的位置是： " + i + "位");
                isFind = true;
                break;
            }
            
        }
        //查找第二位
        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] == array[1])
            {
                game_text2.text = "第" + (i + 1)+"关"; 
                score2.text = array[1].ToString();
                Debug.Log("10:遍历查找：这个随机数：" + array[1] + " 在数组中的位置是： " + i + "位");
                isFind = true;
                break;
            }

        }
        //查找最小值
        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] == array[0])
            {
                game_text3.text = "第" + (i + 1) + "关";
                score3.text = array[0].ToString();
                Debug.Log("10:遍历查找：这个随机数：" + array[0] + " 在数组中的位置是： " + i + "位");
                isFind = true;
                break;
            }

        }      
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
