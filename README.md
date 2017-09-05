# Microsoft-C--SWE1
Here's a brief project description of each listed in this folder:
1. Calculate Area and Perimeter:
Operation
*	The user enters values for the length and width of a rectangle and clicks the Calculate button or presses the Enter key to activate that button.
*	The application then displays the area and perimeter of the rectangle in the third and fourth labels on the right side of the form.
Specifications
*	The formula for calculating the area is width * length.
*	The formula for calculating the perimeter is 2 * width + 2 * length.
*	The application should accept fractional decimal entries like 10.5 and 20.65.
*	Assume that the user will enter valid numeric data for the length and width.


2. Calculate the Factorial of a Number:
Operation
*	The user enters a number and clicks the Calculate button or presses the Enter key to activate that button.
*	The program calculates the factorial of the number and displays it in a label on the form.
Specifications
*	The factorial of an integer is that integer multiplied by every positive integer less than itself. A factorial number is identified by an exclamation point following the number. Here’s how you calculate the factorial of the numbers 1 through 5:
1! = 1	which equals 1

2! = 2 * 1	which equals 2

3! = 3 * 2 * 1	which equals 6

4! = 4 * 3 * 2 * 1	which equals 24

5! = 5 * 4 * 3 * 2 * 1	which equals 120
*	The application should return an accurate value for integers from 1 to 20. The factorial of the number 20 is 2,432,902,008,176,640,000. (If you enter a number larger than 20, a factorial will still be displayed, but it won’t be accurate.)
*	The application assumes that the user enters a valid integer from 1 to 20.
*	The application should format the factorial with commas, but no decimal places.
Hint
*	To be able to store the large integer values for the factorial, this application can’t use the Int32 data type.

3. Accumulate Test Score Data:
Operation
*	The user enters a score and clicks the Add button or presses the Enter key.
*	The application calculates and displays the score total, score count, and average score.
*	If the user clicks the Display scores button, the application sorts the scores and displays them in a message box.
* If the user clicks the Clear scores button, the application removes all the scores and clears the score, score total, score count, and average controls.
Specifications
*	This application should be able to handle at least 20 scores.
*	This application should check the number entered by the user to make sure it is a valid integer from 0 to 100.


4. Caluclate Reservation Totals:
Operation
*	The user enters an arrival date and a departure date and clicks the Calculate button or presses the Enter key.
*	The application calculates, formats, and displays the number of nights and the total price.
Specifications
*	The price per night should be $115.
*	This application should validate both entries to make sure they are dates that are on or after the current date. The application should also validate the departure date to be sure that it is after the arrival date.
*	This application should only accept reservations within five years of the current date.
*	When the application starts, it should display the current date in the first text box and the current date plus three days in the second text box. That way, the user can modify these default dates as necessary.


5. Direct a simple robot:
Operation
*	This project simulates a simple robot that can move a given direction and distance.
*	To determine the direction the robot will move, the user clicks the N (North), S (South), E (East), or W (West) button.
*	The robot is displayed as an arrow that points in the currently selected direction.
*	The user can move the robot 1 or 10 units in the selected direction by clicking the Go 1 or Go 10 button.
*	The robot’s current X, Y position is displayed in a label at the top of the form.
Specifications
*	Create a class called Robot that has a method that causes the robot to move, a public field that contains the current direction, and a property that returns the robot’s current position as a Point structure. When the robot is instantiated, the position should be set to 0, 0 (the center) and the direction should be set to North.
*	Limit the range of the robot to 100 units in any direction. If the user attempts to move the robot beyond this range, the Robot class should raise an event. The application should respond to this event by displaying an appropriate message. 
Hints
*	The easiest way to create the moving arrow is to use a label control. Then, the program can adjust the control’s Position property to move the arrow within a panel control. If you need to, you can use online help to research this control.
*	To create the arrow, set the label’s Font property to the Wingdings font. Then, you can use the int values 231 through 234 to set the label to the appropriate arrow.


6. Maintain Student Scores:
Operation: Student Scores
*	To display the total, count, and average for a student, the user selects the student from the list box. If the list box is empty, the total, count, and average labels should be cleared.
*	To add a new student, the user clicks the Add button to display the Add New Student dialog box.
*	To update an existing student’s scores, the user selects the student in the list box and clicks the Update button to display the Update Student Scores dialog box.
*	To delete a student, the user selects the student in the list box and clicks the Delete button.
Operation: Add New Student
*	To add a new student, the user enters a student name and one or more scores and clicks the OK button.
*	To add a score, the user enters a score and clicks the Add Score button. The score is added to the list of scores in the Scores label.
*	To remove all scores from the Scores label, the user clicks the Clear Scores button.
*	To cancel the add operation, the user clicks the Cancel button.
