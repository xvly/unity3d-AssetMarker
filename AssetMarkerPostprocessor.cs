using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GStd.Editor.Asset{
	
	class AssetMarkerPostprocessor : AssetPostprocessor
	{
		static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
		{
			foreach (string str in importedAssets)
			{
				// Debug.Log("Reimported Asset: " + str + ",");
				AssetMarkerEditor.ProcessAddMarker(str);
				AssetMarkerEditor.ProcessAsset(str);
			}
			foreach (string str in deletedAssets)
			{
				// Debug.Log("Deleted Asset: " + str);
				AssetMarkerEditor.ProcessDelMarker(str);
			}

			for (int i = 0; i < movedAssets.Length; i++)
			{
				// Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
				AssetMarkerEditor.ProcessDelMarker(movedFromAssetPaths[i]);
				AssetMarkerEditor.ProcessAddMarker(movedAssets[i]);
				AssetMarkerEditor.ProcessAsset(movedAssets[i]);
			}
		}
	}
	
}

