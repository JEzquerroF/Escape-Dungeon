using UnityEngine;

public class Animator2D : MonoBehaviour
{
    public Texture2D _spritesheet;
    public int columns;
    public int rows = 1;
    public float frameRate;

    SpriteRenderer _spriteRenderer;
    int actualFrame = 0;
    Sprite[] _frames;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _frames = ObtainFrame();
        InvokeRepeating("ChangeFrame", 0, 1 / frameRate);
    }

    Sprite[] ObtainFrame()
    {
        Sprite[] frames = new Sprite[columns * rows];
        int widthFrame = _spritesheet.width / columns;
        int heighFrame = _spritesheet.height / rows;

        int index = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                int x = col * widthFrame;
                int y = row * heighFrame;

                frames[index] = Sprite.Create(_spritesheet, new Rect(x, y, widthFrame, heighFrame), new Vector2(0.5f, 0.5f));
                index++;
            }
        }

        return frames;
    }

    void ChangeFrame()
    {
        if (_frames.Length > 0)
        {
            _spriteRenderer.sprite = _frames[actualFrame];
            actualFrame = (actualFrame + 1) % _frames.Length;
        }
    }

    public void ChangeSpritesheet(Texture2D _newTexture2D, int _columns, float _frameRate)
    {
        _spritesheet = _newTexture2D;
        columns = _columns;
        frameRate = _frameRate;
        _frames = ObtainFrame();
    }
}
