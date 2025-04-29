using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform spawnPoint;

    IEnumerator Start()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomIndex], spawnPoint.position, Quaternion.identity);

            // Ambil interval terbaru berdasarkan level
            float interval = GetCurrentInterval();
            yield return new WaitForSeconds(interval);
        }
    }

    // Fungsi untuk menentukan interval berdasarkan level
    float GetCurrentInterval()
    {
        if (Data.level >= 5)
            return 1f;
        else if (Data.level == 4)
            return 1.5f;
        else if (Data.level == 3)
            return 2f;
        else if (Data.level == 2)
            return 2.5f;
        else
            return 3f;
    }
}
