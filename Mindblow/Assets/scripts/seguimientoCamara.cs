using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimientoCamara : MonoBehaviour {

    public Vector2 focusAreaSize;
    public GameObject player;

    focusArea FocusArea;

    float playerCenterX, playerCenterY;

    int x = 0;
    float l = 0, r = 0, u = 0, d = 0;

    struct focusArea
    {
        public Vector2 center;
        public Vector2 velocity;
        public float left, right;
        public float up, down;
        float minX, maxX, minY, maxY;

        public focusArea(float xC, float yC, int num, float l, float r, float d, float u, Vector2 size)
        {
            minX = (float)(xC - 0.5);
            maxX = (float)(xC + 0.5);
            minY = (float)(yC - 0.5);
            maxY = (float)(yC + 0.5);

            if (num == 0)
            {
                left = minX - size.x / 2;
                right = maxX + size.x / 2;
                down = minY;
                up = minY + size.y;
            }
            else
            {
                left = l;
                right = r;
                down = d;
                up = u;
            }

            center = new Vector2((left + right) / 2, (up + down) / 2);

            float shiftX = 0;
            if (minX < left) shiftX = minX - left;
            else if (maxX > right) shiftX = maxX - right;
            left += shiftX;
            right += shiftX;

            float shiftY = 0;
            if (minY < down) shiftY = minY - down;
            else if (maxY > up) shiftY = maxY - up;
            down += shiftY;
            up += shiftY;

            center = new Vector2((left + right) / 2, (down + up) / 2);
            velocity = new Vector2(shiftX, shiftY);
        }
    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerCenterX = player.transform.localPosition.x;
        playerCenterY = player.transform.localPosition.y;
    }

    // Use this for initialization
    void Start () {
        FocusArea = new focusArea(playerCenterX, playerCenterY, x, l, r, d, u, focusAreaSize);
        x++;
        transform.localPosition = new Vector3(player.transform.localPosition.x, player.transform.localPosition.y + (float)3.67, transform.localPosition.z);
    }
	
	// Update is called once per frame
	void LateUpdate () {
        playerCenterX = player.transform.localPosition.x;
        playerCenterY = player.transform.localPosition.y;

        l = FocusArea.left;
        r = FocusArea.right;
        d = FocusArea.down;
        u = FocusArea.up;

        FocusArea = new focusArea(playerCenterX, playerCenterY, x, l, r, d, u, focusAreaSize);

        transform.localPosition = new Vector3(transform.localPosition.x + FocusArea.velocity.x, transform.localPosition.y + FocusArea.velocity.y, transform.localPosition.z);
    }
}
