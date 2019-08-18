using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoveringText : MonoBehaviour {

    public Transform target;
    Vector3 offset = Vector3.up;
    public bool clampToScreen = false;
    public float clampBorderSize = .05f;
    public bool useMainCamera = true;
    public Camera cameraToUse;
    private Camera cam;
    private Transform thisTransform;
    private Transform camTransform;


    // Start is called before the first frame update
    void Start() {
        
        thisTransform = gameObject.transform;

        if(useMainCamera) {

            cam = Camera.main;

        } else {

            cam = cameraToUse;
            camTransform = cam.transform;

        }

    }

    // Update is called once per frame
    void Update() {
        
        if(clampToScreen) {

            Vector3 relativePosition = camTransform.InverseTransformPoint(target.gameObject.transform.position);
            relativePosition.z = Mathf.Max(relativePosition.z, 1);
            thisTransform.position = cam.WorldToViewportPoint(camTransform.TransformPoint(relativePosition + offset));
            //thisTransform.position = Vector3(Mathf.Clamp(thisTransform.position.x, clampBorderSize, 1.0 = clampBorderSize),
                                             //Mathf.Clamp(thisTransform.position.y, clampBorderSize, 1.0 = clampBorderSize),
                                             //thisTransform.position.z);

        } else  {

            thisTransform.position = cam.WorldToViewportPoint(target.position + offset);

        }

    }
}
