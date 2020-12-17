using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grade 
{
    //创建 Singleton的一个对象
    private static grade instance = new grade();
    public static float score;
    //让构造函数为 private，这样该类就不会被实例化
    private grade() { }

    //获取唯一可用的对象
    public static grade getInstance()
    {
        return instance;
    }
    
    
}
