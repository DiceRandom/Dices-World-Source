using UnityEngine;
using System.Collections;

public class BlockPlacer : MonoBehaviour {

    //Handles # of blocks the user has
    public bool unlimitedBlocks = false;
    public int blocksLeft = 0;

    //If the player wants to lock the cursor somewhere else instead, they can do that.
    public bool lockCursor = true;

    //static reference to the script. This is so blocks can be added via a static method.
    static BlockPlacer obj;

    public bool carpetInc;

    private Vector3 placeAt;

    public Collider playerGO;

    //The block prefab to instantiate
    public GameObject blockPrefab;

    //Maximum range that the player can place a block from
    public float range = 7f;

    public GameObject statsObject;
    public float objectsPlaced;

	void Start () {
        //This assigns the static reference
        BlockPlacer.obj = this;
        //numberOfJumps = statsObject.GetComponent<StatsScript>().numOfJumps;
	}

	void Update () {
        //Locks the cursor. Running this in update is only done because of weird unity editor shenanigans with cursor locking
    if(Time.timeScale == 1.0){
        if (blocksLeft > 0 || unlimitedBlocks)
        {
            //Place blocks using the LMB
            if (Input.GetMouseButtonDown(1))
            {
                //Make a ray and raycasthit for a raycast
                Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
                RaycastHit hit;

                //Perform the raycast
                if (Physics.Raycast(ray, out hit, range))
                {
                    Debug.Log(hit.transform.tag);
                    Debug.Log(hit.transform);
                    //The raycast is backed up so that placing works and won't place blocks inside of the ground.
                    //After testing, 0.2 units back had the best result
                    Vector3 backup = ray.GetPoint(hit.distance - 0.2f);

                    //Debug.Log(hit.transform.tag);

                    objectsPlaced++;
                    statsObject.GetComponent<StatsScript>().objectsPlacedV = objectsPlaced;

                    Vector3 placeAt = new Vector3(
                        Mathf.RoundToInt(backup.x), Mathf.RoundToInt(backup.y), Mathf.RoundToInt(backup.z));

                    //Instantiate the block and save it so that we can do other stuff with it later
                    GameObject block = (GameObject)GameObject.Instantiate(blockPrefab, placeAt, Quaternion.Euler(Vector3.zero));

                    //Remove a block from the player's "inventory"
                    if (!unlimitedBlocks)
                        blocksLeft--;

                    //If the block collides with the player, remove it. We don't want the player to get stuck in their own blocks.
                    if (block.GetComponent<Collider>().bounds.Intersects(playerGO.GetComponent<Collider>().bounds))
                    {
                        //If they are, destroy the block
                        GameObject.Destroy(block);
                        //Make sure that the player gets their misplaced block back.
                        if (!unlimitedBlocks)
                            blocksLeft++;
                    }
               
                }
            }
        }
    }
	}

    void OnGUI()
    {
        //This is the crosshair
        //GUI.Box(new Rect(Screen.width / 2 - 5, Screen.height / 2 - 5, 5, 5), "");
    }

    //Static adding of blocks. This isn't needed but definately helps a lot
    public static void addBlocks(int i = 1){
        BlockPlacer.obj.blocksLeft += i;
    }
}
