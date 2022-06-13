using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
public static LevelManager instance;

public Transform respawnPoint;
public GameObject dragonPrefab;

private void Awake()
{
instance=this;

}

public void Respawn ()
{
Instantiate(dragonPrefab, respawnPoint.position, Quaternion.identity);

}
    }
