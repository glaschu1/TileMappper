﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NewTileMapMenu {

	[MenuItem("GameObject/TileMap")]

	// Use this for initialization
	public static void CreateTileMap(){
		GameObject go = new GameObject("Tile Map");
		go.AddComponent<TileMap> ();
		}
}
