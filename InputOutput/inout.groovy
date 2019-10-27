// Groovy language

def solveMeFirst(a,b) { 
    a+b
}

BufferedReader br = new BufferedReader(new InputStreamReader(System.in))
def a = Integer.parseInt(br.readLine())
def b = Integer.parseInt(br.readLine())
def res = solveMeFirst(a,b)
println res
