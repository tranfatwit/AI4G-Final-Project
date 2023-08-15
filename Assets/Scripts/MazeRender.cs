using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRender : MonoBehaviour {

    [SerializeField]
    [Range(1, 50)]
    private int width = 10;

    [SerializeField]
    [Range(1, 50)]
    private int height = 10;

    [SerializeField]
    private float size = 5f;

    [SerializeField]
    private Transform wallPrefab = null;

    //[SerializeField]
    //private Transform floorPrefab = null;

    [SerializeField]
    private Vector3 startingPosition = new Vector3(0, 0, 0);

    [SerializeField]
    private Vector3 startingPositionAI = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start() {
        var maze = MazeGenerator.Generate(width, height);
        Draw(maze, startingPosition);
        Draw(maze, startingPositionAI);
    }

    private void Draw(WallState[,] maze, Vector3 location) {

        //var floor = Instantiate(floorPrefab, transform);
        //floor.localScale = new Vector3(width, 1, height);

        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {

                var currentPosition = new Vector3(location.x + (i * size), location.y, location.z + (j * size));

                var cell = maze[i, j];
                var position = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z);

                if(cell.HasFlag(WallState.UP)) {
                    if(i != (width - 1) || j != (height - 1)) {
                        var topWall = Instantiate(wallPrefab, transform) as Transform;
                        topWall.position = position + new Vector3(0, 0, size / 2);
                        topWall.localScale = new Vector3(topWall.localScale.x, topWall.localScale.y, topWall.localScale.z);
                        topWall.eulerAngles = new Vector3(0, 90, 0);
                    }
                }

                if(cell.HasFlag(WallState.LEFT)) {
                    var leftWall = Instantiate(wallPrefab, transform) as Transform;
                    leftWall.position = position + new Vector3(-size / 2, 0, 0);
                    leftWall.localScale = new Vector3(leftWall.localScale.x, leftWall.localScale.y, leftWall.localScale.z);
                }

                if(i == width - 1) {
                    if(cell.HasFlag(WallState.RIGHT)) {
                        var rightWall = Instantiate(wallPrefab, transform) as Transform;
                        rightWall.position = position + new Vector3(size / 2, 0, 0);
                        rightWall.localScale = new Vector3(rightWall.localScale.x, rightWall.localScale.y, rightWall.localScale.z);
                    }
                }

                if(j == 0) {
                    if(i != 0) {
                        if(cell.HasFlag(WallState.DOWN)) {    
                            var bottomWall = Instantiate(wallPrefab, transform) as Transform;
                            bottomWall.position = position + new Vector3(0, 0, -size / 2);
                            bottomWall.localScale = new Vector3(bottomWall.localScale.x, bottomWall.localScale.y, bottomWall.localScale.z);
                            bottomWall.eulerAngles = new Vector3(0, 90, 0);
                        }
                    }
                }
            }
        }


    }

    // Update is called once per frame
    void Update() {
        
    }
}
