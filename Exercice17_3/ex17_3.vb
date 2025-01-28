Module ex17_3

    Sub Main()
        Dim choix, element As String
        Dim pile As New Pile()
        Do
            Console.WriteLine("1. Empiler")
            Console.WriteLine("2. Dépiler")
            Console.WriteLine("3. Tester si la Pile est vide")
            Console.WriteLine("4. Nombre d'éléments dans la Pile")
            Console.WriteLine("5. Contenu de la Pile")
            Console.WriteLine("6. Quitter")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Console.WriteLine("Entrer l'élément à empiler.")
                    element = Console.ReadLine()
                    If pile.Empiler(element) Then
                        Console.WriteLine("Element ajoutée avec succès.")
                    Else
                        Console.WriteLine("Une erreur est survenu, la Pile est probablement pleine.")
                    End If
                Case 2
                    Dim depile As String = pile.Depiler()
                    If depile IsNot Nothing Then
                        Console.WriteLine("Valeur extraite de la pile : " + depile)
                    Else
                        Console.WriteLine("Aucune valeure n'a pu être dépilée.")
                    End If
                Case 3
                    If pile.EstVide Then
                        Console.WriteLine("La Pile est vide")
                    Else
                        Console.WriteLine("La Pile n'est pas vide")
                    End If
                Case 4
                    Console.WriteLine("Nombre d'élément dans la pile : " + pile.NombreDElements.ToString)
                Case 5
                    Console.WriteLine(pile.ToString)
                Case 6
                    Console.WriteLine("Au revoir !")
                    Console.ReadLine()
                Case Else
                    Console.WriteLine("Veuillez choisir un nombre entre 1 et et 6 compris.")
            End Select
        Loop Until choix = "6"
    End Sub

End Module
