using UnityEngine;

public class TestAutoMono : SingletonAutoMono<TestAutoMono>
{
    public void Test()
    {
        Debug.Log(GetInstance().name);
    }
}