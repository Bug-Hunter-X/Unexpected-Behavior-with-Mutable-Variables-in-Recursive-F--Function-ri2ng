let mutable x = 0
let mutable y = 0

let rec loop () =
    x <- x + 1
    y <- y + 1
    if x < 10 then
        loop()
    else
        printfn "x = %d, y = %d" x y

loop ()