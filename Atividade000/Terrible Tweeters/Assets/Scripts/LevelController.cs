using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;

    Monster[] _monsters;
     

    void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (MosterAreAllDead())
            GoToNextLevel();
    }

    private void GoToNextLevel()
    {
        Debug.Log("Go to level" + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

    private bool MosterAreAllDead()
    {
        foreach (var monster in _monsters)
        {
            if (monster.gameObject.activeSelf)
                return false;
        }

        return true;
    }
}
