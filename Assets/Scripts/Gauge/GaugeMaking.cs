using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaugeMaking : MonoBehaviour
{
    public GameObject gauge;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(gauge);
    }
}
