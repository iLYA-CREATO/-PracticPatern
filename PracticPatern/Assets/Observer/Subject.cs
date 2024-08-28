using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    private List<IObserver> _observers = new List<IObserver>();

    private void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    private void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    protected void NotifyObserver()
    {
        _observers.ForEach((observer) => {
            observer.OnNotify();
        });
    }
}
