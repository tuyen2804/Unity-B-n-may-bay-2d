using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiMonoBehaviour : MonoBehaviour
{
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void Start()
    {

    }
    protected virtual void Reset()
    {
        this.LoadComponents();
        this.ResetValues();
    }
    protected virtual void LoadComponents()
    {

    }
    protected virtual void ResetValues()
    {

    }
    protected virtual void Onable()
    {

    }
    protected virtual void OnDisable()
    {

    }
}
