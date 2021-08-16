using UnityEngine;

public class Lightning : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private Texture[] textures;
    [SerializeField] private int fps = 30;
    [SerializeField] private Transform from;
    [SerializeField] private Transform to;
    
    private int _animationStep;
    private float _fpsCounter;
    private static readonly int ShaderMainTex = Shader.PropertyToID("_MainTex");

    private void Start()
    {
        lineRenderer.positionCount = 2;
    }

    private void Update()
    {
        _fpsCounter += Time.deltaTime;
        if (_fpsCounter >= 1f / fps)
        {
            _animationStep++;
            if (_animationStep >= textures.Length) _animationStep = 0;
            
            lineRenderer.material.SetTexture(ShaderMainTex, textures[_animationStep]);

            _fpsCounter = 0;
        }
        
        if(from != null) lineRenderer.SetPosition(0, from.position);
        if(to != null) lineRenderer.SetPosition(1, to.position);
    }
}
