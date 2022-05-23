//Exercise 2.1 = Write a function downto1 : int -> int list that given an integer returns the -element list [n; n-1;
let rec downto1 n = if n <= 0 then [] else n::downto1(n-1)

downto1 10

let rec downto2 = function
|0 -> []
|n -> n::downto2(n-1)

downto2 10

//Exercise 2.2 = Write a function removeOddIdx : 'a list -> 'a list that given a list xs returns a list where all odd- indexed elements of xs have been removed
let removeOddIdx xs = xs |> List.mapi(fun i el -> el,i) |> List.filter(fun (el,i) -> i%2 = 0) |> List.map fst
removeOddIdx ["hej"; "med"; "dig"]

//Exercise 2.3 = Write a function combinePair : 'a list -> ('a * 'a) list that given a list xs returns the list with elements from xs combined into pairs. If xs contains an odd number of elements, then the last element is thrown away.
let rec combinePair = function
|[] -> []
|x::xs when xs.Length = 0 -> []
|x::xs -> (x,xs.Head) :: combinePair xs.Tail

combinePair ["Marry"; "had"; "a"; "little"; "lamb"; "its"; "fleece";
                "was"; "white"; "as"; "snow"];;

//Exercise 2.4 = nye typer
type complex = float * float

let mkComplex x y = (x,y) : complex

let complexToPair (x : complex) = fst x, snd x

let (|+|) (c1:complex) (c2:complex) = 
let a,b = c1
let c,d = c2
a+c, b+d

let (|*|) (c1:complex) (c2:complex) =
let a,b = c1
let c,d = c2
(a*c-b*d, b*c+a*d)

let (|-|) (c1:complex) (c2:complex) =
let a,b = c2
c1 |+| (-a,-b)

let (|/|) (c1:complex) (c2:complex) =
let a,b = c2
let d = a**2 + b**2
c1 |*| (a/d,-b/d)

//Exercise 2.5 = Write a non-recursive function explode1 : string -> char list that given a string s returns the list of characters in s .
let explode1 = function 
|"" -> []
|s -> s.ToCharArray() |> List.ofArray

explode1 "hej fede"

let rec explode2 = function
|"" -> []
|s -> s.Chars 0 :: explode2 (s.Remove(0,1))

explode2 "hej fede"

//Exercise 2.6 = Write a function implode : char list -> string that given a list of characters cs returns a string with all characters of cs in the same order.
let implode cs = List.foldBack cs |> cs.ToString()

implode ['H'; 'e'; 'l'; 'l'; 'o'; ' '; 'W'; 'o'; 'r'; 'l'; 'd'; '!'] 