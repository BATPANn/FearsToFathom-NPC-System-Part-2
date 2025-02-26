using UnityEngine;
using UnityEngine.AI;

public class F2FNPCSystemAI : MonoBehaviour
{


    NavMeshAgent agent;

    Animator animator;

    public GameObject ObjectToFollow;

    bool ShouldFollowPlayer = false;

    public GameObject[] RandomSpots;

    bool ShouldGoToRandomSpots = true;

    public int RandomSpotNumber = 0;

    // num 1 = rs 1, numb 2 = rs 2, num 3 = rs 3


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        


        agent = GetComponent<NavMeshAgent>();

        animator = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.F))
        {


            ShouldFollowPlayer = true;
            ShouldGoToRandomSpots = false;
            RandomSpotNumber = 0;





        }

        if (Input.GetKeyDown(KeyCode.T))
        {


            ShouldGoToRandomSpots = true;
            ShouldFollowPlayer = false;
            RandomSpotNumber = 2;


        }



        if(ShouldFollowPlayer == true)
        {



            float Distance = Vector3.Distance(transform.position, ObjectToFollow.transform.position);

            if (Distance < 5)
            {

                // IDLE 

                agent.isStopped = true;

                animator.SetInteger("C", 0);


            }
            else if (Distance >= 5 && Distance < 12)
            {


                // Walk

                agent.isStopped = false;

                animator.SetInteger("C", 1);

                agent.speed = 3;

                agent.SetDestination(ObjectToFollow.transform.position);

            }
            else if (Distance >= 12)
            {


                // Run

                agent.isStopped = false;

                animator.SetInteger("C", 2);

                agent.speed = 6;

                agent.SetDestination(ObjectToFollow.transform.position);

            }


        }


        if(ShouldGoToRandomSpots == true)
        {

            if(RandomSpotNumber == 1)
            {


                // ai to go to 1

                float Distance = Vector3.Distance(transform.position, RandomSpots[0].transform.position);

                agent.SetDestination(RandomSpots[0].transform.position);

                if(Distance < 2)
                {


                    agent.isStopped = true;

                    animator.SetInteger("C", 0);


                }
                else if(Distance >= 2 && Distance <= 6)
                {


                    agent.isStopped = false;
                    animator.SetInteger("C", 1);

                    agent.speed = 3;


                }
                else if(Distance > 6)
                {


                    agent.isStopped = false;
                    animator.SetInteger("C", 2);

                    agent.speed = 6;

                }



            }
            else if(RandomSpotNumber == 2)
            {



                // ai to go to 2

                float Distance = Vector3.Distance(transform.position, RandomSpots[1].transform.position);

                agent.SetDestination(RandomSpots[1].transform.position);

                if (Distance < 2)
                {


                    agent.isStopped = true;

                    animator.SetInteger("C", 0);


                }
                else if (Distance >= 2 && Distance <= 6)
                {


                    agent.isStopped = false;
                    animator.SetInteger("C", 1);
                    agent.speed = 3;

                }
                else if (Distance > 6)
                {


                    agent.isStopped = false;
                    animator.SetInteger("C", 2);
                    agent.speed = 6;
                }


            }
            else if(RandomSpotNumber == 3)
            {


                // ai to go to 3

                float Distance = Vector3.Distance(transform.position, RandomSpots[2].transform.position);

                agent.SetDestination(RandomSpots[2].transform.position);

                if (Distance < 2)
                {


                    agent.isStopped = true;

                    animator.SetInteger("C", 0);


                }
                else if (Distance >= 2 && Distance <= 6)
                {


                    agent.isStopped = false;
                    animator.SetInteger("C", 1);
                    agent.speed = 3;

                }
                else if (Distance > 6)
                {


                    agent.isStopped = false;
                    animator.SetInteger("C", 2);
                    agent.speed = 6;
                }




            }




        }





        
    }
}
