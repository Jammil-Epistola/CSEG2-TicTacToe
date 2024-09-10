using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgScroller : MonoBehaviour
{
    [SerializeField] private RawImage bgImg;
    [SerializeField] private float bgX, bgY;
    // Update is called once per frame

    void Update()
    {
        bgImg.uvRect = new Rect(bgImg.uvRect.position + new Vector2(bgX, bgY) * Time.deltaTime, bgImg.uvRect.size);
    }
}
