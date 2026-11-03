using UnityEngine;

public class maintainorthographicsize : MonoBehaviour
{
    private Camera cam;
    private ScreenOrientation currentScreenOrientation;
    private  float currentScreenHeight;
        void Start()
    {
        cam = GetComponent<Camera>();
        currentScreenOrientation=Screen.orientation;
        currentScreenHeight=Screen.height;
    }

    void Update()
    {
        if (Screen.orientation.CompareTo(currentScreenOrientation)!=0)
        {
            cam.orthographicSize*=((Screen.height)/currentScreenHeight);
            currentScreenOrientation=Screen.orientation;
            currentScreenHeight=Screen.height;

        }
    }
}