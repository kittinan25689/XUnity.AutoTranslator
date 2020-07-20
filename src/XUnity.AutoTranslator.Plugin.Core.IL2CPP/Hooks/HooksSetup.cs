﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using XUnity.AutoTranslator.Plugin.Core.Configuration;
using XUnity.AutoTranslator.Plugin.Core.Constants;
using XUnity.AutoTranslator.Plugin.Core.Extensions;
using XUnity.AutoTranslator.Plugin.Core.Hooks.TextMeshPro;
using XUnity.AutoTranslator.Plugin.Core.Hooks.UGUI;
using XUnity.Common.Logging;
using XUnity.Common.Utilities;

namespace XUnity.AutoTranslator.Plugin.Core.Hooks
{
   internal static class HooksSetup
   {
      public static void InstallTextHooks()
      {

         try
         {
            if( Settings.EnableUGUI )
            {
               HookingHelper.PatchAll( UGUIHooks.All, false );
            }
         }
         catch( Exception e )
         {
            XuaLogger.AutoTranslator.Error( e, "An error occurred while setting up hooks for UGUI." );
         }

         try
         {
            if( Settings.EnableTextMeshPro )
            {
               HookingHelper.PatchAll( TextMeshProHooks.All, false );
            }
         }
         catch( Exception e )
         {
            XuaLogger.AutoTranslator.Error( e, "An error occurred while setting up hooks for TextMeshPro." );
         }

         //try
         //{
         //   if( Settings.EnableNGUI )
         //   {
         //      MLHookingHelper.PatchAll( NGUIHooks.All, Settings.ForceMonoModHooks );
         //   }
         //}
         //catch( Exception e )
         //{
         //   XuaLogger.AutoTranslator.Error( e, "An error occurred while setting up hooks for NGUI." );
         //}

         //try
         //{
         //   if( Settings.EnableIMGUI )
         //   {
         //      MLHookingHelper.PatchAll( IMGUIHooks.All, Settings.ForceMonoModHooks );
         //   }
         //}
         //catch( Exception e )
         //{
         //   XuaLogger.AutoTranslator.Error( e, "An error occurred while setting up hooks for IMGUI." );
         //}

         //try
         //{
         //   MLHookingHelper.PatchAll( UtageHooks.All, Settings.ForceMonoModHooks );
         //}
         //catch( Exception e )
         //{
         //   XuaLogger.AutoTranslator.Error( e, "An error occurred while setting up hooks for Utage." );
         //}

         try
         {
            if( Settings.EnableTextMesh )
            {
               HookingHelper.PatchAll( TextMeshHooks.All, false );
            }
         }
         catch( Exception e )
         {
            XuaLogger.AutoTranslator.Error( e, "An error occurred while setting up hooks for TextMesh." );
         }

         //try
         //{
         //   if( Settings.EnableFairyGUI )
         //   {
         //      MLHookingHelper.PatchAll( FairyGUIHooks.All, Settings.ForceMonoModHooks );
         //   }
         //}
         //catch( Exception e )
         //{
         //   XuaLogger.AutoTranslator.Error( e, "An error occurred while setting up hooks for FairyGUI." );
         //}
      }
   }
}
