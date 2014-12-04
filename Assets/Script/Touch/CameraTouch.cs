using UnityEngine;
using System.Collections;

public class CameraTouch : MonoBehaviour
{
    [SerializeField]
    private CameraPathAnimator CPA;
    public GameObject Look_Obj;
    private Vector3 deltaPosition;
    void OnEnable ()
    {
        EasyTouch.On_Drag += On_Drag;
        EasyTouch.On_DragStart += On_DragStart;
        EasyTouch.On_DragEnd += On_DragEnd;
        EasyTouch.On_SwipeStart += On_SwipeStart;
        EasyTouch.On_Swipe += On_Swipe;
        EasyTouch.On_SwipeEnd += On_SwipeEnd;	
    }
    void OnDisable ()
    {
        UnsubscribeEvent();
    }

    void OnDestroy ()
    {
        UnsubscribeEvent();
    }

    void UnsubscribeEvent ()
    {
        EasyTouch.On_Drag -= On_Drag;
        EasyTouch.On_DragStart -= On_DragStart;
        EasyTouch.On_DragEnd -= On_DragEnd;
        EasyTouch.On_SwipeStart -= On_SwipeStart;
        EasyTouch.On_Swipe -= On_Swipe;
        EasyTouch.On_SwipeEnd -= On_SwipeEnd;
    }
    void LateUpdate ()
    {
        transform.LookAt(Look_Obj.transform);
        //Debug.Log("AAAA");
    }

    public void On_TouchStart (Gesture gesture)
    {
  

    }
    public void On_Drag (Gesture gesture)
    {
        //Vector3 position = gesture.GetTouchToWordlPoint(1);
        //transform.position = position;
        //Debug.Log("Position = " + position);
    }
    public void On_DragStart (Gesture gesture)
    {
    }
    public void On_DragEnd (Gesture gesture)
    {
    }
    private void On_SwipeStart (Gesture gesture)
    {
    }
    private void On_SwipeEnd (Gesture gesture)
    {
    }
    private void On_Swipe (Gesture gesture)
    {
        
        string str = gesture.swipe.ToString();
        Debug.Log("Swipe.ToString = " + str);
        Debug.Log("Last swipe : " + gesture.swipe.ToString() + " /  vector : " + gesture.swipeVector.normalized + " / angle : " + gesture.GetSwipeOrDragAngle().ToString("f2") + " / " + gesture.deltaPosition.x.ToString("f5"));
        if (str == "Right")
        {
            float f = CPA.percentage;
            CPA.Seek(f + 0.01f);
        }else if (str == "Left")
        {
            float f = CPA.percentage;
            CPA.Seek(f - 0.01f);
        }
    }
}
