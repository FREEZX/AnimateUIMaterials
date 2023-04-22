﻿using UnityEditor;
using UnityEngine;

namespace Plugins.Animate_UI_Materials
{
  using PropertyType = ShaderUtil.ShaderPropertyType;

  /// <summary>
  ///   Used in with GraphicMaterialOverride to modify a material without creating a variant
  ///   Added to a child of the Graphic element
  ///   This variant only applies to Range properties
  /// </summary>
  public class GraphicPropertyOverrideRange : GraphicPropertyOverride<float>
  {
    /// <summary>
    ///   Returns the allowed property type in the argument selector dropdown
    /// </summary>
    /// <returns></returns>
    public override PropertyType GetPropertyType()
    {
      return PropertyType.Range;
    }

    /// <summary>
    ///   Apply the modified property to the material
    /// </summary>
    /// <param name="material"></param>
    public override void ApplyModifiedProperty(Material material)
    {
      material.SetFloat(PropertyId, propertyValue);
    }
  }
}