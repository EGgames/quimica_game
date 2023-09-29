using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health;

    void Start()
    {

    }


    public void TakeHit(float damage)
    {
        health -= damage;

    }

}