using UnityEngine;

[CreateAssetMenu(fileName = "ShaderGlobalSettings", menuName = "Shader/ShaderGlobalSettings")]
public class ShadersGlobalSettings : ScriptableObject
{
    public static ShadersGlobalSettings Instance { get; set; }

    public void Awake()
    {
        Singleton();
        UpdateShadersValue();
    }

    public void Singleton()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void OnValidate()
    {
        UpdateShadersValue();
    }
    
    public void UpdateShadersValue()
    {
        //Shader.SetGlobalFloat("Min", min);
    }
}
