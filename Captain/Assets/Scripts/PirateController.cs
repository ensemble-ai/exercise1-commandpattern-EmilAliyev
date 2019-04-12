using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

public class PirateController : MonoBehaviour
{
    public IPirateCommand ActiveCommand;
    public GameObject ProductPrefab;
    private const float SLOW_WORK_COEFF = 1.0f;
    private const float NORMAL_WORK_COEFF = 2.0f;
    private const float FAST_WORK_COEFF = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.ActiveCommand = ScriptableObject.CreateInstance<NoWorkPirateCommand>();
    }

    // Update is called once per frame
    void Update()
    {
        var working = this.ActiveCommand.Execute(this.gameObject, this.ProductPrefab);

        this.gameObject.GetComponent<Animator>().SetBool("Exhausted", !working);
    }

    //Has received motivation. A likely source is from on of the Captain's morale inducements.
    public void Motivate()
    {
        //Generate a random value between 0 and 3
        float randWorkCoeff = Random.Range(0, 3);

        //assign a command according to the random value
        if(randWorkCoeff <= SLOW_WORK_COEFF)
        {
            this.ActiveCommand = Object.Instantiate(ScriptableObject.CreateInstance<SlowWorkerPirateCommand>());
        }
        else if (randWorkCoeff <= NORMAL_WORK_COEFF)
        {
            this.ActiveCommand = Object.Instantiate(ScriptableObject.CreateInstance<NormalWorkerPirateCommand>());
        }
        else
        {
            this.ActiveCommand = Object.Instantiate(ScriptableObject.CreateInstance<FastWorkerPirateCommand>());
        }

        this.ActiveCommand = Object.Instantiate(ScriptableObject.CreateInstance<NoWorkPirateCommand>());
    }
}
