## Big O Notation

Big O tells you how the runtime of an algorithm grows as the input size grows.
It's not about exact seconds, it's about the trend - if you double the input,
does the algorithm take twice as long, or way more, or barely any different?

It helps because it lets you compare two algorithms without worrying about the
speed of the machine or the language used. Something that's fast for 50 items
might be too slow for 5 million items, and Big O is how you catch that early.

## Best, Average, Worst Case

- Best case: the easiest possible scenario for the algorithm (e.g. found on first try)
- Average case: typical scenario, somewhere in the middle
- Worst case: the hardest scenario (e.g. item not found, or checked last)

For linear search:
- Best: O(1)
- Average: O(n)
- Worst: O(n)

For binary search:
- Best: O(1)
- Average: O(log n)
- Worst: O(log n)

## Comparing Linear vs Binary Search

Linear search checks every item one at a time. It works on any array, sorted
or not, but gets slow as the array grows.

Binary search only works on sorted data, but it's much faster because it cuts
the search space in half every time. For 1 million items, linear search could
take up to a million checks, binary search takes around 20.

## Which is better for the platform

Binary search is better for searching products by ID or any field you can
sort ahead of time, like price. Since products get searched way more often
than they get added/updated, it's worth keeping the data sorted (or indexed)
so every search benefits.

Linear search still matters for things that can't be pre-sorted easily, like
searching inside product descriptions or tags. That's closer to a text search
problem than a sorted lookup problem.

In a real system this would usually be handled by a database index instead of
manually sorting an array, but the idea is the same - keep things ordered so
lookups don't need to check everything.