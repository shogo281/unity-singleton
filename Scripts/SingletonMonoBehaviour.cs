using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// MonoBehaviourのシングルトン
/// </summary>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    private static T instance = null;

    /// <summary>
    /// 唯一のシングルトン
    /// </summary>
    public static T Instance { get; private set; }

    /// <summary>
    /// インスタンスをgameObjectから取得する
    /// </summary>
    public void SetInstance()
    {
        if (Instance != null)
        {
            return;
        }

        Instance = gameObject.GetComponent<T>();
    }

    /// <summary>
    /// インスタンスを破棄する
    /// </summary>
    public void DestroyInstance()
    {
        if (Instance == null)
        {
            return;
        }

        Destroy(Instance);
        Instance = null;
    }
}
