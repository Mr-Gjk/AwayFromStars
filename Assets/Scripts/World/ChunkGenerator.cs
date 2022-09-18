using UnityEngine;

public class ChunkGenerator : Player
{

    [SerializeField] private GameObject[] starPrefab;
    public static int valueOfStars = 0;
    
    // Start is called before the first frame update
    void Awake()
    {
        float posX = _Player.transform.position.x;
        float posY = _Player.transform.position.y;
        SpawnStars(Mathf.PerlinNoise(posX, posY), Mathf.PerlinNoise(posY, posX));
    }

    private void SpawnStars(float x, float y)
    {
        for(int i = 0; i < 10; i++)
        {
            GameObject newStar = Instantiate(starPrefab[Random.Range(0, starPrefab.Length)]);
            newStar.transform.position = new Vector3(x * 10 + gameObject.transform.position.x, y * 10 + gameObject.transform.position.y, 0);
        }
    }
}
