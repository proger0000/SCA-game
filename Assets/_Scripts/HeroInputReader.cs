using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PixelCrew
{
    public class HeroInputReader : MonoBehaviour
    {
        [SerializeField] private Hero _hero;
        private HeroInputAction _inputActions;
        private void Awake()
        {
            _inputActions = new HeroInputAction();
            _inputActions.Hero.HorizontalMovement.performed += OnHorizontalMovement;
            _inputActions.Hero.HorizontalMovement.canceled += OnHorizontalMovement;
            _inputActions.Hero.SaySomething.performed += OnSaySomething;
        }
    
        private void OnEnable()
        {
            _inputActions.Enable();
        }
    
        public void OnHorizontalMovement(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<float>();
            _hero.SetDirection(direction);
        }
    
        public void OnSaySomething(InputAction.CallbackContext context)
        {
            _hero.SaySomethintg();
        }
    }
}

