# LCMS-TOF-Report-Tool
App to generate analytical reports (.NET)


Alternative download link from OneDrive: https://1drv.ms/u/s!AhhJ65yR_GEOhdE6rXWsa1NL0wlqag?e=T6q5nd

[![Watch the video](/LCMS%20Report%20(0.0.5)/LCMS%20Report/Resources/screenshot_video.png?raw=true "Screenshot Video")](https://youtu.be/7m9FOIPy3Tg)

This is the first programme that I created when starting learning programming, I made this app while working as Assistant Scientist in the Environment Agency (UK), watching the rudimentary way of reporting result for this analytical method I thought I could create something to speed up the process. The results of the analysis were being written by hand on a paper-notebook having to pass them after again to a computer on a .doc file and using "copy/paste" to add names and cash# numbers from a template. In a method like LCMS-TOF-Screening and with a Compound Database with over 500 different analytes, a single sample can report over 100 different compounds. It makes the process time consuming and prone to human mistakes.

I created this tool as a personal learning challenge, I had no previous experience with VB.NET, Visual Studio or the .NET framework but after a bit of research I decided that Windows Forms would be the best way to deal with the GUI. 

The purpose of this tool is to help the reporting process of results of an analytical method (LCMS-TOF-Screening), saving time and resources by streamlining the process. It also reduces the human error factor, which is highly important working under UKAS Laboratory accreditation (ISO/IEC 17025).

The GUI makes it easy to use for people without computer skills. Also, it is portable and no installation is needed, it should run on any Windows OS computer just by coping the folder and executing the .exe file.

Default password: qwerty

The "Database version number" will change every time that the "database" is modified, its purpose is to help to follow up with the last version when using the same program in many different computers.
Maybe it is needed to install the last version of "SAP Crystal Reports Runtime (32Bit-64Bit)" to visualise the pdf form if an error shows up when running a report. Installer: https://1drv.ms/u/s!AhhJ65yR_GEOhbsmzBZVkwU9-LXTwg?e=6arI5G

Instructions:

To execute the exe file: "\LCMS Report (0.0.5)\LCMS Report\bin\Debug\LCMS Report.exe" or open the solution in Visual Studio "\LCMS Report (0.0.5)\LCMS Report.sln"
Introduce a quantity in the results column for those compounds detected in the analysis (introduce any character for the no-quantitative compounds)
Select a path and introduce the sample ID number.
Run button will generate:
- A text file in the selected path with all the compounds in a specific format. This text file is used to upload the results to the System (STARLIMS).
- A printable pdf record.
