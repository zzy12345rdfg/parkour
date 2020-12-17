﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_Instantiate1 : MonoBehaviour
{
    //创建一个数组,在界面那里把预制物体拖进FishPrefab里
    public GameObject FoodPrefab;
    public Transform food_transform;
    Quaternion randomRotation;
    GameObject go;
    private void Start()
    {
        if (food_transform.gameObject.tag == "turn_forward")
        {
            for (int i = 0; i < 5; i++)
            {
                // 创建一个四元数 Quaternion，取一个随机的旋转角度
                // Quaternion.Euler 欧拉角
                // 返回一个旋转角度，绕y轴旋转y度，绕x轴旋转x度，绕z轴旋转z度。
                randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
                //Instantiate（，，）；第一个参数写随机Random.Range(0, 数组的长度也就是预制物体的个数)]，第二个参数写生成的位置，第三个参数写旋转（也可以不旋转Quaternion.identity）
                // 参数一：是预设 参数二：实例化预设的坐标  参数三：实例化预设的旋转角度            
                go = Instantiate(FoodPrefab, new Vector3(food_transform.position.x + i * 1.5f, food_transform.position.y, food_transform.position.z), randomRotation);
                go.transform.SetParent(food_transform);
            }
        }
        else if (food_transform.gameObject.tag == "turn_right")
        {
            for (int i = 0; i < 4; i++)
            {
                // 创建一个四元数 Quaternion，取一个随机的旋转角度
                // Quaternion.Euler 欧拉角
                // 返回一个旋转角度，绕y轴旋转y度，绕x轴旋转x度，绕z轴旋转z度。
                randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
                //Instantiate（，，）；第一个参数写随机Random.Range(0, 数组的长度也就是预制物体的个数)]，第二个参数写生成的位置，第三个参数写旋转（也可以不旋转Quaternion.identity）
                // 参数一：是预设 参数二：实例化预设的坐标  参数三：实例化预设的旋转角度            
                go = Instantiate(FoodPrefab, new Vector3(food_transform.position.x , food_transform.position.y, food_transform.position.z + i * 1.5f), randomRotation);
                go.transform.SetParent(food_transform);
            }
        }
        else if (food_transform.gameObject.tag == "turn_down")
        {
            for (int i = 0; i < 5; i++)
            {
                // 创建一个四元数 Quaternion，取一个随机的旋转角度
                // Quaternion.Euler 欧拉角
                // 返回一个旋转角度，绕y轴旋转y度，绕x轴旋转x度，绕z轴旋转z度。
                randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
                //Instantiate（，，）；第一个参数写随机Random.Range(0, 数组的长度也就是预制物体的个数)]，第二个参数写生成的位置，第三个参数写旋转（也可以不旋转Quaternion.identity）
                // 参数一：是预设 参数二：实例化预设的坐标  参数三：实例化预设的旋转角度            
                go = Instantiate(FoodPrefab, new Vector3(food_transform.position.x + i * 2f, food_transform.position.y, food_transform.position.z), randomRotation);
                go.transform.SetParent(food_transform);
            }
        }
        else if (food_transform.gameObject.tag == "turn_left")
        {
            for (int i = 0; i < 6; i++)
            {
                // 创建一个四元数 Quaternion，取一个随机的旋转角度
                // Quaternion.Euler 欧拉角
                // 返回一个旋转角度，绕y轴旋转y度，绕x轴旋转x度，绕z轴旋转z度。
                randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
                //Instantiate（，，）；第一个参数写随机Random.Range(0, 数组的长度也就是预制物体的个数)]，第二个参数写生成的位置，第三个参数写旋转（也可以不旋转Quaternion.identity）
                // 参数一：是预设 参数二：实例化预设的坐标  参数三：实例化预设的旋转角度            
                go = Instantiate(FoodPrefab, new Vector3(food_transform.position.x, food_transform.position.y, food_transform.position.z + i * 2f), randomRotation);
                go.transform.SetParent(food_transform);
            }
        }
        
        
    }
}
