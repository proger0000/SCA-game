using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts
{
   public class LayerCheck : MonoBehaviour
   {
       [SerializeField] private LayerMask _groundLayer;
       [SerializeField] private bool _isTouchingLayer;
       private Collider2D _collider;
       
       public bool IsTouchingLayer;
   
       private void Awake()
       {
           _collider = GetComponent<Collider2D>();
       }
   
       private void OnTriggerStay2D(Collider2D other)
       {
           IsTouchingLayer = _collider.IsTouchingLayers(_groundLayer);
       }
   
       private void OnTriggerExit(Collider other)
       {
           IsTouchingLayer = _collider.IsTouchingLayers(_groundLayer);
       }
   } 
}

