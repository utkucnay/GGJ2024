using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform[] parallaxLayer5;
    public float parallaxSpeed5;
    public Transform[] parallaxLayer4;
    public float parallaxSpeed4;
    public Transform[] parallaxLayer3;
    public float parallaxSpeed3;
    public Transform[] parallaxLayer2;
    public float parallaxSpeed2;
    public Transform[] parallaxLayer1;
    public float parallaxSpeed1;

    const int a = -2000;
    private void Update()
    {
        foreach (Transform t in parallaxLayer1) 
        {
            t.transform.position += Vector3.left * parallaxSpeed1 * Time.timeScale;

            if (t.transform.position.x < a) 
            {
                var pos = t.transform.position;
                //pos.x += 5800;
                pos.x += 958 * 6;
                t.transform.position = pos;
            }
        }

        foreach (Transform t in parallaxLayer2)
        {
            t.transform.position += Vector3.left * parallaxSpeed2 * Time.timeScale;

            if (t.transform.position.x < a)
            {
                var pos = t.transform.position;
                //pos.x += 5800;
                pos.x += 958 * 6;
                t.transform.position = pos * Time.deltaTime;
            }
        }

        foreach (Transform t in parallaxLayer3)
        {
            t.transform.position += Vector3.left * parallaxSpeed3 * Time.timeScale;

            if (t.transform.position.x < a)
            {
                var pos = t.transform.position;
                //pos.x += 5800;
                pos.x += 958 * 6;
                t.transform.position = pos;
            }
        }

        foreach (Transform t in parallaxLayer4)
        {
            t.transform.position += Vector3.left * parallaxSpeed4 * Time.timeScale;

            if (t.transform.position.x < -1000)
            {
                var pos = t.transform.position;
                //pos.x += 5800;
                pos.x += 958 * 6;
                t.transform.position = pos;
            }
        }

        foreach (Transform t in parallaxLayer5)
        {
            t.transform.position += Vector3.left * parallaxSpeed5 * Time.timeScale;

            if (t.transform.position.x < a)
            {
                var pos = t.transform.position;
                //pos.x += 5800;
                pos.x += 958 * 6;
                t.transform.position = pos;
            }
        }
    }
}
