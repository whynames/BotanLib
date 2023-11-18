using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AnimationCurveBank", order = 30)]
[AssetPath("CurveBank")]
public class AnimationCurves : ScriptableSingletonAsset<AnimationCurves>
{
    public AnimationCurve enterAnimation;
    public AnimationCurve endAnimation;
    public AnimationCurve disappearAnimation;
    public AnimationCurve FadeAnimation;
    public AnimationCurve loopAnimation;


}
