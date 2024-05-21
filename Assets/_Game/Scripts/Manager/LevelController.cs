using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private List<BlockSpawn> blockSpawners;
    [SerializeField] private List<Transform> bridges;

    public BlockSpawn GetCurrentBlockSpawnerInFloor(int floor)
    {
        return blockSpawners[floor];
    }

    public Transform GetCurrentBridgeInFloor(int floor)
    {
        return bridges[floor];
    }
}
