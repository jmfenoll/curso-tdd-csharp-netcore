Identifying redundant examples.
===================================

Given the [Argent Rose Requirements Specification](https://gist.github.com/trikitrok/5443ec70424d567be8e7612fe71e014f), 
someone wrote the following list of examples for the quality and sell in update 
of products described as "Theatre Passes":

- [{sellin: 2, Q: 27, desc: "Theatre Passes"}] => [{sellin: 1, Q: 30, desc: "Theatre Passes"}]
- [{sellin: 30, Q: 5, desc: "Theatre Passes"}] => [{sellin: 29, q: 6, desc: "Theatre Passes"}]
- [{sellin: 5, Q: 34, desc: "Theatre Passes"}] => [{sellin: 4, Q: 37, desc: "Theatre Passes"}]
- [{sellin: 10, Q: 5, desc: "Theatre Passes"}] => [{sellin: 9, q: 6, desc: "Theatre Passes"}]
- [{sellin: 3, Q: 13, desc: "Theatre Passes"}] => [{sellin: 2, Q: 16, desc: "Theatre Passes"}]
- [{sellin: 100, Q: 20, desc: "Theatre Passes"}] => [{sellin: 99, q: 21, desc: "Theatre Passes"}]
- [{sellin: -1, Q: 5, desc: "Theatre Passes"}] => [{sellin: -2, Q: 0, desc: "Theatre Passes"}]
- [{sellin: 5, Q: 34, desc: "Theatre Passes"}] => [{sellin: 4, Q: 37, desc: "Theatre Passes"}]
- [{sellin: 4, Q: 5, desc: "Theatre Passes"}] => [{sellin: 3, Q: 8, desc: "Theatre Passes"}]
- [{sellin: -20, Q: 45, desc: "Theatre Passes"}] => [{sellin: -21, Q: 0, desc: "Theatre Passes"}

Which of them are redundant?

Partitions:
- Partition 1: sellIn > 5
  - [{sellin: 30, Q: 5, desc: "Theatre Passes"}] => [{sellin: 29, q: 6, desc: "Theatre Passes"}]
  - [{sellin: 10, Q: 5, desc: "Theatre Passes"}] => [{sellin: 9, q: 6, desc: "Theatre Passes"}]
  - [{sellin: 100, Q: 20, desc: "Theatre Passes"}] => [{sellin: 99, q: 21, desc: "Theatre Passes"}]

- Partition 2: 0 < sellIn <= 5
  - [{sellin: 5, Q: 34, desc: "Theatre Passes"}] => [{sellin: 4, Q: 37, desc: "Theatre Passes"}]
  - [{sellin: 3, Q: 13, desc: "Theatre Passes"}] => [{sellin: 2, Q: 16, desc: "Theatre Passes"}]
  - [{sellin: 4, Q: 5, desc: "Theatre Passes"}] => [{sellin: 3, Q: 8, desc: "Theatre Passes"}]
  - [{sellin: 2, Q: 27, desc: "Theatre Passes"}] => [{sellin: 1, Q: 30, desc: "Theatre Passes"}]
  - [{sellin: 5, Q: 34, desc: "Theatre Passes"}] => [{sellin: 4, Q: 37, desc: "Theatre Passes"}]

- Partition 3: sellIn <= 0
  - [{sellin: -1, Q: 5, desc: "Theatre Passes"}] => [{sellin: -2, Q: 0, desc: "Theatre Passes"}]
  - [{sellin: -20, Q: 45, desc: "Theatre Passes"}] => [{sellin: -21, Q: 0, desc: "Theatre Passes"}
