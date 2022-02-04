//Exercise 1.1
let sqr x = x*x

sqr 10;;

//Exercise 1.2
let pow x n = System.Math.Pow(x,n)

pow 2.0 3.0;;

//Exercise 1.3
let rec sum = function
|0 -> 0
|1 -> 1
|n -> sum(n-1)+n;;

sum 10;;

//Exercise 1.4
let rec fib = function
|0 -> 0
|1 -> 1
|n -> fib(n-1) + fib(n-2)

fib 7;;

//Exercise 1.5
let dup s = s ^ " " ^ s

dup "hej"

//Exercise 1.6
let rec dupn s n = 
    match n with
    |_ when n <= 0 -> ""
    |_ -> s + (dupn s (n-1))

dupn "hej" 3

//Exercise 1.7
let rec bin = function
|(n,0) -> 1
|(n,k) when k=n -> 1
|(n,k) -> bin(n-1,k-1) + bin(n-1,k)

bin (4,1)

//Exercise 1.8
let timediff (h1,m1) (h2,m2) = h2*60+m2 - h1*60-m1

timediff (12,34) (11, 35);; 