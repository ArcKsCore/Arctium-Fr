﻿/*
 * Copyright (C) 2012-2013 Arctium <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Framework.Constants
{
    public enum ObjectFields
    {
        Guid                              = 0x0,
        Data                              = 0x2,
        Type                              = 0x4,
        Entry                             = 0x5,
        DynamicFlags                      = 0x6,
        Scale                             = 0x7,
        End                               = 0x8
    };

    public enum DynamicObjectArrays
    {
        // Empty
        End                               = 0x0
    }

    public enum ItemFields
    {
        Owner                             = ObjectFields.End + 0x0,
        ContainedIn                       = ObjectFields.End + 0x2,
        Creator                           = ObjectFields.End + 0x4,
        GiftCreator                       = ObjectFields.End + 0x6,
        StackCount                        = ObjectFields.End + 0x8,
        Expiration                        = ObjectFields.End + 0x9,
        SpellCharges                      = ObjectFields.End + 0xA,
        DynamicFlags                      = ObjectFields.End + 0xF,
        Enchantment                       = ObjectFields.End + 0x10,
        PropertySeed                      = ObjectFields.End + 0x37,
        RandomPropertiesID                = ObjectFields.End + 0x38,
        Durability                        = ObjectFields.End + 0x39,
        MaxDurability                     = ObjectFields.End + 0x3A,
        CreatePlayedTime                  = ObjectFields.End + 0x3B,
        ModifiersMask                     = ObjectFields.End + 0x3C,
        End                               = ObjectFields.End + 0x3D
    };

    public enum ItemDynamicArrays
    {
        // Empty
        End                               = DynamicObjectArrays.End
    }

    public enum ContainerFields
    {
        NumSlots                          = ItemFields.End + 0x0,
        Slots                             = ItemFields.End + 0x1,
        End                               = ItemFields.End + 0x49
    };

    public enum ContainerDynamicArrays
    {
        // Empty
        End                               = ItemDynamicArrays.End
    }

    public enum UnitFields
    {
        Charm                             = ObjectFields.End + 0x0,
        Summon                            = ObjectFields.End + 0x2,
        Critter                           = ObjectFields.End + 0x4,
        CharmedBy                         = ObjectFields.End + 0x6,
        SummonedBy                        = ObjectFields.End + 0x8,
        CreatedBy                         = ObjectFields.End + 0xA,
        Target                            = ObjectFields.End + 0xC,
        BattlePetCompanionGUID            = ObjectFields.End + 0xE,
        ChannelObject                     = ObjectFields.End + 0x10,
        ChannelSpell                      = ObjectFields.End + 0x12,
        SummonedByHomeRealm               = ObjectFields.End + 0x13,
        DisplayPower                      = ObjectFields.End + 0x14,
        OverrideDisplayPowerID            = ObjectFields.End + 0x15,
        Health                            = ObjectFields.End + 0x16,
        Power                             = ObjectFields.End + 0x17,
        MaxHealth                         = ObjectFields.End + 0x1C,
        MaxPower                          = ObjectFields.End + 0x1D,
        PowerRegenFlatModifier            = ObjectFields.End + 0x22,
        PowerRegenInterruptedFlatModifier = ObjectFields.End + 0x27,
        Level                             = ObjectFields.End + 0x2C,
        EffectiveLevel                    = ObjectFields.End + 0x2D,
        FactionTemplate                   = ObjectFields.End + 0x2E,
        VirtualItemID                     = ObjectFields.End + 0x2F,
        Flags                             = ObjectFields.End + 0x32,
        Flags2                            = ObjectFields.End + 0x33,
        AuraState                         = ObjectFields.End + 0x34,
        AttackRoundBaseTime               = ObjectFields.End + 0x35,
        RangedAttackRoundBaseTime         = ObjectFields.End + 0x37,
        BoundingRadius                    = ObjectFields.End + 0x38,
        CombatReach                       = ObjectFields.End + 0x39,
        DisplayID                         = ObjectFields.End + 0x3A,
        NativeDisplayID                   = ObjectFields.End + 0x3B,
        MountDisplayID                    = ObjectFields.End + 0x3C,
        MinDamage                         = ObjectFields.End + 0x3D,
        MaxDamage                         = ObjectFields.End + 0x3E,
        MinOffHandDamage                  = ObjectFields.End + 0x3F,
        MaxOffHandDamage                  = ObjectFields.End + 0x40,
        AnimTier                          = ObjectFields.End + 0x41,
        PetNumber                         = ObjectFields.End + 0x42,
        PetNameTimestamp                  = ObjectFields.End + 0x43,
        PetExperience                     = ObjectFields.End + 0x44,
        PetNextLevelExperience            = ObjectFields.End + 0x45,
        ModCastingSpeed                   = ObjectFields.End + 0x46,
        ModSpellHaste                     = ObjectFields.End + 0x47,
        ModHaste                          = ObjectFields.End + 0x48,
        ModHasteRegen                     = ObjectFields.End + 0x49,
        CreatedBySpell                    = ObjectFields.End + 0x4A,
        NpcFlags                          = ObjectFields.End + 0x4B,
        EmoteState                        = ObjectFields.End + 0x4D,
        Stats                             = ObjectFields.End + 0x4E,
        StatPosBuff                       = ObjectFields.End + 0x53,
        StatNegBuff                       = ObjectFields.End + 0x58,
        Resistances                       = ObjectFields.End + 0x5D,
        ResistanceBuffModsPositive        = ObjectFields.End + 0x64,
        ResistanceBuffModsNegative        = ObjectFields.End + 0x6B,
        BaseMana                          = ObjectFields.End + 0x72,
        BaseHealth                        = ObjectFields.End + 0x73,
        ShapeshiftForm                    = ObjectFields.End + 0x74,
        AttackPower                       = ObjectFields.End + 0x75,
        AttackPowerModPos                 = ObjectFields.End + 0x76,
        AttackPowerModNeg                 = ObjectFields.End + 0x77,
        AttackPowerMultiplier             = ObjectFields.End + 0x78,
        RangedAttackPower                 = ObjectFields.End + 0x79,
        RangedAttackPowerModPos           = ObjectFields.End + 0x7A,
        RangedAttackPowerModNeg           = ObjectFields.End + 0x7B,
        RangedAttackPowerMultiplier       = ObjectFields.End + 0x7C,
        MinRangedDamage                   = ObjectFields.End + 0x7D,
        MaxRangedDamage                   = ObjectFields.End + 0x7E,
        PowerCostModifier                 = ObjectFields.End + 0x7F,
        PowerCostMultiplier               = ObjectFields.End + 0x86,
        MaxHealthModifier                 = ObjectFields.End + 0x8D,
        HoverHeight                       = ObjectFields.End + 0x8E,
        MinItemLevel                      = ObjectFields.End + 0x8F,
        MaxItemLevel                      = ObjectFields.End + 0x90,
        WildBattlePetLevel                = ObjectFields.End + 0x91,
        BattlePetCompanionNameTimestamp   = ObjectFields.End + 0x92,
        End                               = ObjectFields.End + 0x93
    };

    public enum UnitDynamicArrays
    {
        PassiveSpells                     = DynamicObjectArrays.End + 0x0,
        WorldEffects                      = DynamicObjectArrays.End + 0x101,
        End                               = DynamicObjectArrays.End + 0x202
    }

    public enum PlayerFields
    {
        DuelArbiter                   = UnitFields.End + 0x0,
        PlayerFlags                   = UnitFields.End + 0x2,
        GuildRankID                   = UnitFields.End + 0x3,
        GuildDeleteDate               = UnitFields.End + 0x4,
        GuildLevel                    = UnitFields.End + 0x5,
        HairColorID                   = UnitFields.End + 0x6,
        RestState                     = UnitFields.End + 0x7,
        ArenaFaction                  = UnitFields.End + 0x8,
        DuelTeam                      = UnitFields.End + 0x9,
        GuildTimeStamp                = UnitFields.End + 0xA,
        QuestLog                      = UnitFields.End + 0xB,
        VisibleItems                  = UnitFields.End + 0x2F9,
        PlayerTitle                   = UnitFields.End + 0x31F,
        FakeInebriation               = UnitFields.End + 0x320,
        VirtualPlayerRealm            = UnitFields.End + 0x321,
        CurrentSpecID                 = UnitFields.End + 0x322,
        TaxiMountAnimKitID            = UnitFields.End + 0x323,
        CurrentBattlePetBreedQuality  = UnitFields.End + 0x324,
        InvSlots                      = UnitFields.End + 0x325,
        FarsightObject                = UnitFields.End + 0x3D1,
        KnownTitles                   = UnitFields.End + 0x3D3,
        Coinage                       = UnitFields.End + 0x3DB,
        XP                            = UnitFields.End + 0x3DD,
        NextLevelXP                   = UnitFields.End + 0x3DE,
        Skill                         = UnitFields.End + 0x3DF,
        CharacterPoints               = UnitFields.End + 0x59F,
        MaxTalentTiers                = UnitFields.End + 0x5A0,
        TrackCreatureMask             = UnitFields.End + 0x5A1,
        TrackResourceMask             = UnitFields.End + 0x5A2,
        MainhandExpertise             = UnitFields.End + 0x5A3,
        OffhandExpertise              = UnitFields.End + 0x5A4,
        RangedExpertise               = UnitFields.End + 0x5A5,
        CombatRatingExpertise         = UnitFields.End + 0x5A6,
        BlockPercentage               = UnitFields.End + 0x5A7,
        DodgePercentage               = UnitFields.End + 0x5A8,
        ParryPercentage               = UnitFields.End + 0x5A9,
        CritPercentage                = UnitFields.End + 0x5AA,
        RangedCritPercentage          = UnitFields.End + 0x5AB,
        OffhandCritPercentage         = UnitFields.End + 0x5AC,
        SpellCritPercentage           = UnitFields.End + 0x5AD,
        ShieldBlock                   = UnitFields.End + 0x5B4,
        ShieldBlockCritPercentage     = UnitFields.End + 0x5B5,
        Mastery                       = UnitFields.End + 0x5B6,
        PvpPowerDamage                = UnitFields.End + 0x5B7,
        PvpPowerHealing               = UnitFields.End + 0x5B8,
        ExploredZones                 = UnitFields.End + 0x5B9,
        RestStateBonusPool            = UnitFields.End + 0x681,
        ModDamageDonePos              = UnitFields.End + 0x682,
        ModDamageDoneNeg              = UnitFields.End + 0x689,
        ModDamageDonePercent          = UnitFields.End + 0x690,
        ModHealingDonePos             = UnitFields.End + 0x697,
        ModHealingPercent             = UnitFields.End + 0x698,
        ModHealingDonePercent         = UnitFields.End + 0x699,
        ModPeriodicHealingDonePercent = UnitFields.End + 0x69A,
        WeaponDmgMultipliers          = UnitFields.End + 0x69B,
        ModSpellPowerPercent          = UnitFields.End + 0x69E,
        ModResiliencePercent          = UnitFields.End + 0x69F,
        OverrideSpellPowerByAPPercent = UnitFields.End + 0x6A0,
        OverrideAPBySpellPowerPercent = UnitFields.End + 0x6A1,
        ModTargetResistance           = UnitFields.End + 0x6A2,
        ModTargetPhysicalResistance   = UnitFields.End + 0x6A3,
        LifetimeMaxRank               = UnitFields.End + 0x6A4,
        SelfResSpell                  = UnitFields.End + 0x6A5,
        PvpMedals                     = UnitFields.End + 0x6A6,
        BuybackPrice                  = UnitFields.End + 0x6A7,
        BuybackTimestamp              = UnitFields.End + 0x6B3,
        YesterdayHonorableKills       = UnitFields.End + 0x6BF,
        LifetimeHonorableKills        = UnitFields.End + 0x6C0,
        WatchedFactionIndex           = UnitFields.End + 0x6C1,
        CombatRatings                 = UnitFields.End + 0x6C2,
        ArenaTeams                    = UnitFields.End + 0x6DD,
        BattlegroundRating            = UnitFields.End + 0x6F2,
        MaxLevel                      = UnitFields.End + 0x6F3,
        RuneRegen                     = UnitFields.End + 0x6F4,
        NoReagentCostMask             = UnitFields.End + 0x6F8,
        GlyphSlots                    = UnitFields.End + 0x6FC,
        Glyphs                        = UnitFields.End + 0x702,
        GlyphSlotsEnabled             = UnitFields.End + 0x708,
        PetSpellPower                 = UnitFields.End + 0x709,
        Researching                   = UnitFields.End + 0x70A,
        ProfessionSkillLine           = UnitFields.End + 0x712,
        UiHitModifier                 = UnitFields.End + 0x714,
        UiSpellHitModifier            = UnitFields.End + 0x715,
        HomeRealmTimeOffset           = UnitFields.End + 0x716,
        ModRangedHaste                = UnitFields.End + 0x717,
        ModPetHaste                   = UnitFields.End + 0x718,
        SummonedBattlePetGUID         = UnitFields.End + 0x719,
        OverrideSpellsID              = UnitFields.End + 0x71B,
        LfgBonusFactionID             = UnitFields.End + 0x71C,
        LootSpecID                    = UnitFields.End + 0x71D,
        OverrideZonePVPType           = UnitFields.End + 0x71E,
        ItemLevelDelta                = UnitFields.End + 0x71F,
        End                           = UnitFields.End + 0x720
    };

    public enum PlayerDynamicArrays
    {
        ResearchSites                     = UnitDynamicArrays.End + 0x0,
        DailyQuestsCompleted              = UnitDynamicArrays.End + 0x2,
        End                               = UnitDynamicArrays.End + 0x4
    }

    public enum GameObjectFields
    {
        CreatedBy                         = ObjectFields.End + 0x0,
        DisplayID                         = ObjectFields.End + 0x2,
        Flags                             = ObjectFields.End + 0x3,
        ParentRotation                    = ObjectFields.End + 0x4,
        AnimProgress                      = ObjectFields.End + 0x8,
        FactionTemplate                   = ObjectFields.End + 0x9,
        Level                             = ObjectFields.End + 0xA,
        PercentHealth                     = ObjectFields.End + 0xB,
        End                               = ObjectFields.End + 0xC
    };

    public enum GameObjectDynamicArrays
    {
        // One field, unknown
        UnknownField                      = DynamicObjectArrays.End + 0x0,
        End                               = DynamicObjectArrays.End + 0x1
    }

    public enum DynamicObjectFields
    {
        Caster                            = ObjectFields.End + 0x0,
        TypeAndVisualID                   = ObjectFields.End + 0x2,
        SpellId                           = ObjectFields.End + 0x3,
        Radius                            = ObjectFields.End + 0x4,
        CastTime                          = ObjectFields.End + 0x5,
        End                               = ObjectFields.End + 0x6
    };

    public enum DynamicObjectDynamicArrays
    {
        // Empty
        End                               = DynamicObjectArrays.End
    }

    public enum CorpseFields
    {
        Owner                             = ObjectFields.End + 0x0,
        PartyGuid                         = ObjectFields.End + 0x2,
        DisplayId                         = ObjectFields.End + 0x4,
        Items                             = ObjectFields.End + 0x5,
        SkinId                            = ObjectFields.End + 0x18,
        FacialHairStyleId                 = ObjectFields.End + 0x19,
        Flags                             = ObjectFields.End + 0x1A,
        DynamicFlags                      = ObjectFields.End + 0x1B,
        End                               = ObjectFields.End + 0x1C
    };

    public enum CorpseDynamicArrays
    {
        // Empty
        End                               = DynamicObjectArrays.End
    }

    public enum AreaTriggerFields
    {
        Caster                            = ObjectFields.End + 0x0,
        SpellId                           = ObjectFields.End + 0x2,
        SpellVisualId                     = ObjectFields.End + 0x3,
        Duration                          = ObjectFields.End + 0x4,
        End                               = ObjectFields.End + 0x5
    };

    public enum AreaTriggerDynamicArrays
    {
        // Empty
        End                               = DynamicObjectArrays.End
    }

    public enum SceneObjectFields
    {
        ScriptPackageId                   = ObjectFields.End + 0x0,
        RndSeedVal                        = ObjectFields.End + 0x1,
        CreatedBy                         = ObjectFields.End + 0x2,
        End                               = ObjectFields.End + 0x4
    };

    public enum SceneObjectDynamicArrays
    {
        // Empty
        End                               = DynamicObjectArrays.End
    }
}
