module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec iter n steps =
    if n = 1UL then steps
    else if n % 2UL = 0UL then iter (n / 2UL) (steps + 1)
    else iter (3UL * n + 1UL) (steps + 1)
  iter (uint64 n) 0
