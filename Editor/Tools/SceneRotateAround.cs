using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class SceneRotateAround : MonoBehaviour
{
    static bool m_snap = false;

    static SceneRotateAround()
    {
        SceneView.duringSceneGui += OnSceneViewDuringSceneGui;
    }

    private static void OnSceneViewDuringSceneGui(SceneView sceneView)
    {
        Event e = Event.current;
        if (e == null || !e.isMouse)
            return;
        if (e.alt && e.shift && e.button == 0 && e.type == EventType.MouseDrag)
        {
            if (!m_snap)
            {
                m_snap = true;
                Vector3 rotation = sceneView.rotation.eulerAngles;
                rotation.x = Mathf.Round(rotation.x / 90f) * 90f;
                rotation.y = Mathf.Round(rotation.y / 90f) * 90f;
                rotation.z = Mathf.Round(rotation.z / 90f) * 90f;
                if (Mathf.Approximately(Quaternion.Angle(sceneView.rotation, Quaternion.Euler(rotation)), 0f))
                {
                    if (Mathf.Abs(e.delta.x) > Mathf.Abs(e.delta.y))
                    {
                        sceneView.rotation *= Quaternion.Euler(0f, e.delta.x < 0f ? -90f : 90f, 0f);
                    }
                    else
                    {
                        sceneView.rotation *= Quaternion.Euler(e.delta.y < 0f ? -90f : 90f, 0f, 0f);
                    }
                    if (rotation.x != 0f || rotation.z != 0f)
                    {
                        Vector3 forward = sceneView.rotation * Vector3.forward;
                        sceneView.rotation = Quaternion.LookRotation(forward, Vector3.up);
                    }
                }
                else
                {

                    sceneView.rotation = Quaternion.Euler(rotation);
                }
            }
            e.Use();
        }
        else if (m_snap)
        {
            m_snap = false;
        }
    }
}
