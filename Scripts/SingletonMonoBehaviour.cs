using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Threading;

/// <summary>
/// MonoBehaviour�̃V���O���g��
/// </summary>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    private static object lookObj = new object();
    private static T instance = null;

    /// <summary>
    /// �B��̃V���O���g��
    /// </summary>
    public static T Instance { get; private set; }

    /// <summary>
    /// �C���X�^���X��gameObject����擾����
    /// </summary>
    public void SetInstance()
    {
        lock (lookObj)
        {
            if (Instance != null)
            {
                return;
            }

            Instance = gameObject.GetComponent<T>();
        }
    }

    /// <summary>
    /// �C���X�^���X��j������
    /// </summary>
    public void DestroyInstance()
    {
        lock (lookObj)
        {
            if (Instance == null)
            {
                return;
            }

            Destroy(Instance);
            Instance = null;
        }
    }
}
