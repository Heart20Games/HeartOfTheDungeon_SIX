using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public static class ExtensionMethods
{
    public static bool HasParameter(this Animator _animator, string parameterName)
    {
        foreach (AnimatorControllerParameter param in _animator.parameters)
        {
            if (param.name == parameterName) return true;
        }
        return false;
    }

    public static void SetRotationWithVector(this Transform _transform, Vector2 vector, float rotationOffset=0)
    {
        Vector3 direction = Vector3.forward;
        if (Mathf.Abs(vector.x) > 0.5f || Mathf.Abs(vector.y) > 0.5f)
        {
            direction = Vector3.right * vector.x + Vector3.forward * vector.y;
            Debug.Log("Non-Default: " + direction);
        }
        else
        {
            Debug.Log("Default: " + direction);
        }
        if (direction.sqrMagnitude > 0.0f)
        {
            Quaternion newRotation = Quaternion.LookRotation(direction, Vector3.up);
            _transform.rotation = newRotation;
            _transform.Rotate(0, rotationOffset, 0);
            Vector3 euler = _transform.eulerAngles;
            _transform.eulerAngles = new Vector3(euler.x, euler.y + rotationOffset, euler.z);
        }
    }
}
