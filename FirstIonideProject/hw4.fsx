open System 
let convertTuple t = 
    let (r, h) = t 
    System.Math.PI // * (r ** 2.0) * h 
 
(*
let max a b = 
    let vA = convertTuple(a)
    let vB = convertTuple(b)
    if vA > vB 
        then vA
        else vB

let rec maxCylinderVolume arr = 
    match arr with
    | [] -> 0.0
    | hd :: list -> max( hd, maxCylinderVolume list)
   
maxCylinderVolume [(2.1, 3.4); (4.7, 2.8); (0.9, 6.1); (3.2, 5.4)];;*)

let x = convertTuple (4.7, 2.8)
x