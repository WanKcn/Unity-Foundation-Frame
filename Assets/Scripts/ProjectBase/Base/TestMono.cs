using System;
using UnityEngine;

public class TestMono : SingletonMono<TestMono>
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        Debug.Log(GetInstance().name);
    }
}