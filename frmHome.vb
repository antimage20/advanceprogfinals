Imports System.Data.SqlClient
Public Class frmHome
    Private Sub btnPatientrecord_Click(sender As Object, e As EventArgs) Handles btnPatientrecord.Click

        gbxHome.Hide()
        TabControl1.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        TabControl1.Hide()
        gbxHome.Show()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtCellphone.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtProvince.Text = ""
        txtPostalcode.Text = ""
        rbSingle.Checked = False
        rbMarried.Checked = False
        dtpDateofBirth.ResetText()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

        Me.Hide()
        gbxHome.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        PatientInformationBindingSource.EndEdit()
        PatientInformationTableAdapter.Update(Database2DataSet)
        MessageBox.Show("Save successfully")

    End Sub
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.PatientInformation' table. You can move, or remove it, as needed.
        Me.PatientInformationTableAdapter.Fill(Me.Database2DataSet.PatientInformation)


    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        PatientInformationBindingSource.MovePrevious()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        PatientInformationBindingSource.AddNew()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        PatientInformationBindingSource.MoveNext()

    End Sub
End Class