using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WashingPlate : MonoBehaviour
{
   [SerializeField] private int washLevel = 0;
   private SpriteRenderer _spriteRenderer;

   private void Start()
   {
      _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
   }


   public void LevelUp()
   {
      washLevel++;
      switch (washLevel)
      {
         case 1:
            _spriteRenderer.color = Color.white;
            return;
         case 2:
            Washing();
            return;
      }
   }

   void Washing()
   {
      Destroy(gameObject);
   }
}
