using UnityEngine;

public class FarmableObject : MonoBehaviour
{
    [Tooltip("What farmable object this is. E.G: tree, Stone...etc")]
    [SerializeField] string thisFarmableObjectType;
    [SerializeField] int hitsToBreak = 1;


    public void OnHit()
    {
        hitsToBreak -= 1;

        if(hitsToBreak <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnDestroy()
    {
        Debug.Log("Give Items");
    }
}
