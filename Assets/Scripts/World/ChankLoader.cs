using UnityEngine;
using System;

public class ChankLoader : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Rigidbody2D _playerRigidbody2D;
    [SerializeField] private ChunkGenerator Chunk;
    [SerializeField] private float _sizeChunk;
    float startX , startY ;
    float deltaX, deltaY;
    bool isDownloadX = false,
        isDownloadY = false;
    void Awake()
    {
        startX = _player.transform.position.x;
        startY = _player.transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        if (!isDownloadX&&!isDownloadY)
        {
            deltaX = _player.transform.position.x;
            deltaY = _player.transform.position.y;
            if (startX * _sizeChunk - deltaX < 0)
            {
                isDownloadX = true;
                DownloadChanks();
                startX++;
            }
            else if (deltaX < (startX - 1) * _sizeChunk)
            {
                isDownloadX = true;
                DownloadChanks();
                startX--;
            }
            if (startY * _sizeChunk - deltaY < 0)
            {
                isDownloadY = true;
                DownloadChanks();
                startY++;
            }
            else if (deltaY < (startY - 1) * _sizeChunk)
            {
                isDownloadY = true;
                DownloadChanks();
                startY--;
            }
        }
        else {
            isDownloadX = false;
            isDownloadY = false;
        }
        //_player.transform.position;
    }
    void DownloadChanks()
    {
        ChunkGenerator newChunk = Instantiate(Chunk);
        newChunk.transform.position = new Vector3(startX * _sizeChunk, startY * _sizeChunk, 0);
        //spawnedStars.Add(newStar);
    }
}
