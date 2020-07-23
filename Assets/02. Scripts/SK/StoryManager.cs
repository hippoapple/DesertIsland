using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class StoryManager : MonoBehaviour
{
    public GameObject StoryCanvas;
    // private int LayerUI;
    public static int clickCount = -1;
    List<string> hints;
    public TextMeshProUGUI hintText;

    public static int timer;
    public  AudioClip[] Diralog;
    AudioSource Dialog_Source;
    //public static List <int>  timeArry;

    void Start()
    {
        // LayerUI = 1 << LayerMask.NameToLayer("UI");
        hints = new List<string>();
        //timeArry = new List<int>();
        hintText = GameObject.Find("HintText").GetComponent<TextMeshProUGUI>();
        SetScript();
        Dialog_Source = GetComponent<AudioSource>();

    }
    void Update()
    {


    }

    public void ChangeStory()
    {

        print("clickCount" + clickCount);

        switch (clickCount)
        {
            case 0:
                hintText.text = hints[clickCount];
                // Dialog_Source.clip = Diralog[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                print("으윽?");
                break;

            case 1:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;

            case 2:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);

                break;

            case 3:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;

            case 4:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;

            case 5:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;

            case 6:
                hintText.text = hints[clickCount];
                StoryCanvas.SetActive(false);
                StartCoroutine(Timer());


                break;



            // 나뭇가지 모으고 난 후 
            case 7:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                print("스토리 2");
                break;

            case 8:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;

            case 9:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);

                StartCoroutine(Timer());
                break;

            case 10:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;


            case 11:
                hintText.text = hints[clickCount];
                StoryCanvas.SetActive(false);

                //timer =0;
                break;

            //화덕에 불이 붙고난후 
            case 12:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                print("스토리 3");
                break;
            case 13:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;
            case 14:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;
            case 15:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;
            case 16:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;
            case 17:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;
            case 18:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;
            case 19:
                hintText.text = hints[clickCount];
                StoryCanvas.SetActive(false);
                print("스토리 3 사라져");
                StartCoroutine(Timer());
                //timer =0;
                break;

            //통에 물을 담고 난후 
            case 20:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                print("스토리 4");
                break;

            case 21:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                StoryCanvas.SetActive(false);
                print("스토리 4 사라져");
                StartCoroutine(Timer());
                // timer =0;
                break;

            //물을 먹고 난후  
            case 22:
                hintText.text = hints[clickCount];
                print("스토리 5");
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                break;
            case 23:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                break;
            case 24:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                break;
            case 25:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                break;
            case 26:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                break;
            case 27:
                hintText.text = hints[clickCount];
                StoryCanvas.SetActive(false);
                print("스토리 5 사라져");
                StartCoroutine(Timer());
                //timer =0;
                break;

            //깃발을 터치한후 
            case 28:
                hintText.text = hints[clickCount];
                print("스토리 6");
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                break;
            case 29:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]); 
                break;
            case 30:
                hintText.text = hints[clickCount];
                Dialog_Source.PlayOneShot(Diralog[clickCount]);
                break;
            case 31:
                hintText.text = hints[clickCount];
                StoryCanvas.SetActive(false);
                print("스토리 6 사라져");

                StartCoroutine(Timer());
                // timer =0;
                break;
        }


    }



    public void SetScript()
    {
        hints.Add("여기가 어디지...?");    //0
        hints.Add("섬인것 같은데...");//1
        hints.Add("그건 그렇고.. 너무 추운걸?");//2
        hints.Add("먼저 저기 화덕에 불을 피워야겠다.");//3
        hints.Add("나무가 필요하겠지?");//4
        hints.Add("Mission 1\n <불을 피우자!!> ");//5
        hints.Add("");//6
        ///화덕이 만들어졌음(나무 3개 모음)

        hints.Add("흐음...");//7
        hints.Add("불을 어떻게 피우지?");//
        hints.Add("여긴 섬이라 가스레인지가 없어서\n불이 없을텐데..");//9
        hints.Add("주위를 살펴보자");//10
        hints.Add("");//11


        //화덕에 불이 붙음
        hints.Add("와아 불이 붙었다.");//12
        hints.Add("따뜻해서 더이상 체온이\n떨어지지 않아");//13        
        hints.Add("이제 목이 좀 마른데..");//14        
        hints.Add("바닷물은 마시면\n안된다고 배웠는데!");//15        
        hints.Add("물을 어떻게 구하지"); //16   
        hints.Add("일단 물을 담을 통을 구해보자");//17        
        hints.Add("Mission 2\n<마실수 있는 물을 만들어 보자!!> ");//18
        hints.Add("");//19

        //통에 물을 담았다.
        hints.Add("바닷물을 어떻게 마실수\n있는 물로 만들지..?");//20    
        hints.Add("");//21    


        //물을 먹고 난후     
        hints.Add("캬아~ 시원하다... 너무 좋은 걸?\n그런데 이렇게 계속 살수는 없지");//22        
        hints.Add("섬에서 나갈 준비를 해야겠어!");//23        
        hints.Add("섬을 조사해보자");//24        
        hints.Add("분명 쓰레기가 있는 걸 보니\n사람이 있었을꺼야");//25  
        hints.Add("Mission 3\n <섬에서 탈출하자!> ");//26
        hints.Add(" ");//27


        //깃발을 터치한후 
        hints.Add("어라 해골과 SO..가 보인다! ");//28
        hints.Add("SOS 구조요청을 하려던\n흔적인가..? ");//29
        hints.Add("SOS를 완성해보자 ");//30
        hints.Add(" ");//31

    }


    public static IEnumerator Timer()
    {
        for (int i = 0; i < 500; i++)
        {
            yield return new WaitForSeconds(1f);
            timer = i;
            print(timer);
            //timeArry.Add(i);
            // print ("i = " + i ) ;

        }
    }
}
