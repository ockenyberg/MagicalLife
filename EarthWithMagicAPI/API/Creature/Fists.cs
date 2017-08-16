﻿using EarthWithMagicAPI.API.Interfaces.Items;
using System;
using System.Collections.Generic;
using System.Text;
using EarthWithMagicAPI.API.Interfaces.Spells;

namespace EarthWithMagicAPI.API.Creature
{
    public class Fists : IWeapon
    {
        public Fists()
        {
            this.IsEquipped = false;
            this.Level = -1;
            this.Lore = new List<string>();
            this.Name = "Fists";
            this.OtherInformation = new List<string>();
            this.QuestItem = false;
            this.Value = 0;
            this.Weight = 0;
            this.Damage = new Damage(new Util.Die(0, 0, 0), new Util.Die(0, 0, 0), new Util.Die(0, 0, 0), new Util.Die(0, 0, 0), new Util.Die(0, 0, 0), new Util.Die(0, 0, 0),
        new Util.Die(0, 0, 0), new Util.Die(0, 0, 0), new Util.Die(1, 2, 0));
        }

        public override void Bought()
        {
            throw new NotImplementedException();
        }

        public override void Equip()
        {
            throw new NotImplementedException();
        }

        public override StatsImpact EquipImpact()
        {
            throw new NotImplementedException();
        }

        public override void OnAttack()
        {
            throw new NotImplementedException();
        }

        public override void OnThrow()
        {
            throw new NotImplementedException();
        }

        public override void Sold()
        {
            throw new NotImplementedException();
        }

        public override void SpellHit(ISpell spell)
        {
            throw new NotImplementedException();
        }

        public override void Unequip()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            throw new NotImplementedException();
        }

        public override void WeaponHit(IWeapon attacker)
        {
            throw new NotImplementedException();
        }
    }
}
