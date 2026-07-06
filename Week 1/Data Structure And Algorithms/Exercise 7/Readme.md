# Notes - Financial Forecasting (Recursion)

## What is Recursion

Recursion is when a method calls itself to solve a smaller version of the
same problem. It needs two parts:

- a base case, which stops the recursion
- a recursive case, which calls itself again with input that's closer to the
  base case

It's useful here because future value naturally depends on the previous
year's value, which depends on the year before that, and so on. The code
ends up matching the math almost exactly instead of needing a separate loop
structure to track state.

## How the recursive method works

FutureValue(years) = FutureValue(years - 1) * (1 + growthRate)
FutureValue(0) = principal (base case)

Each call multiplies the result of the previous year by the growth rate,
until it hits year 0 and just returns the starting amount.

## Time Complexity

The method makes one recursive call per year with no branching, so:

- Time: O(n), n = number of years
- Space: O(n) too, because each call stays on the call stack until it returns

The space part is easy to miss since it looks like a loop. If years gets
really large (like 100,000+), this could throw a stack overflow because of
how many calls are stacked up at once before any of them return.

## How to optimize it

The simplest fix is to just use a loop instead of recursion. Since each step
only needs the value from the previous step, there's no real reason to use
the call stack to track it:

double value = principal;

for (int i = 0; i < years; i++)
{
value *= (1 + growthRate);
}

This does the same calculation with O(1) space instead of O(n), and there's
no risk of stack overflow no matter how many years you forecast.

Tail recursion is another option in theory (passing the running total as a
parameter so there's no work left after the recursive call returns), but C#
doesn't actually optimize tail calls the way some other languages do, so it
wouldn't fix the stack space issue here - it would just look cleaner.

Memoization (caching previous results) doesn't really help this specific
problem since each year only gets computed once anyway - there's no repeated
subproblem to cache. It would matter more for something like Fibonacci where
the same smaller problems get recalculated many times.