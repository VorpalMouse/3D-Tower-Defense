using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalloffGenerator
{
    public static float[,] Generate(int xSize, int zSize, float falloffStart, float falloffEnd)
    {
        float[,] heightMap = new float[xSize, zSize];

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                Vector2 position = new Vector2(
                    (float)x / xSize * 2 - 1,
                    (float)z / zSize * 2 - 1
                    );

                //figure out which value closer to edge.
                float t = Mathf.Max(Mathf.Abs(position.x), Mathf.Abs(position.y));

                if (t < falloffStart)
                {
                    heightMap[x, z] = 1;
                } else if (t > falloffEnd){
                    heightMap[x, z] = 0;
                } else
                {
                    heightMap[x, z] = Mathf.SmoothStep(1, 0, Mathf.InverseLerp(falloffStart, falloffEnd, t));
                }

            }
        }

        return heightMap;
    }
}
