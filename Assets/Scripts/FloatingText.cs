using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour {

    public Animator animator;
    private Text distanceText;

    // Start is called before the first frame update
    void OnEnable() {

        Debug.Log("Start");
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        distanceText = animator.GetComponent<Text>();

    }
    

    // Update is called once per frame
    public void SetText(string Text) {
        
        Debug.Log("SetText");
        distanceText.text = Text;

    }
}
