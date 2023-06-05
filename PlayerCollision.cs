using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    // When the game object collides then the name will be printed with which it have collided...
    /*private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
    }*/



    // When the game object collides then the tag will be printed with which it have collided...
    /*private void OnCollisionEnter(Collision collisionInfo) 
    {
        Debug.Log(collisionInfo.collider.tag);
    }*/



    // When the game object collides with the mentioned tag i.e. Obstacle then the message will be printed
    /*private void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
        }
    }*/



    // When the game object collides with the mentioned tag i.e. Obstacle then the movement of the player
    // will get disabled...
    private void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
