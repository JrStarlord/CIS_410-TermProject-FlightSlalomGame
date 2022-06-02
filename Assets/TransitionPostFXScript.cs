using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TransitionPostFXScript : MonoBehaviour
{
    public PostProcessVolume volume;

    private Bloom bloom;
    private ChromaticAberration chromatic;
    private LensDistortion distortion;
    private float time;


    void Start()
    {
        volume.profile.TryGetSettings(out bloom);
        volume.profile.TryGetSettings(out chromatic);
        volume.profile.TryGetSettings(out distortion);

        //bloom.intensity.value = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        chromatic.intensity.value = Mathf.Lerp(0, 1, time / 5);
        bloom.intensity.value = Mathf.Lerp(0, 30, time / 5);
        distortion.intensity.value = Mathf.Lerp(0, -100, time / 5);
        time += Time.deltaTime;
        //print(bloom.intensity.value);
    }
}
