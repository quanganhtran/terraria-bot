﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TerBot {
    class Tile {
        public static byte Dirt = 0x00;
        public static byte Stone = 0x01;
        public static byte Grass = 0x02;
        public static byte nWeeds = 0x03;
        public static byte Torches = 0x04;
        public static byte Logs = 0x05;
        public static byte Iron = 0x06;
        public static byte Copper = 0x07;
        public static byte Gold = 0x08;
        public static byte Silver = 0x09;
        public static byte ClosedDoor = 0x0A;
        public static byte OpenDoor = 0x0B;
        public static byte CrystalHeart = 0x0C;
        public static byte Potions = 0x0D;
        public static byte Table = 0x0E;
        public static byte Chair = 0x0F;
        public static byte Anvil = 0x10;
        public static byte Furnace = 0x11;
        public static byte WorkBench = 0x12;
        public static byte Plank = 0x13;
        public static byte Sappling = 0x14;
        public static byte Chest = 0x15;
        public static byte CorruptedStone = 0x16;
        public static byte CorruptedGrass = 0x17;
        public static byte CorruptedWeeds = 0x18;
        public static byte EbonStone = 0x19;
        public static byte DemonAlter = 0x1A;
        public static byte SunFlower = 0x1B;
        public static byte nPot = 0x1C;
        public static byte PiggyBank = 0x1D;
        public static byte Wood = 0x1E;
        public static byte ShadowOrb = 0x1F;
        public static byte CorruptedThorns = 0x20;
        public static byte Candle = 0x21;
        public static byte CopperChandelier = 0x22;
        public static byte SilverChandelier = 0x23;
        public static byte GoldChandelier = 0x24;
        public static byte Meteorite = 0x25;
        public static byte StoneBrick = 0x26;
        public static byte ClayBrick = 0x27;
        public static byte Clay = 0x28;
        public static byte BlueBrick = 0x29;
        public static byte DungeonLight = 0x2A;
        public static byte GreenBrick = 0x2B;
        public static byte RedBrick = 0x2C;
        public static byte GoldBrick = 0x2D;
        public static byte SilverBrick = 0x2E;
        public static byte CopperBrick = 0x2F;
        public static byte Spikes = 0x30;
        public static byte WaterCandle = 0x31;
        public static byte Books = 0x32;
        public static byte CobWebs = 0x33;
        public static byte Vines = 0x34;
        public static byte Sand = 0x35;
        public static byte Glass = 0x36;
        public static byte Sign = 0x37;
        public static byte Obsidian = 0x38;
        public static byte Ash = 0x39;
        public static byte Hellstone = 0x3A;
        public static byte Mud = 0x3B;
        public static byte JungleMud = 0x3C;
        public static byte JungleWeeds = 0x3D;
        public static byte JungleVines = 0x3E;
        public static byte Sapphire = 0x3F;
        public static byte Ruby = 0x40;
        public static byte Emerald = 0x41;
        public static byte Topaz = 0x42;
        public static byte Amethyst = 0x43;
        public static byte Diamond = 0x44;
        public static byte Thorns = 0x45;
        public static byte GlowGrass = 0x46;
        public static byte Mushrooms = 0x47;
        public static byte GiantMushroomStem = 0x48;
        public static byte Weeds = 0x49;
        public static byte JungleFlowers = 0x4A;
        public static byte PurpleBrick = 0x4B;
        public static byte HellstoneBrick = 0x4C;
        public static byte Hellforge = 0x4D;
        public static byte ClayPot = 0x4E;
        public static byte Bed = 0x4F;
        public static byte Cactus = 0x50;
        public static byte Coral = 0x51;
        public static byte HerbSprout = 0x52;
        public static byte HerbStalk = 0x53;
        public static byte Herb = 0x54;
        public static byte Tombstone = 0x55;
        public static byte Loom = 0x56;
        public static byte Piano = 0x57;
        public static byte Dress = 0x58;
        public static byte Bench = 0x59;
        public static byte Bathtub = 0x5A;
        public static byte Banner = 0x5B;
        public static byte LampPost = 0x5C;
        public static byte TikiTorch = 0x5D;
        public static byte Keg = 0x5E;
        public static byte ChineseLantern = 0x5F;
        public static byte Pot = 0x60;
        public static byte Safe = 0x61;
        public static byte SkullLantern = 0x62;
        public static byte TrashCan = 0x63;
        public static byte Candelabra = 0x64;
        public static byte Bookcase = 0x65;
        public static byte Throne = 0x66;
        public static byte Bowl = 0x67;
        public static byte GrandfatherClock = 0x68;
        public static byte Statue = 0x69;
        public static byte Sawmill = 0x6A;
        public static byte Cobalt = 0x6B;
        public static byte Mythril = 0x6C;
        public static byte HallowGrass = 0x6D;
        public static byte HallowFlowers = 0x6E;
        public static byte Adamantite = 0x6F;
        public static byte CorruptionSand = 0x70;
        public static byte HallowWeeds = 0x71;
        public static byte TinkerersWorkshop = 0x72;
        public static byte HallowVines = 0x73;
        public static byte Pearlsand = 0x74;
        public static byte Pearlstone = 0x75;
        public static byte PearlstoneBrick = 0x76;
        public static byte IridescentBrick = 0x77;
        public static byte MudstoneBrick = 0x78;
        public static byte CobaltBrick = 0x79;
        public static byte MythrilBrick = 0x7A;
        public static byte Silt = 0x7B;
        public static byte WoodenBeam = 0x7C;
        public static byte CrystalBall = 0x7D;
        public static byte DiscoBall = 0x7E;
        public static byte Ice = 0x7F;
        public static byte Mannequin = (byte)0x80;
        public static byte CrystalShard = (byte)0x81;
        public static byte ActiveStone = (byte)0x82;
        public static byte InactiveStone = (byte)0x83;
        public static byte Lever = (byte)0x84;
        public static byte AdamantiteForge = (byte)0x85;
        public static byte MythrilAnvil = (byte)0x86;
        public static byte PressurePlate = (byte)0x87;
        public static byte Switch = (byte)0x88;
        public static byte DartTrap = (byte)0x89;
        public static byte Boulder = (byte)0x8A;
        public static byte MusicBox = (byte)0x8B;
        public static byte nPurpleBrick = (byte)0x8C;
        public static byte Explosives = (byte)0x8D;
        public static byte InletPump = (byte)0x8E;
        public static byte OutletPump = (byte)0x8F;
        public static byte Timer = (byte)0x90;
        public static byte RedCandy = (byte)0x91;
        public static byte GreenCandy = (byte)0x92;
        public static byte Snow = (byte)0x93;
        public static byte SnowBrick = (byte)0x94;
        public static byte ChristmasLight = (byte)0x95;
    }
}
