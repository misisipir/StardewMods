﻿// ReSharper disable ClassNeverInstantiated.Global
namespace DynamicDialogues.Models;

///<summary>Conditions for a dialogue to be added.</summary>
internal class PlayerConditions
{
    // null means 'any'
    public string Hat { get; }
    public string Rings { get; }
    public string Shirt { get; }
    public string Pants { get; }
    public string Boots { get; }
    public string Inventory { get; }
    public string GameStateQuery { get; } = "TRUE"; //see https://stardewvalleywiki.com/Modding:Migrate_to_Stardew_Valley_1.6#Game_state_queries 

    public PlayerConditions()
    {

    }

    public PlayerConditions(PlayerConditions p)
    {
        Hat = p.Hat;
        Shirt = p.Shirt;
        Pants = p.Pants;
        Rings = p.Rings;
        Boots = p.Boots;
        Inventory = p.Inventory;
        GameStateQuery = p.GameStateQuery;
    }
}