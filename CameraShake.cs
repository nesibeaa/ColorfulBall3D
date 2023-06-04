using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private bool shakecontrol=false;
    public IEnumerator CameraShakes(float duration, float magnitude)
    {
        Vector3 orriginalPos=transform.localPosition;

        float elapsed=0.0f;

        while (elapsed<duration)
        {
            float x= Random.Range(-1f,1f)*magnitude;
            float y= Random.Range(-1f,1f)*magnitude;

            transform.localPosition=new Vector3(x, y, orriginalPos.z);

            elapsed+=Time.deltaTime;
            yield return null;

        }

        transform.localPosition= orriginalPos;


        
    }

    public void CameraShakesCall()
    {
        if (shakecontrol==false)
        {
            StartCoroutine(CameraShakes(0.22f, 0.4f));
            shakecontrol=true;

        }

        

    }
}
