Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim AppID As String
        Dim Firstname As String
        Dim Lastname As String
        Dim Status As String
        Dim CreditScore As String



        Dim tfp As New TextFieldParser("C:\Job work\AdvantageFinanceTest\Data.csv")
        tfp.Delimiters = New String() {","}
        tfp.TextFieldType = FieldType.Delimited


        tfp.ReadLine() ' skip header
        While tfp.EndOfData = False
            Dim fields = tfp.ReadFields()
            AppID = fields(0)
            Firstname = fields(1)
            Lastname = fields(2)
            Status = fields(3)
            CreditScore = fields(4)


            Console.WriteLine(String.Format("{0} - {1} - {4}", AppID, Firstname, Lastname, Status, CreditScore))
        End While



        ComboBox1.Text = "choose"
        ComboBox1.Items.Add("ID")
        ComboBox1.Items.Add("First Name")
        ComboBox1.Items.Add("Surname")
        ComboBox1.Items.Add("Application Status")
        ComboBox1.Items.Add("Credit Score")



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
