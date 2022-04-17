using UnityEngine;
using UnityEngine.UI;

namespace Uli.Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Copies position, scale and rotation from another Transform
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="copyFrom"></param>
        public static void CopyValuesFrom(this Transform trans, Transform copyFrom)
        {
            trans.position = copyFrom.position;
            trans.rotation = copyFrom.rotation;
            trans.localScale = copyFrom.localScale;
        }
        /// <summary>
        /// Copies all values from one RectTransform to another
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="copyFrom"></param>
        public static void CopyValuesFrom(this RectTransform trans, RectTransform copyFrom)
        {
            trans.position = copyFrom.position;

            trans.anchorMax = copyFrom.anchorMax;
            trans.anchorMin = copyFrom.anchorMin;
            trans.offsetMax = copyFrom.offsetMax;
            trans.offsetMin = copyFrom.offsetMin;
            trans.pivot = copyFrom.pivot;
            trans.anchoredPosition3D = copyFrom.anchoredPosition3D;
            trans.sizeDelta = copyFrom.sizeDelta;

            trans.rotation = copyFrom.rotation;
            trans.localScale = copyFrom.localScale;
        }
        /// <summary>
        /// Copies all values from a Canvas to another
        /// </summary>
        /// <param name=""></param>
        /// <param name="copyFrom"></param>
        public static void CopyValuesFrom(this Canvas comp, Canvas copyFrom)
        {
            comp.renderMode = copyFrom.renderMode;
            comp.pixelPerfect = copyFrom.pixelPerfect;
            comp.targetDisplay = copyFrom.targetDisplay;
            comp.worldCamera = copyFrom.worldCamera;
            comp.planeDistance = copyFrom.planeDistance;
            comp.sortingOrder = copyFrom.sortingOrder;
            comp.sortingLayerID = copyFrom.sortingLayerID;
        }
        /// <summary>
        /// Copies all values from a CanvasScaler to another
        /// </summary>
        /// <param name="comp"></param>
        /// <param name="copyFrom"></param>
        public static void CopyValuesFrom(this CanvasScaler comp, CanvasScaler copyFrom)
        {
            comp.defaultSpriteDPI = copyFrom.defaultSpriteDPI;
            comp.dynamicPixelsPerUnit = copyFrom.dynamicPixelsPerUnit;
            comp.fallbackScreenDPI = copyFrom.fallbackScreenDPI;
            comp.matchWidthOrHeight = copyFrom.matchWidthOrHeight;
            comp.physicalUnit = copyFrom.physicalUnit;
            comp.referencePixelsPerUnit = copyFrom.referencePixelsPerUnit;
            comp.referenceResolution = copyFrom.referenceResolution;
            comp.scaleFactor = copyFrom.scaleFactor;
            comp.screenMatchMode = copyFrom.screenMatchMode;
            comp.uiScaleMode = copyFrom.uiScaleMode;
        }
        /// <summary>
        /// Copies all values from a GraphicRaycaster to another
        /// </summary>
        /// <param name="comp"></param>
        /// <param name="copyFrom"></param>
        public static void CopyValuesFrom(this GraphicRaycaster comp, GraphicRaycaster copyFrom)
        {
            comp.blockingObjects = copyFrom.blockingObjects;
            comp.ignoreReversedGraphics = copyFrom.ignoreReversedGraphics;
        }
        /// <summary>
        /// Copies all values from a LayoutElement to another
        /// </summary>
        /// <param name="comp"></param>
        /// <param name="copyFrom"></param>
        public static void CopyValuesFrom(this LayoutElement comp, LayoutElement copyFrom)
        {
            comp.flexibleHeight = copyFrom.flexibleHeight;
            comp.flexibleWidth = copyFrom.flexibleWidth;
            comp.ignoreLayout = copyFrom.ignoreLayout;
            comp.minHeight = copyFrom.minHeight;
            comp.minWidth = copyFrom.minWidth;
            comp.preferredHeight = copyFrom.preferredHeight;
            comp.preferredWidth = copyFrom.preferredWidth;
        }
        /// <summary>
        /// Set the object and all his children to target layer
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="layer"></param>
        public static void SetLayerRecursively(this Transform parent, int layer)
        {
            parent.gameObject.layer = layer;

            for (int i = 0, count = parent.childCount; i < count; i++)
            {
                parent.GetChild(i).SetLayerRecursively(layer);
            }
        }
    }
}