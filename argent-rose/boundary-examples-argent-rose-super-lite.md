Identifying missing examples.
===================================

Given the Argent Rose Requirements Specification, someone wrote the following list of examples 
for the quality and sell in update of products described as "Theatre Passes":
  
  - [{sell-in: 10, Q: 5, desc: "Theatre Passes"}] => [{sell-in: 9, Q: 6, desc: "Theatre Passes"}]
  - [{sell-in: 5, Q: 34, desc: "Theatre Passes"}] => [{sell-in: 4, Q: 37, desc: "Theatre Passes"}]
  - [{sell-in: 7, Q: 17, desc: "Theatre Passes"}] => [{sell-in: 6, Q: 18, desc: "Theatre Passes"}]  
  - [{sell-in: 1, Q: 22, desc: "Theatre Passes"}] => [{sell-in: 0, Q: 25, desc: "Theatre Passes"}]
  - [{sell-in: -20, Q: 45, desc: "Theatre Passes"}] => [{sellin: -21, Q: 0, desc: "Theatre Passes"}]

Are we missing any important examples?

Cuales son los boundary examples?

For Regular products, partitions are:

Invariant: Description
Invariant: Quality >= 0 and Quality <= 50

Inputs: Inventory
Outputs: Inventory updated

Partitions:
[sellIn > 5]
OnPoint: SellIn = 6
OffPoint: SellIn = 5

[sellIn <= 5 and sellIn > 0]
OnPoint: SellIn = 5
OnPoint: SellIn = 1
OffPoint: SellIn = 6
OffPoint: SellIn = 0

[sellIn <= 0]
OnPoint: SellIn = 0
OffPoint: SellIn = 1





OnPoint:
OffPoint:

