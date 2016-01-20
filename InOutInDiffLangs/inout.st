" Smalltalk language "

solveMeFirst := [ :num1 :num2 | 
    " Hint: Type num1 + num2 below "
    num1 + num2 
].


input := stdin.
[input atEnd] whileFalse: [
    a:= input nextLine asInteger.
    b:= input nextLine asInteger.
    res := solveMeFirst value: a value: b
].
(res) printNl
