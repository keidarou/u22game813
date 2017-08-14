using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botanmanager : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    public GameObject leftbutton, rightbutton, camer;

    void Start()
    {
        animator = camer.GetComponent<Animator>();
    }

    public int muki = 0;
    public void leftchange()
    {
        if (muki == 0)
        {
            leftbutton.SetActive(false);
            animator.SetTrigger("centertolefttrigger");
            animator.SetInteger("where", 1);
        }
        if (muki == 1)
        {
            rightbutton.SetActive(true);
            animator.SetTrigger("righttocentertrigger");
            animator.SetInteger("where", 4);
        }
        muki--;
    }
    public void rightchange()
    {
        if (muki == 0)
        {
            rightbutton.SetActive(false);
            animator.SetTrigger("centertorighttrigger");
            animator.SetInteger("where", 3);
        }
        if (muki == -1)
        {
            leftbutton.SetActive(true);
            animator.SetTrigger("lefttocentertrigger");
            animator.SetInteger("where", 2);
        }
        muki++;
    }
    public void mannnakabutton()
    {
        if (muki == 0)
        {
            SceneManager.LoadScene("StageSelect");
        }
         if (muki == -1)
         {
             SceneManager.LoadScene("automaticselectlevel");
         }
    }


}
