using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTime : MonoBehaviour
{
    public float LeftTime;
    void Start()
    {
        Destroy(gameObject, LeftTime);
    }
}
