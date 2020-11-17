Imports System.ComponentModel.Design
Imports System.Windows.Forms

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Windows.Forms.MessageBox.Show("Welcome To Hyperion. Your simple innovative book management system.")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        ' Windows.Forms.MessageBox.Show(DateTimePicker1.Value)
    End Sub

    Private Sub Student()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Dim WhereTheCrawdadsSing As Books = New Books("Where the Crawdads Sing ", "Delia Owens ", DateTimePicker1.Value, "A", "Test")
        Dim MagnoilasTableVol2 As Books = New Books("Magnoilas Table, Vol. 2", "Joanna Gaines ", DateTimePicker1.Value, "A", "Test")
        Dim TheRoomWhereItHappened As Books = New Books("The Room Where It Happened ", "John Bolton ", DateTimePicker1.Value, "A", "Test")
        Dim Untamed As Books = New Books("Untamed ", "Glennon Doyle ", DateTimePicker1.Value, "A", "Test")
        Dim WhiteFragility As Books = New Books("White Fragility ", "Robin DiAngelo ", DateTimePicker1.Value, "A", "Test")
        Dim LittleFiresEverywhere As Books = New Books("Little Fires Everywhere ", "Celeste Ng ", DateTimePicker1.Value, "A", "Test")
        Dim AmericanDirt As Books = New Books("American Dirt ", "Jeanine Cummins ", DateTimePicker1.Value, "A", "Test")
        Dim HowtoBeanAntiracist As Books = New Books("How to Be an Antiracist ", "Ibram X. Kendi ", DateTimePicker1.Value, "A", "Test")
        Dim TheBoytheMoletheFoxAndtheHourse As Books = New Books("The Boy, the Mole, the Fox, And the Hourse ", "Charlie Mackesy ", DateTimePicker1.Value, "A", "Test")
        Dim TheSplendidAndtheVile As Books = New Books("The Splendid And the Vile ", "Erik Larson ", DateTimePicker1.Value, "A", "Test")
        Dim CaminoWinds As Books = New Books("Camino Winds ", "John Grisham ", DateTimePicker1.Value, "A", "Test")
        Dim Becoming As Books = New Books("Becoming ", "Michelle Obama ", DateTimePicker1.Value, "A", "Test")
        Dim IfItThenBleeds As Books = New Books("If It Then Bleeds ", "Stephen King ", DateTimePicker1.Value, "A", "Test")
        Dim TheMambaMentality As Books = New Books("The Mamba Mentality ", "Kobe Bryant ", DateTimePicker1.Value, "A", "Test")
        Dim The5LoveLanguages As Books = New Books("The 5 Love Languages ", "Gary Chapman ", DateTimePicker1.Value, "A", "Test")
        Dim BurnAfterWriting As Books = New Books("Burn After Writing ", "Sharon Jones ", DateTimePicker1.Value, "A", "Test")
        Dim Educated As Books = New Books("Educated ", "Tara Westover ", DateTimePicker1.Value, "A", "Test")
        Dim TheFourAgreements As Books = New Books("The Four Agreements ", "Don Miguel Ruiz ", DateTimePicker1.Value, "A", "Test")
        Dim TheTattooistofAuschwitz As Books = New Books("The Tattooist of Auschwitz ", "Heather Morris ", DateTimePicker1.Value, "A", "Test")
        Dim SoYouWanttoTalkAboutRace As Books = New Books("So You Want to Talk About Race ", "Ijeoma Oluo ", DateTimePicker1.Value, "A", "Test")


        System.Console.WriteLine("Book List")
        System.Console.WriteLine(WhereTheCrawdadsSing)
        System.Console.WriteLine(MagnoilasTableVol2)
        System.Console.WriteLine(TheRoomWhereItHappened)
        System.Console.WriteLine(Untamed)
        System.Console.WriteLine(WhiteFragility)
        System.Console.WriteLine(LittleFiresEverywhere)
        System.Console.WriteLine(AmericanDirt)
        System.Console.WriteLine(HowtoBeanAntiracist)
        System.Console.WriteLine(TheBoytheMoletheFoxAndtheHourse)
        System.Console.WriteLine(TheSplendidAndtheVile)
        System.Console.WriteLine(CaminoWinds)
        System.Console.WriteLine(Becoming)
        System.Console.WriteLine(IfItThenBleeds)
        System.Console.WriteLine(TheMambaMentality)
        System.Console.WriteLine(The5LoveLanguages)
        System.Console.WriteLine(BurnAfterWriting)
        System.Console.WriteLine(Educated)
        System.Console.WriteLine(TheFourAgreements)
        System.Console.WriteLine(TheTattooistofAuschwitz)
        System.Console.WriteLine(SoYouWanttoTalkAboutRace)



    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        'Dim choices = lsbBooks.SelectedItem() As Object

        lsbBooks.ClearSelected()


    End Sub
End Class