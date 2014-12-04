using UnityEngine;
using System.Collections;

public interface GameType
{
    //调整球桌大小
    GameObject ResizeTable(GameObject table);
    //调整球的大小
    GameObject ResizeBall(GameObject ball);
    //计分规则
    
}
