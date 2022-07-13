using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 继承自动创建的单例模式基类，不需要手动拖动或者api加载，使用直接GetInstance
public class SingletonAutoMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T GetInstance()
    {
        if (instance == null)
        {
            GameObject obj = new GameObject();
            // 设置对象名字为脚本名
            obj.name = typeof(T).ToString();
            // 让这个单例模式对象过场景不移除
            DontDestroyOnLoad(obj);
            instance = obj.AddComponent<T>();
        }

        return instance;
    }
}