﻿using System;
using System.Collections.Generic;
using System.Text;

/***************************************************************************************************
* CIS 123: Introduction to OOP     |    Exercise 14-1 Use inheritance                              
* Murach's C#, 7th Edition         |    Add 2 classes to the Inventory Maintenance application     
* Chapter 14 Extra Exercises       |    that inherit the InvItem class. Add code to the forms to   
* Team 2 Assignment, 11JUN2022     |    provide for these new classes:                             
* Patrick McKee & Dominique Tepper |           (1) Plant, (2) Supply                               
* --------------------------------------------------------------------------------------------------
*
* Step 3. Add a class named Plant that inherits the InvItem class.
*      a. Add a string property named Size
*      b. Provide a default constructor
*      c. Provide a contructor that accepts 4 parameters to initialize properties
*         defined by the class:
*            i. item number
*           ii. description
*          iii. price
*           iv. size
*      d. Override the GetDisplayText() method to add the size in front of
*         the description - 
*          3245649    1 gallon Agapanthus ($7.95)
 * *************************************************************************************************/
namespace InventoryMaintenance
{
    public class Plant : InvItem
    {
        private string size;

        public Plant() { } // 3-b.

        // 3-c. i, iv, ii, iii
        public Plant (int itemNo, string size, string description, decimal price) : 
            base(itemNo, description, price)
        {
            this.size = size; // initializes the size field after the
                              // base class constructor is called
        }

        // 3-a. new property
        public string Size 
        {
            get 
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        } 

        public override string GetDisplayText()
        {
            return this.ItemNo + "    " + 
                this.Size + " " + 
                this.Description + "( " + 
                this.Price.ToString("c") + ")";
        }
        
    }
}

