/****************************************************************************
 * Copyright (c) 2017 liangxie
 * 
 * http://liangxiegame.com
 * https://github.com/liangxiegame/QFramework
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/

namespace QFramework
{
    using UnityEngine;

    /// <summary>
    /// GameObject's Util/This Extension
    /// </summary>
    public static class GameObjectExtension
    {

        public static T Layer<T>(this T selfComponent, string layerName) where T : Component
        {
            selfComponent.gameObject.layer = LayerMask.NameToLayer(layerName);
            return selfComponent;
        }

        public static GameObject Layer(this GameObject selfObj, string layerName)
        {
            selfObj.layer = LayerMask.NameToLayer(layerName);
            return selfObj;
        }

        public static T Layer<T>(this T selfComponent, int layer) where T : Component
        {
            selfComponent.gameObject.layer = layer;
            return selfComponent;
        }

        public static GameObject Layer(this GameObject selfObj, int layer)
        {
            selfObj.layer = layer;
            return selfObj;
        }

        public static T Show<T>(this T selfComponent) where T : Component
        {
            selfComponent.gameObject.Show();
            return selfComponent;
        }

        public static T Hide<T>(this T selfComponent) where T : Component
        {
            selfComponent.gameObject.Hide();
            return selfComponent;
        }

        public static GameObject Show(this GameObject selfObj)
        {
            selfObj.SetActive(true);
            return selfObj;
        }

        public static GameObject Hide(this GameObject selfObj)
        {
            selfObj.SetActive(false);
            return selfObj;
        }

        public static void DestroyGameObjGracefully<T>(this T selfBehaviour) where T : Component
        {
            if (selfBehaviour.IsNotNull() && selfBehaviour.gameObject)
            {
                selfBehaviour.gameObject.DestroySelfGracefully();
            }
        }

        public static void DestroyGameObjAfterDelayGracefully<T>(this T selfBehaviour, float delay) where T : Component
        {
            if (selfBehaviour.IsNotNull() && selfBehaviour.gameObject)
            {
                selfBehaviour.gameObject.DestroyAfterDelay(delay);
            }
        }

        public static void DestroySelfGracefully(this GameObject selfObj)
        {
            if (selfObj.IsNotNull())
            {
                Object.Destroy(selfObj);
            }
        }

        public static void DestroySelfAfterDelayGracefully(this GameObject selfObj, float delay)
        {
            if (selfObj.IsNotNull())
            {
                Object.Destroy(selfObj, delay);
            }
        }
    }
}