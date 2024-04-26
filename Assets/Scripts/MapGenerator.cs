using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject box;
    [SerializeField] private GameObject obstacle;
    [SerializeField] private GameObject targetPoint;
    [SerializeField] private GameObject startingPosition;

    [SerializeField] private char backgroundSign = '.';
    [SerializeField] private char boxSign = '*';
    [SerializeField] private char obstacleSign = '#';
    [SerializeField] private char targetPointSign = 'o';
    [SerializeField] private char startingPositionSign = 'x';

    private void Start()
    {
        FileHandler fileHandler = new FileHandler();
        GenerateLevel(fileHandler.Read());

    }
    public void GenerateLevel(char[,] map)
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                char currentChar = map[i,j];
                if (currentChar == backgroundSign)
                    Instantiate(background, new Vector2(i,-j),Quaternion.identity);
                if (currentChar == boxSign)
                {
                    Instantiate(background, new Vector2(i, -j), Quaternion.identity);
                    Instantiate(box, new Vector2(i, -j), Quaternion.identity);
                }
                if (currentChar == obstacleSign)
                    Instantiate(obstacle, new Vector2(i, -j), Quaternion.identity);
                if (currentChar == targetPointSign)
                    Instantiate(targetPoint, new Vector2(i, -j), Quaternion.identity);
                if (currentChar == startingPositionSign)
                {
                    Instantiate(background, new Vector2(i, -j), Quaternion.identity);
                    Instantiate(startingPosition, new Vector2(i, -j), Quaternion.identity);
                }
            }
        }
    }
}
