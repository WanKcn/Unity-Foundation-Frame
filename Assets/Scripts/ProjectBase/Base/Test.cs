public class Test
{
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