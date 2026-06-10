Argent Rose Requirements Specification
======================================

## Context.
My name is Syl. 
I'm the owner of the Argent Rose, a small wizardry store.

I need to update the inventory of my store, at the end of each day, 
in order to track the quality and sellIn of my products.

- All products have:
  1. A description.
  2. A sellIn value which denotes the number of days we have to sell the product (0 means the last day the product should be sold). When the sellIn value is negative it means that the product has expired.
  3. A quality value which denotes how valuable the product is. It's never negative and never more than 50.

- All the products in our inventory are valid.

## Rules for updating products before its sellIn days expires.

- The sellIn is updated first and then the quality is updated using the new value of the sellIn.

### Regular products:

- quality decreases by two.
- sellIn decreases by one.

### Special products

1. Products described as "Theatre Passes":
   - Their sellIn decreases by one.
   - Their quality changes as their sellIn day approaches:
     - increases by one when there are more than five days to sell the product.  
     - increases by three when there are five days or less to sell the product.
     - drops to zero after the play.

## Rules for updating the quality after its sellIn days expires

- The sellIn is updated first: sellIn' = sellIn - 1.

- Then the quality is updated according to sellIn'. 
  - Expired <=> sellIn <= 0 <=> sellIn' <= -1

- Their quality changes twice as fast as it did before the sellIn days expires.

- Their sellIn decreases by one.
