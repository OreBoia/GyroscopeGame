using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGravity : MonoBehaviour
{
    // private void Movement()
    // {
    //     Vector2 movement = new Vector2(movementDirection.x * movementVelocity * Time.deltaTime,0);
    //     m_playerMageRB2D.AddForce(movement, ForceMode2D.Impulse);
    //     if (m_playerMageRB2D.velocity.x > maxVelocityCap || m_playerMageRB2D.velocity.x < -maxVelocityCap)
    //     {
    //         m_playerMageRB2D.velocity = new Vector2(Mathf.Clamp(m_playerMageRB2D.velocity.x, -maxVelocityCap, maxVelocityCap),m_playerMageRB2D.velocity.y);
    //     }
    //     if (Math.Abs(movementDirection.x) < 0.1f)
    //     {
    //         m_playerMageRB2D.velocity = Vector2.Lerp(new Vector2(m_playerMageRB2D.velocity.x, m_playerMageRB2D.velocity.y), new Vector2(0, m_playerMageRB2D.velocity.y), deceleration * Time.fixedDeltaTime);
    //     }
    // }
}
