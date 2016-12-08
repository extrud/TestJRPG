using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PlayerBatlleCharacter : BattleCharacter

{
    Player player;
    public PlayerBatlleCharacter(Player pl ,int HP, string status, Battle battle, IBattleEvent Action ) : base("Player",HP, status, battle)
    {
        player = pl;
    }

    public override void Reaction(BattleAction act)
    {
        if (act.Tags.Contains("dmg"))
            {
            HP--;
            }
    }
}

