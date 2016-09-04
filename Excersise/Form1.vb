' Joshua Pickenpaugh
' Pounds Burned Calculator, September 4th, 2016

Public Class frmMain
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Closes the application:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Constants:
        Const STAIR_STEPPER As Double = 446
        Const ELLIPTICAL_TRAINER As Double = 670
        Const STATIONARY_BICYCLE As Double = 520
        Const CALORIES_NEEDED_TO_BURN_FOR_ONE_POUND As Double = 3500

        'Variables
        Dim dblStepper As Double
        Dim dblTrainer As Double
        Dim dblBicycle As Double
        Dim dblStepperTotal As Double
        Dim dblTrainerTotal As Double
        Dim dblBicycleTotal As Double
        Dim dblCaloriesBurnedTotal As Double
        Dim dblPoundsBurnedTotal As Double

        'Assigns hours on each machine into variables from text boxes:
        Double.TryParse(txtStepper.Text, dblStepper)
        Double.TryParse(txtTrainer.Text, dblTrainer)
        Double.TryParse(txtBicycle.Text, dblBicycle)

        'Calculates, put total calories burned on each machine into a variable:
        dblStepperTotal = dblStepper * STAIR_STEPPER
        dblTrainerTotal = dblTrainer * ELLIPTICAL_TRAINER
        dblBicycleTotal = dblBicycle * STATIONARY_BICYCLE

        'Calculates total calories burned by adding above machine totals:
        dblCaloriesBurnedTotal = dblStepperTotal + dblTrainerTotal + dblBicycleTotal

        'Calculates pounds burned:
        dblPoundsBurnedTotal = dblCaloriesBurnedTotal / CALORIES_NEEDED_TO_BURN_FOR_ONE_POUND

        'Outputs pounds burned:
        lblPoundsBurned.Text = dblPoundsBurnedTotal.ToString("N1")

    End Sub
End Class
