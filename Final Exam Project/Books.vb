Imports System

Imports System.Collections

Imports System.Exceptions


Public Class Books

    'varibles
    Private name As String = "Brian J. Frable"
    Private title As String
    Private author As String
    Private dateRead As Date
    Private rating As String
    Private category As String

    'array book list
    Dim myBooks As New ArrayList

    'sets levels to .05 adn the weigths to .3
    Public Sub New()

        title = "The Two Towers"
        author = "J.R.R Tolkien"
        'dateRead = DateTimePicker1.Value

    End Sub

    Public Sub New(T As String, A As String, D As Date, R As String, C As String)


        title = T
        author = A
        dateRead = D
        rating = R
        category = C

        Me.name = name

    End Sub



    'allows main to add book to list
    Public Sub addBook(book As Books)
        myBooks.Add(book)
    End Sub


    Public Function getTitle() As String

        Return title

    End Function

    Public Function getAuthor() As String

        Return author

    End Function


    Public Function getDateRead() As Date

        Return dateRead

    End Function

    Public Function getRating() As String

        Return rating

    End Function

    Public Function getCategory() As String

        Return category

    End Function

    Public Sub Neww()
        Try
            If title.Length < 0 Or author.Length < 0 Then
                System.Console.WriteLine("The name has to be at least one character long.")
            End If
        Catch NameLengthNotSatifistedErr As Exception
            System.Console.WriteLine("The name has to be at least one character long.")
        End Try

    End Sub

    ' Magical code that makes stuff print out readable 
    Public Overrides Function ToString() As String
        Return "Tile: " & getTitle() & " Author: " & getAuthor() & "Date Read: " & getDateRead() & "Rating: " & getRating() & "Category: " & getCategory()



    End Function
















End Class
