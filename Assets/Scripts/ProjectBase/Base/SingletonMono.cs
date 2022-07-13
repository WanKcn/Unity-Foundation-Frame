using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    // 多次继承，通过单例访问，instance指向最后一次创建的脚本对象
    // 继承了MonoBehaviour的单例对象，需要自己保证唯一性
    private static T instance;

    public static T GetInstance()
    {
        // 继承Mono 不能直接new 只能通过拖拽或者加脚本api U3D内部帮助实例化
        return instance;
    }

    protected virtual void Awake()
    {
        instance = this as T;
    }
}