# _Higher/Lower Game_

#### _An application that lets a use rplay the Higher Lower Game against the computer. , Feb 2020_

#### By _**Patrick Kille & Benjamin Thom**_

## Description

A user enters a number and the computer will guess the user's number. The game ends when the computer guesses the correct number.

## Preview
![Landing Page Preview](img/image file name here)

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|User chooses a number between 1-100|NA|NA|
|Computer displays initial guess|NA|50|
|User responds higher|"higher"|Computer changes lower limit to previous guess (50-100)|
|User responds lower|"lower"|Computer changes upper limit to previous guess (1-50)|
|User responds correct|"correct"|"Computer is victorious!"|

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/benjamin-thompdx/doctor-lookup.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} doctor-lookup```
* On Windows: ```doctor-lookup```

_Download Manually:_

* Navigate to https://github.com/benjamin-thompdx/doctor-lookup.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "doctor-lookup".
* Right-click "index.html" and select your preferred browser or text editor.

_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/benjamin-thompdx/doctor-lookup/issues) here on GitHub._

## Technologies Used

* C#
* .Net Core

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Patrick Kille & Benjamin Thom_**