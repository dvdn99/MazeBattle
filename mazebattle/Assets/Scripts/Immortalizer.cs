using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortalizer : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
