let mutable x = 10
let mutable y = 20

let swap () = 
    let temp = x
    x <- y
    y <- temp

swap ()
printf "%d %d" x y // Output: 20 10