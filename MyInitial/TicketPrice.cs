﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private decimal amountDue;
        private decimal mPrice;
        private decimal discountAmount; // Store the user-provided discount amount

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TicketPrice
    public TicketPrice(int section, int quantity, bool discount, decimal discountAmount)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        this.AmountDue = amountDue; // Set the user-provided discount amount
        }

     public void calculatePrice()
     {
        // Set the base price according to the selected section
         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
         }
         
         // Apply the user-entered discount if applicable
         if (discount)
            {
                mPrice -= discountAmount; // Use the dynamic discountAmount instead of a fixed one
            }

         // Calculate the total price before discount
         AmountDue = mPrice * quantity;

     }
    }
}
