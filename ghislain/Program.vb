Imports System
Imports System.ComponentModel.Design

Module Program
    Sub Main(args As String())

        Dim Age As Integer
        Age = 30

        If Age >= 18 Then
            Console.WriteLine(" Vous êtes majeur")
        Else
            Console.WriteLine("Vous êtes mineur")
        End If

        Dim nom As String
        nom = "Bella Mboutou Sidoine Ghislain"

        Dim Ghislain As New Person

        Ghislain.Intoduction(Nom:=nom)

        Dim affichage As String = Ghislain.Addition(5, 10)

        Console.WriteLine("la somme de 5 et 10 donne : " & affichage)


        Console.ReadLine()
    End Sub
End Module
