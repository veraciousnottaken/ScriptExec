ScriptExec
==========

A simple program to invoke executables located in the specified directory.

Simple configuration INI file.
=============================

[repository]
path =
username = foo
password = bar

Username and password parameters are optional and used when a network share path (starts with \ \).

The following sections can be created when you need to pass parameters to the script. For example,

[parametertest.bat]
parameters = a b c

The call parameters of the program
==================================

-i the path to the ini file

Example
======
ScriptExec.exe -i \ini\ScriptExec.ini