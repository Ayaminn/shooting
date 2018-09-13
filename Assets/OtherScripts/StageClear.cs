using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{
    public GameObject ClearText;
    // Use this for initialization
    void Start()
    {
        ClearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 850f)
        {
            ClearText.SetActive(true);
        }
    }
}
