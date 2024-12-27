# F# Mutable Variable Bug

This repository demonstrates an unexpected behavior involving mutable variables within a recursive function in F#.

The `bug.fs` file contains code where two mutable variables, `x` and `y`, are intended to increment within a recursive loop. However, the output shows that only one of them updates correctly.

The `bugSolution.fs` file provides a corrected version that addresses the unexpected behavior.  The root cause of the bug was not using `let mutable` for the recursive call.  The recursive call was unintentionally creating a new copy of `x` and `y`, instead of updating the original variables.

This example serves as a cautionary reminder to pay close attention to the scope and mutability of variables in recursive functions in F#.