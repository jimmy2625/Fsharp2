//Exercise 2.1

let rec downto1 n = if n > 0 then n::downto1 (n-1) else []

downto1 5

let rec downto2 = function
|0 -> []
|n -> n::downto2 (n-1)

downto2 6

//Exercise 2.2
let removeOddIdx xs = xs |> List.mapi(fun i x -> x,i) |> List.filter(fun(x,i) -> i % 2 = 0) |> List.map fst

removeOddIdx ["Marry"; "had"; "a"; "little"; "lamb"; "its"; "fleece";
 "was"; "white"; "as"; "snow"]

//Exercise 2.3
let rec combinePair = function 
|[] -> []
|x::xs when xs.IsEmpty -> []
|x::xs -> (x,xs.Head):: combinePair xs.Tail

combinePair ["Marry"; "had"; "a"; "little"; "lamb"; "its"; "fleece";
 "was"; "white"; "as"; "snow"]