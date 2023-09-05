﻿using EnchCoreApi.TrProtocol.Attributes;
using Terraria;
using Terraria.DataStructures;

namespace EnchCoreApi.TrProtocol.Models.TileEntities;

public partial class TEHatRack : TileEntity {
    public sealed override TileEntityType EntityType => TileEntityType.TEHatRack;
    public sealed override Point16 Position { get; set; }
    public sealed override int ID { get; set; }

    public BitsByte ItemsSerializableIndicator;

    public BitsByte DyesSerializableIndicator;

    [ConditionArray(nameof(ItemsSerializableIndicator), 0)]
    [ArraySize(2)]
    [InitNullable]
    public ItemData[] Items = new ItemData[2];

    [ConditionArray(nameof(DyesSerializableIndicator), 0)]
    [ArraySize(2)]
    [InitNullable]
    public ItemData[] Dyes = new ItemData[2];
}
