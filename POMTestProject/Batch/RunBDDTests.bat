@echo off

echo ::: Running BDD tests using NUnit test runner...
..\..\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe "..\bin\Debug\POMTestProject.dll" --result=..\TestResult.xml