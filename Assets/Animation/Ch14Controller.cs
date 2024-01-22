using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ch14Controller : MonoBehaviour
   
{   
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if(Mathf.Abs(horizontal) > 0.1f || Mathf.Abs(vertical) > 0.1f)
        {   
            _animator.SetBool("is_moving", true);
            _animator.SetFloat("horizontal", horizontal);
            _animator.SetFloat("vertical", vertical);
        }
        else
        {
            _animator.SetBool("is_moving", false);
        }
        
    }

    private void OnAnimationIK(int layerIndex)
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1f);
        //_animator.SetIKPositionWeight(AvatarIKGoal.RightHand, target.position);
    }
}
