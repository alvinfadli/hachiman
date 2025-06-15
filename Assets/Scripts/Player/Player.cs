using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;
    private PlayerAnimations playerAnimations;
    public PlayerStats Stats => stats;

    private void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    public void ResetPlayer()
    {
        stats.ResetPlayer();
        playerAnimations.ResetPlayer();
    }
}
