/*
 * SlimNet - Networking Middleware For Games
 * Copyright (C) 2011-2012 Fredrik Holmstr�m
 * 
 * This notice may not be removed or altered.
 * 
 * This software is provided 'as-is', without any expressed or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software. 
 * 
 * Attribution
 * The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. For any works using this 
 * software, reasonable acknowledgment is required.
 * 
 * Noncommercial
 * You may not use this software for commercial purposes.
 * 
 * Distribution
 * You are not allowed to distribute or make publicly available the software 
 * itself or its source code in original or modified form.
 */

using UnityEngine;
using System.Collections;
using SlimNet.Unity;

public class SlimNetActiveController : SlimNetMonoBehaviour
{
    bool lastState = true;

    void Update()
    {
        if (lastState != !networkActor.IsIdle)
        {
            lastState = !networkActor.IsIdle;

            for (int i = 0; i < transform.childCount; ++i)
            {
                transform.GetChild(i).gameObject.SetActiveRecursively(lastState);
            }
        }
    }
}
