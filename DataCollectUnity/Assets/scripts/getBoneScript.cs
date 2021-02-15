using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform head;
    Animator animator;
    Vector3 tempPos;
    Quaternion leftUpLegRot;
    private Transform cChest, cHips, cLeftUpLeg;
    void Start()
    {

        
        /*head = transform.Find("Head");
        if (head)
        {
            Debug.Log("Found HEAD");
            
        }
        else
        {
            Debug.Log("Can't find head");
        }*/
        print("zombie start");
        //body = Animator.GetBoneTransform(HumanBodyBones.Hips);
        animator = GetComponent<Animator>();

        cChest = animator.GetBoneTransform(HumanBodyBones.Chest);
        cHips = animator.GetBoneTransform(HumanBodyBones.Hips);
        cLeftUpLeg = animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
        //Vector3 cHipsRot = cHips.rotation;
        //Vector3 cHipsPos = cHips.position;
        print("cLeftUpLeg world p======="+ cLeftUpLeg.position);
        print("cLeftUpLeg local p======="+ cLeftUpLeg.localPosition);
        print("cLeftUpLeg local R=======x,y,z" + cLeftUpLeg.localRotation.eulerAngles );
        print("cLeftUpLeg local R=======" + cLeftUpLeg.rotation.eulerAngles);
        Vector3 vleftleg = cLeftUpLeg.TransformPoint(cLeftUpLeg.localPosition);
        print("local position back to world position======="+ vleftleg );

        leftUpLegRot = cLeftUpLeg.rotation;
        print("leftUpLeg rotation: "+leftUpLegRot);
        tempPos = transform.position;

        print("root transition~~~~~~:"+ transform.position);
        Animator[] anis = transform.GetComponents<Animator>();
        for(int i =0; i< anis.Length; i++)
        {
            print("ANIMATOR NAME:  "+anis[i].name+"-----"+ anis[i].runtimeAnimatorController.name+"----"+anis[i].avatar.name);
        }

        foreach( Transform child in transform)
        {
            
            if(child.name == "WorldWar_zombie")
            {
                print("we have:  === "+child.name);
            }
            if (child.name  == "Hips")
            {
                print("child: ---- " + child.name + "----local position"+ child.localPosition);
                print("child: ---- " + child.name + "----world position"+ child.position);
                print("back to : ---" + child.InverseTransformPoint(child.position));
                print("Hips has" + child.childCount + "Children"); 
                if (child.Find("LeftUpLeg"))
                {
                    print("Find leftFoot");
                }
                else
                {
                    print("Not Find leftFoot");
                }

            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        /*tempPos.x += 1f;
        transform.position = tempPos;
        Debug.Log(transform.position.x);*/
        //print("get bones"); 
        cLeftUpLeg = animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
        leftUpLegRot = cLeftUpLeg.rotation;
        //print("Update Hips rotation: ");
        //print(leftUpLegRot);
    }
}
