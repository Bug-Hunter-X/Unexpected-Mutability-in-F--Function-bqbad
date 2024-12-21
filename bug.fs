let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y

let z = add x y
printfn "%d %d %d" x y z