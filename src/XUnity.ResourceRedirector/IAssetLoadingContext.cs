﻿using UnityEngine;

namespace XUnity.ResourceRedirector
{
   /// <summary>
   /// The operation context surrounding the AssetLoading hook (synchronous) or the AsyncAssetLoading hook (asynchronous).
   /// </summary>
   public interface IAssetLoadingContext
   {
      /// <summary>
      /// Indicate your work is done and if any other hooks to this asset/resource load should be called.
      /// </summary>
      /// <param name="skipRemainingPrefixes">Indicate if the remaining prefixes should be skipped.</param>
      /// <param name="skipOriginalCall">Indicate if the original call should be skipped. If you set the asset, you likely want to set this to true.</param>
      /// <param name="skipAllPostfixes">Indicate if the postfixes should be skipped.</param>
      void Complete( bool skipRemainingPrefixes = true, bool? skipOriginalCall = true, bool? skipAllPostfixes = true );

      /// <summary>
      /// Disables recursive calls if you make an asset/asset bundle load call
      /// from within your callback. If you want to prevent recursion this should
      /// be called before you load the asset/asset bundle.
      /// </summary>
      void DisableRecursion();

      /// <summary>
      /// Gets the parameters the asset load call was called with.
      /// </summary>
      AssetLoadingParameters Parameters { get; }

      /// <summary>
      /// Gets the AssetBundle associated with the loaded assets.
      /// </summary>
      AssetBundle Bundle { get; }
   }
}