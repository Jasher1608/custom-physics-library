using UnityEngine;
using Physics2DLibrary.Math;

public class Vec2Tests : MonoBehaviour
{
    void Start()
    {
        RunTests();
    }

    void RunTests()
    {
        ConstructorTest();
        MagnitudeTest();
        SqrMagnitudeTest();
        NormalizeTest();
        DotTest();
        CrossTest();
        AngleBetweenTest();
    }

    void ConstructorTest()
    {
        Debug.Log("Running ConstructorTest...");
        Vec2 v = new Vec2(3, 4);
        Assert.AreEqual(new Vec2(3, 4), v);
    }

    void MagnitudeTest()
    {
        Debug.Log("Running MagnitudeTest...");
        Vec2 v = new Vec2(3, 4);
        float expectedMagnitude = 5f; // sqrt(3^2 + 4^2) = 5
        Assert.AreEqual(expectedMagnitude, v.Magnitude());
    }

    void SqrMagnitudeTest()
    {
        Debug.Log("Running SqrMagnitudeTest...");
        Vec2 v = new Vec2(3, 4);
        float expectedSqrMagnitude = 25f; // 3^2 + 4^2 = 9 + 16 = 25
        Assert.AreEqual(expectedSqrMagnitude, v.SqrMagnitude());
    }

    void NormalizeTest()
    {
        Debug.Log("Running NormalizeTest...");
        Vec2 v = new Vec2(3, 4);
        Vec2 expectedNormalized = new Vec2(3 / 5f, 4 / 5f); // Normalizing (3, 4)
        Assert.AreEqual(expectedNormalized, v.Normalize());
    }

    void DotTest()
    {
        Debug.Log("Running DotTest...");
        Vec2 v1 = new Vec2(1, 0);
        Vec2 v2 = new Vec2(0, 1);
        float expectedDot = 0f; // Dot product of orthogonal vectors is 0
        Assert.AreEqual(expectedDot, Vec2.Dot(v1, v2));
    }

    void CrossTest()
    {
        Debug.Log("Running CrossTest...");
        Vec2 v1 = new Vec2(1, 0);
        Vec2 v2 = new Vec2(0, 1);
        float expectedCross = 1f; // Cross product of (1,0) and (0,1) is 1
        Assert.AreEqual(expectedCross, Vec2.Cross(v1, v2));
    }

    void AngleBetweenTest()
    {
        Debug.Log("Running AngleBetweenTest...");
        Vec2 v1 = new Vec2(1, 0);
        Vec2 v2 = new Vec2(0, 1);
        float expectedAngle = Mathf.PI / 2; // Angle between (1,0) and (0,1) is 90 degrees or PI/2 radians
        Assert.AreEqual(expectedAngle, Vec2.AngleBetween(v1, v2));
    }
}
