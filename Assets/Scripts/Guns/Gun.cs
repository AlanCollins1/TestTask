using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject BulletPrefab;
    public Transform Spawn;
    //public AudioSource ShotSound;
    //public GameObject Flash;
    //public ParticleSystem ShoteEffect;

    [Space(10f)]
    public float BulletSpeed = 10;
    public float ShotPeriod = 0.2f;

    private float timer;
    private void Start() {
        //Flash.SetActive(false);
    }
    void Update() {
        timer += Time.deltaTime;
        if (timer > ShotPeriod) {
            if (Input.GetMouseButton(0)) {
                

            }
        }
    }
    virtual public void Shot() {
        GameObject newBullet = Instantiate(BulletPrefab, Spawn.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = Spawn.forward * BulletSpeed;
        timer = 0;
        //ShotSound.Play();
        //Flash.SetActive(true);
        //Invoke("HideFlash", 0.08f);
        //ShoteEffect.Play();
    }
    public void HideFlash() {
        //Flash.SetActive(false);
    }
    public virtual void Activate() {
        gameObject.SetActive(true);
    }
    public virtual void Deactivate() {
        gameObject.SetActive(false);
    }
    public virtual void AddBullets(int bullets) {

    }
}
