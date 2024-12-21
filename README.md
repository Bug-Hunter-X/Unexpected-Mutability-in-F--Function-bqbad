# Unexpected Mutability in F# Function

This example demonstrates a common pitfall in F# when dealing with mutable variables within functions.  The `add` function modifies the input variable `x` and returns `y`, leading to behavior that might be unexpected for developers unfamiliar with F#'s mutability handling.

The provided solution shows a safer way to handle this scenario using immutability.