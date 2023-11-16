using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when a player collides with a token.
    /// </summary>
    /// <typeparam name="PlayerCollision"></typeparam>
    public class PlayerTokenCollision : Simulation.Event<PlayerTokenCollision>
    {
        public PlayerController player;
        public TokenInstance token;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            if (token.tokenCollectSounds.Length > 0)
            {
                //AudioSource.PlayClipAtPoint(token.tokenCollectSounds[UnityEngine.Random.Range(0, token.tokenCollectSounds.Length)], token.transform.position);
                player.audioSource.PlayOneShot(token.tokenCollectSounds[UnityEngine.Random.Range(0, token.tokenCollectSounds.Length)], 0.7f);
            }
        }
    }
}