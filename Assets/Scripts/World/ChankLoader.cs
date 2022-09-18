using UnityEngine;

public class ChankLoader : Player
{
    private ChunkGenerator Chunk;
    private float _sizeChunk = 50;

    float currX , currY ;
    float deltaX, deltaY;

    bool isDownloadX = false,
        isDownloadY = false;

    void ChunkLoader()
    {
        Chunk = GameObject.Find("Chunk").GetComponent<ChunkGenerator>();
        currX = _Player.transform.position.x;
        currY = _Player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDownloadX&&!isDownloadY)
        {
            deltaX = _Player.transform.position.x;
            deltaY = _Player.transform.position.y;
            if (currX * _sizeChunk - deltaX < 0)
            {
                isDownloadX = true;
                DownloadChanks();
                currX++;
            }
            else if (deltaX < (currX - 1) * _sizeChunk)
            {
                isDownloadX = true;
                DownloadChanks();
                currX--;
            }
            if (currY * _sizeChunk - deltaY < 0)
            {
                isDownloadY = true;
                DownloadChanks();
                currY++;
            }
            else if (deltaY < (currY - 1) * _sizeChunk)
            {
                isDownloadY = true;
                DownloadChanks();
                currY--;
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
        newChunk.transform.position = new Vector3(currX * _sizeChunk, currY * _sizeChunk, 0);
        //spawnedStars.Add(newStar);
    }
}
