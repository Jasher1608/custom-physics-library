using Physics2DLibrary.Math;
using UnityEngine;

public static class Assert
{
    public static void AreEqual(float expected, float actual, float tolerance = 1e-6f)
    {
        if (Mathf.Abs(expected - actual) > tolerance)
        {
            Debug.LogError($"Test Failed: Expected {expected}, but got {actual}");
        }
        else
        {
            Debug.Log("Test Passed");
        }
    }

    public static void AreEqual(Vec2 expected, Vec2 actual, float tolerance = 1e-6f)
    {
        if (Mathf.Abs(expected.x - actual.x) > tolerance || Mathf.Abs(expected.y - actual.y) > tolerance)
        {
            Debug.LogError($"Test Failed: Expected ({expected.x}, {expected.y}), but got ({actual.x}, {actual.y})");
        }
        else
        {
            Debug.Log("Test Passed");
        }
    }
}
