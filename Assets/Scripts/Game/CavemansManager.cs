using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavemansManager : MonoBehaviour {

    [SerializeField]
    private List<GameObject> CavemenPrefabs;

    private void Start() {
        Caveman[] cs = FindObjectsOfType<Caveman>();
        int[] randArr = new int[cs.Length];
        bool[] chosenElls = new bool[CavemenPrefabs.Count];
        for (int i = 0; i < cs.Length; i++) {
            int temp;
            do {
                temp = Mathf.RoundToInt(Random.Range(-0.49f, CavemenPrefabs.Count - 0.51f));
            } while (chosenElls[temp]);
            chosenElls[temp] = true;
            GameObject newCav = Instantiate(CavemenPrefabs[temp], cs[i].transform.position, cs[i].transform.rotation, cs[i].transform.parent);
            GameObject newSkin = Instantiate(SkinSet.Current.Skins[temp], cs[i].transform.position, cs[i].transform.rotation, cs[i].transform.GetChild(0));
        }
    }

}
