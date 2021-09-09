using System;
using System.Collections.Generic;
using UnityEngine;

static public class UnityEngineExtensions
{
    /// <summary>
    /// Returns the component of Type type. If one doesn't already exist on the GameObject it will be added.
    /// </summary>
    /// <typeparam name="T">The type of Component to return.</typeparam>
    /// <param name="gameObject">The GameObject this Component is attached to.</param>
    /// <returns>Component</returns>
    static public T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var componentFound = gameObject.GetComponent<T>();

        return componentFound != null ? componentFound : gameObject.AddComponent<T>();
    }

    public static Material[] AddMaterial(this Material[] materials, Material material)
    {
        if (material == null)
            return materials;

        int materialsLenght = materials.Length;

        Array.Resize(ref materials, materialsLenght + 1);

        materials[materialsLenght] = material;

        return materials;
    }

    public static Material[] RemoveMaterial(this Material[] materials)
    {
        if (materials.Length <= 0)
            return materials;

        Array.Resize(ref materials, materials.Length - 1);

        return materials;
    }
}