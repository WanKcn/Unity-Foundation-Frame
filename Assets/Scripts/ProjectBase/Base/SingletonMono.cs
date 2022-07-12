using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
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