Hi,

Please find all source code files in \MagicSquare folder.

The MagicSquare solution has 3 projects.

1.	Project MagicSquare - just has a class Square with one function IsMagic I’m going to test.
As requested, this function returns “Yes” if we have Magic Square or “No” if we do not have.

2.	Project GUI_4_MagicSquare_usage  - just a GUI to see how to call the Square.IsMagic function to evaluate input. I just hardcoded the input values from your examples and then called the function. 

3.	TestMagicSquare – Unit test for the Square.IsMagic function.

To see how the test works just open NUnit and navigate to MagicSquare.dll in File->OpenProject.

There are two tests:
1. IsMagicTest_CorrectInput
   I have correct input and expect correct output. The test should pass.

2. IsMagicTest_IncorrectInput

   In you last example you said that:
1 1
1 1
returned: no
expected: yes

 But if the tested function works good, then it cannot return “No” for correct input.
If the function does not work good, then first test will fail. 
That is why I changed condition for the second test. 
I have incorrect input and expect “No” as a result. The test will pass because the function should return “No” for incorrect input. 


Thanks,
Sergey
