' VB.NET language

Imports System


Module Solution
    Function solveMeFirst(ByVal a,b As Integer) As Integer
       ' Hint: Type Return a+b below 
        Return a+b
    End Function
    
   Public Shared Sub Main()
      Dim a As Integer 
        Dim b As Integer 
        Dim res As Integer 
        a = Console.Readline() 
        b = Console.Readline() 
        res = solveMeFirst(a,b)
        Console.WriteLine("{0}",res)
   End Sub
End Module
