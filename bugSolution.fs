let x = 10
let y = 20

let add x y = 
    let newX = x + y
    (newX, y)

let (z, w) = add x y
printfn "%d %d %d %d" x y z w