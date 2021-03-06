﻿using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour {
	public int goldAmountPerClick = 5;
	public Text goldAmountText;

	public int GoldAmount {
		get => PlayerPrefs.GetInt("Gold", 1);
		set 
		{
			PlayerPrefs.SetInt("Gold", value);
			UpdateGoldAmountLabel();
		}
	}

	void UpdateGoldAmountLabel() {
		this.goldAmountText.text = this.GoldAmount.ToString("0 Gold");
	}

	void Start() {
		UpdateGoldAmountLabel();
	}
	
	void Update() {
		if (Input.GetKeyDown(KeyCode.W))
		{
			this.GoldAmount = 0;
			FindObjectOfType<GoldPress>().GoldPressAmount = 0;
		}
		if (Input.GetMouseButtonDown(0)) 
		{
			ProduceGold();
		}
	}

	public void ProduceGold() 
	{
		this.GoldAmount += this.goldAmountPerClick; // this.goldAmount = this.goldAmount + goldAmountPerClick;
	}
}