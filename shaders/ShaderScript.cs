using UnityEngine;
using System.Collections;

public class ShaderScript : MonoBehaviour
{
    public Shader shaderNormal;
    public Shader shaderGrey;
    public Shader shaderSparklySmall;
    public Shader shaderSparklyBig;
    public PointLight pointLight;
    public Color mainColor;

    private Color currColor;
    private MeshRenderer renderer;

    // Use this for initialization
    void Start()
    {
        // Add a MeshFilter component to this entity. This essentially comprises of a
        // mesh definition, which in this example is a collection of vertices, colours 
        // and triangles (groups of three vertices). 
       // MeshFilter cubeMesh = this.gameObject.AddComponent<MeshFilter>();
       // cubeMesh.mesh = this.CreateCubeMesh();

        // Add a MeshRenderer component. This component actually renders the mesh that
        // is defined by the MeshFilter component.
        renderer = this.gameObject.GetComponent<MeshRenderer>();
        renderer.material.shader = shaderNormal;
    }

    public void SetUp(ShaderScript shaderScript)
    {
        shaderNormal = shaderScript.shaderNormal;
        shaderGrey = shaderScript.shaderGrey;
        shaderSparklyBig = shaderScript.shaderSparklyBig;
        shaderSparklySmall = shaderScript.shaderSparklySmall;
        mainColor = shaderScript.mainColor;
        pointLight = shaderScript.pointLight;
        grey = shaderScript.grey;

        renderer = this.gameObject.GetComponent<MeshRenderer>();
        setShader_normal();

        ready = true;


    }

    public bool ready = false;
    

    // Called each frame
    void Update()
    {
        if (!ready) return;
        // Get renderer component (in order to pass params to shader)
        MeshRenderer renderer = this.gameObject.GetComponent<MeshRenderer>();

        // Pass updated light positions to shader
        renderer.material.SetColor("_PointLightColor", this.pointLight.color);
        renderer.material.SetVector("_PointLightPosition", this.pointLight.GetWorldPosition());
        renderer.material.SetColor("_mainColor", currColor);


        /*TEST*/
        if (Input.GetKeyDown(KeyCode.S))
        {
            setShader_sparklyBig();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            setShader_grey();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            setShader_normal();
        }

    }

    public Color grey;

    public void setShader_grey()
    {
        currColor = grey;
        renderer.material.shader = shaderGrey;
    }
       
    public void setShader_normal()
    {
        currColor = mainColor;
        renderer.material.shader = shaderNormal;
    }

    public void setShader_sparklySmall()
    {
        currColor = mainColor;
        renderer.material.shader = shaderSparklySmall;
    }

    public void setShader_sparklyBig()
    {
        currColor = mainColor;
        renderer.material.shader = shaderSparklySmall;
    }

        

        
}
