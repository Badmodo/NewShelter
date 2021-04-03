using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float Speed = 1;
    public List<SpriteRenderer> sprites = new List<SpriteRenderer>();
    public List<Sprite> images = new List<Sprite>();
    public Direction Direction = Direction.Right;


    private float heightCamera;
    private float widthCamera;

    private Vector3 PositionCam;
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
        heightCamera = 2f * cam.orthographicSize;
        widthCamera = heightCamera * cam.aspect;
    }

    void Update()
    {
        foreach (var item in sprites)
        {
            if (Direction == Direction.Left)
            {
                if (item.transform.position.x + item.bounds.size.x / 2 < cam.transform.position.x - widthCamera / 2)
                {
                    SpriteRenderer sprite = sprites[0];
                    foreach (var i in sprites)
                    {
                        if (i.transform.position.x > sprite.transform.position.x)
                            sprite = i;
                    }
                    item.sprite = images[UnityEngine.Random.Range(0, images.Count)];

                    item.transform.position = new Vector2((sprite.transform.position.x + (sprite.bounds.size.x / 2) + (item.bounds.size.x / 2)), sprite.transform.position.y);
                }
            }
            else if (Direction == Direction.Right)
            {
                if (item.transform.position.x - item.bounds.size.x / 2 > cam.transform.position.x + widthCamera / 2)
                {
                    SpriteRenderer sprite = sprites[0];
                    foreach (var i in sprites)
                    {
                        if (i.transform.position.x < sprite.transform.position.x)
                            sprite = i;
                    }
                    item.sprite = images[UnityEngine.Random.Range(0, images.Count)];

                    item.transform.position = new Vector2((sprite.transform.position.x - (sprite.bounds.size.x / 2) - (item.bounds.size.x / 2)), sprite.transform.position.y);
                }
            }
            else if (Direction == Direction.Down)
            {
                if (item.transform.position.y + item.bounds.size.y / 2 < cam.transform.position.y - heightCamera / 2)
                {
                    SpriteRenderer sprite = sprites[0];
                    foreach (var i in sprites)
                    {
                        if (i.transform.position.y > sprite.transform.position.y)
                            sprite = i;
                    }
                    item.sprite = images[UnityEngine.Random.Range(0, images.Count)];

                    item.transform.position = new Vector2(sprite.transform.position.x, (sprite.transform.position.y + (sprite.bounds.size.y / 2) + (item.bounds.size.y / 2)));
                }
            }
            else if (Direction == Direction.Up)
            {
                if (item.transform.position.y - item.bounds.size.y / 2 > cam.transform.position.y + heightCamera / 2)
                {
                    SpriteRenderer sprite = sprites[0];
                    foreach (var i in sprites)
                    {
                        if (i.transform.position.y < sprite.transform.position.y)
                            sprite = i;
                    }
                    item.sprite = images[UnityEngine.Random.Range(0, images.Count)];

                    item.transform.position = new Vector2(sprite.transform.position.x, (sprite.transform.position.y - (sprite.bounds.size.y / 2) - (item.bounds.size.y / 2)));
                }
            }


            if (Direction == Direction.Left)
                item.transform.Translate(new Vector2(Time.deltaTime * Speed * -1, 0));
            else if (Direction == Direction.Right)
                item.transform.Translate(new Vector2(Time.deltaTime * Speed, 0));
            else if (Direction == Direction.Down)
                item.transform.Translate(new Vector2(0, Time.deltaTime * Speed * -1));
            else if (Direction == Direction.Up)
                item.transform.Translate(new Vector2(0, Time.deltaTime * Speed));
        }

    }
}

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}
