using System.Runtime.Serialization;

namespace RetakesAllocatorCore;

public enum CsTeam : byte
{
    None = 0,
    Spectator = 1,
    Terrorist = 2,
    CounterTerrorist = 3,
}

public enum CsItem
{
    [EnumMember(Value = "item_kevlar")] Kevlar = 1,
    [EnumMember(Value = "item_assaultsuit")] KevlarHelmet = 2,
    [EnumMember(Value = "weapon_taser")] Taser = 31,
    Zeus = Taser,

    [EnumMember(Value = "weapon_knife_t")] DefaultKnifeT = 59,
    KnifeT = DefaultKnifeT,
    [EnumMember(Value = "weapon_knife")] DefaultKnifeCT = 42,
    KnifeCT = DefaultKnifeCT,

    [EnumMember(Value = "weapon_glock")] Glock = 200,
    [EnumMember(Value = "weapon_p250")] P250 = 201,
    [EnumMember(Value = "weapon_cz75a")] CZ = 202,
    [EnumMember(Value = "weapon_elite")] Dualies = 203,
    [EnumMember(Value = "weapon_revolver")] R8 = 204,
    [EnumMember(Value = "weapon_tec9")] Tec9 = 205,
    [EnumMember(Value = "weapon_usp_silencer")] USPS = 206,
    [EnumMember(Value = "weapon_hkp2000")] P2000 = 207,
    [EnumMember(Value = "weapon_fiveseven")] FiveSeven = 208,
    [EnumMember(Value = "weapon_deagle")] Deagle = 209,

    [EnumMember(Value = "weapon_mac10")] Mac10 = 220,
    [EnumMember(Value = "weapon_mp9")] MP9 = 221,
    [EnumMember(Value = "weapon_mp7")] MP7 = 222,
    [EnumMember(Value = "weapon_bizon")] Bizon = 223,
    [EnumMember(Value = "weapon_mp5sd")] MP5 = 224,
    [EnumMember(Value = "weapon_ump45")] UMP45 = 225,
    UMP = UMP45,
    [EnumMember(Value = "weapon_p90")] P90 = 226,

    [EnumMember(Value = "weapon_nova")] Nova = 240,
    [EnumMember(Value = "weapon_xm1014")] XM1014 = 241,
    [EnumMember(Value = "weapon_sawedoff")] SawedOff = 242,
    [EnumMember(Value = "weapon_mag7")] MAG7 = 243,

    [EnumMember(Value = "weapon_scout")] Scout = 260,
    [EnumMember(Value = "weapon_awp")] AWP = 261,
    [EnumMember(Value = "weapon_g3sg1")] AutoSniperT = 262,
    SCAR20 = 263,
    AutoSniperCT = SCAR20,

    [EnumMember(Value = "weapon_famas")] Famas = 280,
    [EnumMember(Value = "weapon_aug")] AUG = 281,
    [EnumMember(Value = "weapon_m4a1")] M4A4 = 282,
    [EnumMember(Value = "weapon_m4a1_silencer")] M4A1S = 283,
    [EnumMember(Value = "weapon_ak47")] AK47 = 284,
    [EnumMember(Value = "weapon_galilar")] Galil = 285,
    [EnumMember(Value = "weapon_sg556")] Krieg = 286,

    [EnumMember(Value = "weapon_m249")] M249 = 300,
    [EnumMember(Value = "weapon_negev")] Negev = 301,

    [EnumMember(Value = "weapon_flashbang")] Flashbang = 500,
    [EnumMember(Value = "weapon_smokegrenade")] Smoke = 501,
    [EnumMember(Value = "weapon_hegrenade")] HE = 502,
    HEGrenade = HE,
    [EnumMember(Value = "weapon_molotov")] Molotov = 503,
    [EnumMember(Value = "weapon_incgrenade")] Incendiary = 504,
    [EnumMember(Value = "weapon_decoy")] Decoy = 505,
}

public static class ChatColors
{
    public const string Green = "";
    public const string Red = "";
    public const string Yellow = "";
    public const string Blue = "";
    public const string Purple = "";
    public const string Orange = "";
    public const string White = "";
    public const string Grey = "";
    public const string LightRed = "";
    public const string LightBlue = "";
    public const string LightPurple = "";
    public const string LightYellow = "";
    public const string DarkRed = "";
    public const string DarkBlue = "";
    public const string BlueGrey = "";
    public const string Olive = "";
    public const string Lime = "";
    public const string Gold = "";
    public const string Silver = "";
    public const string Magenta = "";
}
