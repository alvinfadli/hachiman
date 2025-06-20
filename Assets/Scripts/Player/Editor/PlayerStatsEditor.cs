using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerStats))]
public class PlayerStatsEditor : Editor
{
    private PlayerStats StatsTarget => target as PlayerStats;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Reset Player"))
        {
            StatsTarget.ResetPlayer();
        }
    }
}
