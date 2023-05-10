﻿using StardewModdingAPI;
using StardewValley;
using System;

namespace DynamicDialogues
{

    /// <summary>
    /// A class used for Dialogues with special commands (e.g jump, emote etc).
    /// </summary>
    internal class RawDialogues
    {
        public int Time { get; set; } = -1;  //time to add dialogue at, mut. exclusive w/ from-to
        public int From { get; set; } = 600; //from this hour
        public int To { get; set; } = 2600; //until this hour
        public string Location { get; set; } = "any";  //location npc has to be in

        public string Dialogue { get; set; } = null;  //the dialogue
        public bool ClearOnMove { get; set; } = false;  //if to clear dialogue on move
        public bool Override { get; set; } = false;  //if to delete previous dialogues
        public bool Immediate { get; set; } = false;  // will print dialogue right away if NPC is in location
        public bool Force { get; set; } = false;  // if Immediate, prints dialogue regardless of location
        //public bool ApplyWhenMoving { get; set; } = false;

        public bool IsBubble { get; set; } = false; //showtextoverhead instead
        
        public string FaceDirection { get; set; } //string to change facing to
        public bool Jump { get; set; } = false; //makes npc jump when addition is placed
        public int Shake { get; set; } = -1; //shake for x milliseconds
        public int Emote { get; set; } = -1; //emote int (if allowed)

        public RawAnimation Animation { get; set; } = new RawAnimation(); //animation to play, if any

        public PlayerItems { get; set; } = new PlayerItems();

        public RawDialogues()
        {
        }

        public RawDialogues(RawDialogues md)
        {
            Time = md.Time;
            From = md.From;
            To = md.To;
            PlayerItems = md.PlayerItems;

            Location = md.Location;

            Dialogue = md.Dialogue;
            ClearOnMove = md.ClearOnMove;
            Override = md.Override;

            IsBubble = md.IsBubble;
            Jump = md.Jump;
            Shake = md.Shake;
            Emote = md.Emote;
            FaceDirection = md.FaceDirection;

            Animation = md.Animation;
        }
    }
    
    ///<summary>Notifications sent to game HUD.</summary>
    internal class RawNotifs
    {
        public int Time { get; set; } = -1; //time to show at
        public string Location  { get; set; } = "any"; //the location to show at
        public string Message { get; set; } //msg to display
        public string Sound { get; set; } //sound to make
        //(Maybe?) string Icon { get; set; } = "; //icon
        //public int FadeOut { get; set; } = -1; //fadeout is auto set by game
        
        public bool IsBox { get; set; } = false; //if box instead
        public PlayerItems { get; set; } = new PlayerItems();

        public RawNotifs()
        {
        }

        public RawNotifs(RawNotifs rn)
        {
            Time = rn.Time;
            Location = rn.Location;
            PlayerItems = rn.PlayerItems;

            Message = rn.Message;
            Sound = rn.Sound;

            IsBox = rn.IsBox;
        }
    }

    ///<summary>Questions added by player, which might lead to events or quests.</summary>
    internal class RawQuestions
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int MaxTimesAsked { get; set; } = 0; //0 meaning forever avaiable
        public string Location { get; set; } = "any"; //if avaiable only in a specific location
        public int From { get; set; } = 610; //from this hour
        public int To { get; set; } = 2550; //until this hour
        //
        public string EventToStart { get; set; } = "none";
        public string QuestToStart { get; set; } = "none";
        public bool CanRepeatEvent { get; set; } = false;
        
        public PlayerItems { get; set; } = new PlayerItems();

        public RawQuestions()
        {
        }

        public RawQuestions(RawQuestions q)
        {
            Question = q.Question;
            Answer = q.Answer;

            MaxTimesAsked = q.MaxTimesAsked;
            Location = q.Location;
            PlayerItems = q.PlayerItems;
            
            From = q.From;
            To = q.To;

            EventToStart = q.EventToStart;
            QuestToStart = q.QuestToStart;
            CanRepeatEvent = q.CanRepeatEvent;
        }
    }

    ///<summary>Class which holds animation information (if used for dialogues).</summary>
    internal class RawAnimation
    {
        public bool Enabled { get; set; } = false;
        public string Frames { get; set; }
        public int Interval { get; set; } // milliseconds for each frame

        public RawAnimation()
        {
        }

        public RawAnimation(RawAnimation a)
        {
            Enabled = a.Enabled;
            Frames = a.Frames;
            Interval = a.Interval;
        }
    }

    ///<summary>Conditions for a dialogue to be added.</summary>
    internal class PlayerItems
    {
        public string Hat { get; set; } = null; // null means 'any'
        public string Shirt { get; set; } = null; 
        public string Pants { get; set; } = null; 
        public string Rings { get; set; } = null; //Valid formats: "id", "id1 AND id2", "id1 OR id2"

        public string Inventory { get; set; } = null; // "↑"

        public string GameQuery { get; set; } = null; //must be a game query. see https://stardewvalleywiki.com/Modding:Migrate_to_Stardew_Valley_1.6#Game_state_queries 
        
        public PlayerItems()
        {

        }

        public PlayerItems(PlayerItems p)
        {
            Hat = p.Hat;
            Shirt = p.Shirt;
            Pants = p.Pants;
            Rings = p.Rings;
            Inventory = p.Inventory;
            GameQuery = p.GameQuery;
        }
    }
}