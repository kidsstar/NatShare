﻿/* 
*   NatShare
*   Copyright (c) 2018 Yusuf Olokoba
*/

namespace NatShareU {

	using UnityEngine;

	public interface INatShare {
		bool ShareText (string text, ShareCallback callback);
		bool ShareImage (byte[] pngData, string message, ShareCallback callback);
		bool ShareMedia (string path, string message, ShareCallback callback);
		bool SaveToCameraRoll (byte[] pngData, string album);
        bool SaveToCameraRoll (string path, string album);
        Texture2D GetThumbnail (string videoPath, float time);
	}
}