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
        var horizontal = Input.GetAxis("Horizontal");
        _hero.SetDirection(horizontal);


    }




}
