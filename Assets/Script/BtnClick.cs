using UnityEngine;

public class BtnClick : MonoBehaviour
{
     public AudioSource mySound;
    public AudioClip onClickBtn;

    public void OnClickSound(){
        mySound.PlayOneShot(onClickBtn);
    }
}
