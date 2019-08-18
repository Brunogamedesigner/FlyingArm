using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextController : MonoBehaviour {
    
    private static FloatingText popupDistanceText;
    private static GameObject canvas;

    public static void Initialize() {

        canvas = GameObject.Find("Canvas");

        if(!popupDistanceText) {

            popupDistanceText = Resources.Load<FloatingText>("Prefabs/PopupDistanceTextParent");

        }

    }

    public static void CreateFloatingText(string text, Transform location) {

        FloatingText instance = Instantiate(popupDistanceText);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(new Vector2(location.position.x, location.position.y + 2));

        instance.transform.SetParent(canvas.transform, false); 
        instance.transform.position = screenPosition;
        instance.SetText(text);

    }

}
