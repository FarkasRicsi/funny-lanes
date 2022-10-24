using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Token", menuName = "Token")]
public class ScriptableToken : ScriptableObject
{
    public EColor color;
    public Sprite artwork;
    public Color colorRGB;
}
