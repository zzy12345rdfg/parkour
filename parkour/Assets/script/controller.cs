using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class controller : MonoBehaviour
{
    
    public GameObject beign_image;
    public GameObject next3;
    public GameObject ranking;
    public Text game1_text;
    public Text game2_text;
    public Text game3_text;

    // Start is called before the first frame update    
    void Start()
    {        
        Time.timeScale = 0;
    }
    public void replay()//重玩
    {
        SceneManager.LoadScene("zombies_game1");
    }
    public void Quit()//退出
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void restart1()
    {
        SceneManager.LoadScene("zombies_game1");
    }
    public void restart2()
    {
        SceneManager.LoadScene("zombies_game2");
    }
    public void begin()//开始游戏界面
    {
        beign_image.SetActive(false);        
        Time.timeScale = 1;
    }
    public void next_2()//进入第二关
    {
        final_score.game1_score = grade.score;
        PlayerPrefs.SetFloat("game1_score", final_score.game1_score);
        SceneManager.LoadScene("zombies_game2");
    }
    public void next_3()//进入第三关
    {
        final_score.game2_score = grade.score;
        PlayerPrefs.SetFloat("game2_score", final_score.game2_score);
        SceneManager.LoadScene("zombies_game3");
    }
    public void check()//查看排行榜
    {
        next3.SetActive(false);
        final_score.game3_score = grade.score;
        PlayerPrefs.SetFloat("game3_score", final_score.game3_score);
        ranking.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {      
        
        
    }
}
