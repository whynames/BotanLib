/*
 * Copyright (C) 2017-2020. Autumn Beauchesne. All rights reserved.
 * Author:  Autumn Beauchesne
 * Date:    30 Sept 2019
 * 
 * File:    TriggerListener2D.cs
 * Purpose: Dispatches callbacks for OnTriggerEnter2D and OnTriggerExit2D messages.
 */

namespace BeauUtil
{
    using UnityEngine;
    using BeauUtil;


    public class Dancer : MonoBehaviour
    {
        [Required(ComponentLookupDirection.Children)]
        [SerializeField]
        TriggerListener2D triggerListener2D;

        [Required(ComponentLookupDirection.Self)]
        [SerializeField]
        ColorGroup colorGroup;

        private void Start()
        {
            Debug.Log(colorGroup);
            Debug.Log(triggerListener2D);

        }
    }
}/*
 * Copyright (C) 2017-2020. Autumn Beauchesne. All rights reserved.
 * Author:  Autumn Beauchesne
 * Date:    30 Sept 2019
 * 
 * File:    TriggerListener2D.cs
 * Purpose: Dispatches callbacks for OnTriggerEnter2D and OnTriggerExit2D messages.
 */
