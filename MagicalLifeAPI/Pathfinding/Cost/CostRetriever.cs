﻿using MagicalLifeAPI.Entities;
using MagicalLifeAPI.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalLifeAPI.Pathfinding.Cost
{
    /// <summary>
    /// Handles all rules involving the costs of moving between two tiles.
    /// </summary>
    public static class CostRetriever
    {
        /// <summary>
        /// Contains all of the rules that collectively calculate the movement cost between two tiles.
        /// </summary>
        private static List<IAddMovementCost> MovementCostRules = new List<IAddMovementCost>();

        public static void AddMovementCostRule(IAddMovementCost rule)
        {
            MovementCostRules.Add(rule);
        }

        public static void RemoveMovementCostRule(IAddMovementCost rule)
        {
            MovementCostRules.Remove(rule);
        }

        /// <summary>
        /// Returns the total cost of moving between two tiles.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="mover">The creature that would move between the two tiles.</param>
        /// <returns></returns>
        public static int CalculateMovementCost(Tile start, Tile end, Living mover)
        {
            int total = 0;

            foreach (IAddMovementCost item in MovementCostRules)
            {
                total += item.GetMovementCost(start, end, mover);
            }

            return total;
        }
    }
}
