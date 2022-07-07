using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChopChop
{
    public class SpawnAndDestroy : MonoBehaviour
    {
        void Start()
        {
            var children = GetAllChildren();
            foreach (var child in children)
            {
                child.SetParent(null);
            }
            Destroy(gameObject);
        }
        List<Transform> GetAllChildren()
        {
            List<Transform> children = new List<Transform>();
            foreach (var child in transform.GetComponentsInChildren<Transform>())
            {
                if (child != transform)
                {
                    children.Add(child);
                }
            }
            return children;
        }
    }
}
