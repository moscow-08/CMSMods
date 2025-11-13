using HarmonyLib;
using Il2Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WrenchOMatic
{
    [HarmonyPatch(typeof(MountObject), "Update")]
    public class PlayerSkills : MonoBehaviour
    {
    }
}
