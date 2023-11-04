using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public GameObject touchGO;
    public List<TouchLocation> touches = new List<TouchLocation>();
    
    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch t = Input.GetTouch(i);
            if (t.phase == TouchPhase.Began)
            {
                Debug.Log("touch began");
                touches.Add(new TouchLocation(t.fingerId, createTouchGO(t)));
            }
            else if (t.phase == TouchPhase.Ended)
            {
                Debug.Log("touch ended");
                TouchLocation thisTouch = touches.Find(TouchLocation => TouchLocation.touchId == t.fingerId);
                Destroy(thisTouch.touchGO);
                touches.RemoveAt(touches.IndexOf(thisTouch));
                //TODO vector distance here! Plaer babse and touch communication
            }
            else if (t.phase == TouchPhase.Moved)
            {
                Debug.Log("touch is moving");
                TouchLocation thisTouch = touches.Find(TouchLocation => TouchLocation.touchId == t.fingerId);
                thisTouch.touchGO.transform.position = getTouchPosition(t.position);
            }
        }
    }
    Vector2 getTouchPosition(Vector2 touchPosition)
    {
        return GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, transform.position.z));
    }
    GameObject createTouchGO(Touch t)
    {
        GameObject c = Instantiate(touchGO) as GameObject;
        c.name = "Touch" + t.fingerId;
        c.transform.position = getTouchPosition(t.position);
        return c;
    }
}
