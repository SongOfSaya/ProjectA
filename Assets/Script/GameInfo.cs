using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour
{
    private static GameInfo _instance;
    public GameState State
    {
        get;
        set;
    }
    public static GameInfo GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameInfo();
        }
        return _instance;
    }
    void Awayk ()
    {
        _instance = this;
    }
	void Start ()
	{
        State = GameState.Brower;
	}
}
