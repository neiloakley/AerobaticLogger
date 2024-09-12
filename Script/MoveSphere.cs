using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MoveSphere : MonoBehaviour
{
    private List<Vector3> positions = new List<Vector3>();
    private int currentIndex = 0;

    void Start()
    {
        // Read CSV file
        string path = Application.dataPath + "/positions.csv";
        using (StreamReader reader = new StreamReader(path))
        {
            bool header = true;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (header)
                {
                    header = false;
                    continue;
                }
                var values = line.Split(',');
                float latitude = float.Parse(values[1]);
                float longitude = float.Parse(values[2]);
                float height = float.Parse(values[3]);
                positions.Add(new Vector3(latitude, height, longitude));
            }
        }

        // Start the movement coroutine
        StartCoroutine(MoveSphereCoroutine());
    }

    IEnumerator MoveSphereCoroutine()
    {
        while (true)
        {
            if (currentIndex < positions.Count)
            {
                transform.position = positions[currentIndex];
                currentIndex++;
                yield return new WaitForSeconds(0.1f); // Adjust the speed as needed
            }
            else
            {
                yield break;
            }
        }
    }
}