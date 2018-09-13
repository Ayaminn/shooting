using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreate : MonoBehaviour
{

    public GameObject building;
    public GameObject building2;
    private float x;
    private float y;
    private float z;
    public int Repeat;
    public int Repeat2;

    void Start()
    {
        Vector3 placePosition = new Vector3(x, y, z);
        Vector3 placePosition2 = new Vector3(x, y, z);
        for (int j = 0; j < Repeat2; j++) {
            for (int i = 0; i < Repeat; i++)
            {
                placePosition.x = Random.Range(25, 225);
                placePosition2.x = Random.Range(25, 225);
                placePosition.y = 12.22f;
                placePosition2.y = 6.03f;
                placePosition.z = 60f + 30 * j;
                placePosition2.z = 60f + 30 * j;
                Instantiate(building, placePosition, Quaternion.identity);
                Instantiate(building2, placePosition2, Quaternion.identity);
            }
        }
    }
}
