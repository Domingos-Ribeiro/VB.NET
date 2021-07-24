Module Module1

    Sub Main()
        Dim resultado As Int16
        Dim i As Int16

        Console.WriteLine("Olá mundo!")
        Dim x As Integer
        x = Console.ReadLine()
        resultado = x * 2
        x = Console.ReadLine() 'instrução lê do teclado e coloca na variável x
        Console.WriteLine("*****************************************************")
        Console.WriteLine("Teste condicional 1")
        'Console.WriteLine("Digite um numero ")
        If (x > 0) Then
            Console.WriteLine("POSITIVO")
        Else
            Console.WriteLine("Zero ou NEGATIVO")
        End If
        Console.WriteLine("*****************************************************")
        Console.WriteLine("Teste condicional 2")
        'Console.WriteLine("Digite um numero ")
        If (x > 0) Then
            Console.WriteLine("POSITIVO")
        ElseIf (x < 0) Then
            Console.WriteLine("NEGATIVO")
        Else
            Console.WriteLine("ZERO")
        End If
        Console.WriteLine("*****************************************************")
        Console.WriteLine("Ciclo FOR 1 to 10")
        For i = 1 To 10
            Console.Write(i)
        Next
        Console.ReadKey()
        Console.WriteLine("*****************************************************")
        Console.WriteLine("Ciclo WHILE i = 5")
        i = 5
        While (i <= 10)
            Console.Write(i)
            i = i + 1
        End While

        Console.WriteLine("*****************************************************")
        Console.WriteLine("Ciclo UNTIL i = 5")
        i = 1
        Do Until (i = 5)
            Console.WriteLine(i)
            i = i + 1
        Loop
        Console.WriteLine("*****************************************************")
        Console.WriteLine("Ciclo WHILE 2 -> i = 5")
        i = 1
        Do While (i <= 5)
            Console.WriteLine(i)
            i = i + 1
        Loop
        Console.WriteLine("*****************************************************")
        Console.WriteLine("Strings 1 to 5")
        Dim n As String
        Select Case n
            Case 1 To 5
                Console.WriteLine("Está de 1 e 5..")

            Case 10, 20, 30
                Console.WriteLine("10 ou 20 ou 30...")

            Case Else
                Console.WriteLine("outros...")
        End Select
        Console.WriteLine("*****************************************************")
        Console.WriteLine("Arrays 1 to 3")
        Dim V(3) As Integer
        x = Console.ReadLine()
        V(1) = x

        For i = 1 To 3
            Console.WriteLine(V(i))
        Next
        Dim encontrado As Boolean = False

    End Sub

End Module
