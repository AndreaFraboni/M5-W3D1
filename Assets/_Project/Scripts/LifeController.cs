using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
       
    [SerializeField] private int _hpMax = 100;

    private int _hp;

    public int HP
    {
        get { return _hp; }
        set { _hp = value; }
    }






}
