using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInput : MonoBehaviour
{
    private Hero _hero;

    private void Awake()
    {
        _hero = GetComponent<Hero>();
    }
    public void Update ()
    {
        
        if (Input.GetKey(KeyCode.A)) 
        {
            _hero.SetDirection(-1);

        }else if(Input.GetKey(KeyCode.D))
        {
            _hero.SetDirection(1);
        }
        else
        {
            _hero.SetDirection(0);
        }

    }




}
