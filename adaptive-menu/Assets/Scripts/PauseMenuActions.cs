using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuActions : MonoBehaviour {

    [SerializeField]
    private AnimationClip anim;
    [SerializeField]
    private Animator backgroundAnimator;

    public void HideMenu() {
        StartCoroutine(HideMenuAction());
    }

    private IEnumerator HideMenuAction() {
        backgroundAnimator.Play("HideBackground");
        yield return new WaitForSeconds(anim.length);
        gameObject.SetActive(false);
    }
}
