using UnityEngine;
using System.Collections;

public class Snooker : GameType
{
    private Snooker instance;
    private const int tableWidth = 1778;
    private const int tableLongth = 3569;
    private const int ballRadiu = 53;
    private const int ballArmLong = 920;
    //私有构造函数
    private Snooker ()
    {
    }
    //获得单例
    public Snooker GetInstance ()
    {
        if (instance == null)
        {
            instance = new Snooker();
        }
        return instance;
    }

    public GameObject ResizeTable (GameObject table)
    {
        throw new System.NotImplementedException();
    }

    public GameObject ResizeBall (GameObject ball)
    {
        throw new System.NotImplementedException();
    }
}
