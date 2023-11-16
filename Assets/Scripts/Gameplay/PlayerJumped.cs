using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player performs a Jump.
    /// </summary>
    /// <typeparam name="PlayerJumped"></typeparam>
    public class PlayerJumped : Simulation.Event<PlayerJumped>
    {
        public PlayerController player;

        public override void Execute()
        {
            if (player.audioSource && player.jumpSounds.Length > 0)
            {
                player.audioSource.PlayOneShot(player.jumpSounds[UnityEngine.Random.Range(0, player.jumpSounds.Length)]);
            }
        }
    }
}