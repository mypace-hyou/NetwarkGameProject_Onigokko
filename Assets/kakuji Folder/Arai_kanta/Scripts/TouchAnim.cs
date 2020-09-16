using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAnim : MonoBehaviour
{
    public Animation anim;
    void Update()
    {
        //左クリックを受け付ける
        if (Input.GetMouseButtonDown(0))
        {
            anim = this.gameObject.GetComponent<Animation>();
            anim.Play();
            Debug.Log("Left Click.");
        }
    }
}
