//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        public double GetProductionCost()
        {
            double costoInsumos = 0;
            double costoEquipamiento = 0;

            foreach (Step step in steps)
            {
                costoInsumos += step.Input.UnitCost*step.Quantity;
                costoEquipamiento+= step.Time*step.Equipment.HourlyCost;

            }
            return costoInsumos+costoEquipamiento;
        }

        public String ToString()
        {
            StringBuilder retorno=new StringBuilder() ;
            retorno.Append($"Receta de {this.FinalProduct.Description}:\n");

            foreach (Step step in this.steps)
            {
                retorno.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
            return retorno.ToString();
        }
    }
}