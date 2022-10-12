using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class MeatSpawner : MonoBehaviour
{
    public int meatCount;
    [SerializeField] private float maxYPos;
    [SerializeField] private float maxXPos;
    [SerializeField] private GameObject meatObject;
    [SerializeField] private Text meatCountText;

    public void MeatSpawn()
    {
        if (meatCount > 9) return;
        RefreshCountText();
        Debug.Log(-maxXPos + "//" + -1 * maxXPos);
        Instantiate(meatObject, 
            new Vector2(Random.Range(-1 * maxXPos, maxXPos), Random.Range(-1 * maxYPos, maxYPos)),
            quaternion.identity);
    }

    public void RefreshCountText()
    {
        meatCountText.text = $"고기 수: {meatCount}";
    }
}
