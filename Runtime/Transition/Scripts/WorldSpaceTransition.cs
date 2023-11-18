using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

using UnityEngine.UI;

namespace BotanLib.Transition
{
    public class WorldSpaceTransition : MonoBehaviour
    {
        // UnityCommon.Pair<MaterialPropertyBlock, Renderer> propertyBlockRenderer;
        [SerializeField]
        Image image;
        // public override float Duration => 0.3f;

        // Start is called before the first frame update

        private void Awake()
        {
            // propertyBlockRenderer = new UnityCommon.Pair<MaterialPropertyBlock, Renderer>(new MaterialPropertyBlock(), GetComponent<Renderer>());
            Setup();
        }

        private void OnEnable()
        {
            WorldSpaceTransitionEvent.Register(Enter, Exit);

        }

        private void OnDisable()
        {

        }
        public void Enter(float duration)
        {
            _ = EnterAsync(duration);
        }
        public void Exit(float duration)
        {
            _ = ExitAsync(duration);
        }
        public async UniTask EnterAsync(float duration)
        {
            float t = 0;

            while (t < 1)
            {
                t += Time.deltaTime;
                image.material.SetFloat("_DissolvePower", AnimationCurves.Instance.disappearAnimation.Evaluate(1 - t));

                // propertyBlockRenderer.Item2.GetPropertyBlock(propertyBlockRenderer.Item1);
                // propertyBlockRenderer.Item1.SetFloat("_DissolvePower", AnimationCurves.Instance.disappearAnimation.Evaluate(1 - t));
                // propertyBlockRenderer.Item2.SetPropertyBlock(propertyBlockRenderer.Item1);
                await UniTask.NextFrame();
            }
            gameObject.SetActive(false);

            await UniTask.Yield();
        }

        public async UniTask ExitAsync(float duration)
        {
            float t = 0;
            gameObject.SetActive(true);

            while (t < 1)
            {
                t += Time.deltaTime;
                image.material.SetFloat("_DissolvePower", AnimationCurves.Instance.disappearAnimation.Evaluate(t));

                // propertyBlockRenderer.Item2.GetPropertyBlock(propertyBlockRenderer.Item1);
                // propertyBlockRenderer.Item1.SetFloat("_DissolvePower", AnimationCurves.Instance.disappearAnimation.Evaluate(t));
                // propertyBlockRenderer.Item2.SetPropertyBlock(propertyBlockRenderer.Item1);
                await UniTask.NextFrame();
            }
            await UniTask.Yield();

        }

        public void Setup()
        {
            image.material.SetFloat("_DissolvePower", 1);

        }
        // public void DeActivate()
        // {
        //     image.material.SetFloat("_DissolvePower", 0);

        // }

        // public override void SetTime(float time)
        // {
        //     image.material.SetFloat("_DissolvePower", AnimationCurves.Instance.disappearAnimation.Evaluate(time * 2));
        //     // propertyBlockRenderer.Item2.GetPropertyBlock(propertyBlockRenderer.Item1);
        //     // propertyBlockRenderer.Item1.SetFloat("_DissolvePower", AnimationCurves.Instance.disappearAnimation.Evaluate(time));
        //     // propertyBlockRenderer.Item2.SetPropertyBlock(propertyBlockRenderer.Item1);
        // }

        private void OnApplicationQuit()
        {
            image.material.SetFloat("_DissolvePower", AnimationCurves.Instance.disappearAnimation.Evaluate(0));

        }
    }

    public struct WorldSpaceTransitionEvent
    {
        static public event Delegate FadeIn;
        static public event Delegate FadeOut;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)] private static void RuntimeInitialization() { FadeIn = null; }
        static public void Register(Delegate FadeIn, Delegate FadeOut) { WorldSpaceTransitionEvent.FadeIn += FadeIn; WorldSpaceTransitionEvent.FadeOut += FadeOut; }
        static public void Unregister(Delegate FadeIn, Delegate FadeOut) { WorldSpaceTransitionEvent.FadeIn -= FadeIn; WorldSpaceTransitionEvent.FadeOut -= FadeOut; }

        public delegate void Delegate(float duration);

        static public void TriggerEnter(float duration)
        {
            FadeIn?.Invoke(duration);
        }
        static public void TriggerExit(float duration)
        {
            FadeOut?.Invoke(duration);
        }
    }
}