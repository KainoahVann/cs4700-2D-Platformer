using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance { get; private set; }

    [SerializeField] float baselineAmplitude = 1f; // controls the constant shake

    CinemachineBasicMultiChannelPerlin noise;
    float shakeTimer;

    void Awake()
    {
        Instance = this;
        noise = GetComponent<CinemachineBasicMultiChannelPerlin>();

        if (noise != null)
            noise.AmplitudeGain = baselineAmplitude;
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0 && noise != null)
                noise.AmplitudeGain = baselineAmplitude; // return to constant shake
        }
    }

    public void Shake(float intensity = 1f, float duration = 0.2f)
    {
        if (noise == null) return;
        noise.AmplitudeGain = baselineAmplitude + intensity;
        shakeTimer = duration;
    }
}