using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainsys : MonoBehaviour
{
    public Sprite Water_img;
    public Sprite Coffee_img;
    Image thisImg;

    void Start()
    {
        thisImg = GameObject.Find("cup").GetComponent<Image>();
        thisImg.sprite = Water_img;
    }

    
    void WaterImage()
    {
        thisImg.sprite = Water_img;    
    }

    void CoffeeImage()
    {
        thisImg.sprite = Coffee_img;    
    }
}
