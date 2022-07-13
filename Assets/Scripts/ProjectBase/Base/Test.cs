using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        TestAutoMono.GetInstance().Test();
    }

    void Main()
    {
        GameManager.GetInstance();
        ObjectMgr.GetInstance();
    }
}

public class GameManager : BaseManager<GameManager>
{
}

public class ObjectMgr : BaseManager<ObjectMgr>
{
}