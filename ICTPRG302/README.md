The bulk of this can be found in Form1.cs 

All functionality has been assigned to the button click. 

For Allocated Cases/Closed Cases entry boxes, make sure you use NumericUpDown in visual studio forms instead of TextBox, otherwise it will throw errors when you enter
a non-numeric

It doesn't take any non-number, wont calculate if allocated cases is 0, a username must be entered. 

The  username & result is saved to a text doc with the date as it's name and if you calculate again on the same day, it will append the name & result after
the original entry
