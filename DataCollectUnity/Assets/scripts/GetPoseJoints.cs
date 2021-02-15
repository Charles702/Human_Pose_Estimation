using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoseJoints : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform leftUpLeg, leftLowerLeg, leftFoot, leftToes;
    public Transform rightUpleg, rightLowerLeg, rightFoot, rightToes;
    public Transform hips,spine, chest, neck, Head, jaw;
    public Transform leftShoulder, leftArm, leftForeArm, leftHand, leftHandindex1, LeftHandMiddle1, leftHandPinky1,
    leftHandRing1, leftHandThumb1;
    public Transform  rightShoulder, rightArm, rightForeArm, rightHand, rightHandindex1, rightHandMiddle1, rightHandPinky1,
    rightHandRing1, rightHandThumb1;

    Animator animator;

    Camera cam;
    void Start()
    {
        //cam = GetComponent<Camera>();

        //Get world posistion of each bone
        animator = GetComponent<Animator>();
        chest = animator.GetBoneTransform(HumanBodyBones.Chest);
        print("Chest world position======="+ chest.position);
        
        // local position of each bone. 
        print("Chest local position======="+ chest.localPosition);

        // Get relative postion to origin (set Hips as origin )

        //Get 2D position from world space to camera screen
        Vector3 screenPos = cam.WorldToScreenPoint(chest.position);
        Debug.Log("Chest is "  + screenPos.x + "pixels from the left");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
