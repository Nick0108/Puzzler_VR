using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    void Start()
    {
        Debug.Log("start1");
        StartCoroutine(Test());
        Debug.Log("start2");
    }

    IEnumerator Test()
    {
        Debug.Log("test1");
        yield return StartCoroutine(DoSomething());
        Debug.Log("test2");
    }

    IEnumerator DoSomething()
    {
        Debug.Log("load 1");
        yield return StartCoroutine(ForMoreThing());
        Debug.Log("load 2");
    }

    IEnumerator ForMoreThing()
    {
        Debug.Log("More 1");
        yield return StartCoroutine(ForlastThing());
        Debug.Log("More 2");
    }

    IEnumerator ForlastThing()
    {
        Debug.Log("Last 1");
        yield return null;
        Debug.Log("Last 2");
    }
}
