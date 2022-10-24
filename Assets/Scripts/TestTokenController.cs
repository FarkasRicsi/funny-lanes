using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTokenController : TokenController
{
    public override void CreatePrefab()
    {
        CircleTokenBehaviour tokenBehaviour = circlePrefab.GetComponent<CircleTokenBehaviour>();

        float i = 0;

        foreach (var item in tokens)
        {
            tokenBehaviour.color = item.color;
            tokenBehaviour.spriteRenderer.color = item.colorRGB;
            Instantiate(circlePrefab, new Vector3(0f, i + 3f), Quaternion.identity);
            i += 2;
        }
    }
}
