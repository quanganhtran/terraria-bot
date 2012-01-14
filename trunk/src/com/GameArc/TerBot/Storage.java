package com.GameArc.TerBot;

public class Storage {
	static byte PlayerID;
	static byte[] CharacterData = new byte[]{0x1D, 0x00, 0x00, 0x00, 0x04, Storage.PlayerID, 0x00, 0x01, (byte) 0xD7, 0x5A, 0x4B, (byte) 0xFF, (byte) 0x80, 0x37, 0x69, 0x5A, 0x5A, (byte) 0xAF, (byte) 0xA5, (byte) 0x8C, (byte) 0xA0, (byte) 0xB4, (byte) 0xD7, (byte) 0xFF, (byte) 0xE6, (byte) 0xAF, (byte) 0xA0, 0x69, 0x3C, 0x00, 0x42, 0x6f, 0x74};
	static byte[] Health = new byte[]{0x04, 0x00, 0x00, 0x00, 0x10, PlayerID, 0x64, 0x64};
	static byte[] Mana = new byte[]{0x04, 0x00, 0x00, 0x00, 0x2A, PlayerID, 0x32, 0x32};
	static byte[] Buff = new byte[]{0x0D, 0x00, 0x00, 0x00, 0x32, PlayerID, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};	
}