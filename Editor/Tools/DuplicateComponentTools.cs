using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class DuplicateComponentTools
{
    const string k_menuPath = "CONTEXT/Component/Duplicate";
    [MenuItem(k_menuPath, priority = 503)]
    public static void DuplicateMenuOption(MenuCommand command)
    {
        Component sourceComponent = command.context as Component;
        Component newComponent = Undo.AddComponent(sourceComponent.gameObject, sourceComponent.GetType());
        SerializedObject source = new SerializedObject(sourceComponent);
        SerializedObject target = new SerializedObject(newComponent);
        SerializedProperty iterator = source.GetIterator();
        while (iterator.NextVisible(true))
            target.CopyFromSerializedProperty(iterator);
        target.ApplyModifiedProperties();

    }



    [MenuItem(k_menuPath, validate = true)]

    public static bool DuplicateMenuOptionValidation(MenuCommand command)
    {
        return DoesComponentAllowsMultiples(command.context as Component);
    }

    static bool DoesComponentAllowsMultiples(Component component)
    {
        System.Type componentType = component.GetType();
        DisallowMultipleComponent[] attributes = (DisallowMultipleComponent[])componentType.GetCustomAttributes(typeof(DisallowMultipleComponent), true);
        return attributes.Length == 0;
    }
}