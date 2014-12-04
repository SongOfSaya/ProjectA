using UnityEngine;
using System.Collections;

public class TestTouch : MonoBehaviour
{
    void OnEnable ()
    {
        EasyTouch.On_TouchStart += On_TouchStart;
    }
    void OnDisable ()
    {
        EasyTouch.On_TouchStart -= On_TouchStart;
    }
    void OnDestory ()
    {
        EasyTouch.On_TouchStart -= On_TouchStart;
    }
    public void On_TouchStart (Gesture gesture)
    {
        if (gesture.pickObject == gameObject)
        {
            gameObject.renderer.material.color = Color.red;
            Debug.Log("AAAA" + gesture.position);
        }
    }
}
