﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ComboKeysUtil {
	public static KeyCode ToKeyCode(ComboKeys comboKeys) {
		Dictionary<ComboKeys,KeyCode> conversion = new Dictionary<ComboKeys, KeyCode>() {
			{ComboKeys.I,KeyCode.I},
			{ComboKeys.J,KeyCode.J},
			{ComboKeys.K,KeyCode.K},
			{ComboKeys.L,KeyCode.L}
		};

		return conversion[comboKeys];
	}
}
