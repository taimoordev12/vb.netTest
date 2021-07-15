Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "choose"
        ComboBox1.Items.Add("ID")
        ComboBox1.Items.Add("First Name")
        ComboBox1.Items.Add("Surname")
        ComboBox1.Items.Add("Application Status")
        ComboBox1.Items.Add("Credit Score")



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
