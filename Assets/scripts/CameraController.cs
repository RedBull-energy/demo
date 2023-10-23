using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private UnityEngine.Vector3 pos;

    private void Awake()
    {
        if (!player)
        player = FindObjectOfType<Hero>().transform;
    }

    private void Update()
    {

        pos = player.position;
        pos.z = -10f;
        transform.position = UnityEngine.Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
