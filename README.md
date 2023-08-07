# PIWithCSharp

# PI Setup SSH key access and Samba for file transfer

Source : https://github.com/ATGNI/RaspberryPi/tree/main
Youtube: https://www.youtube.com/watch?v=TS4DNGByIoc

# Install .net 7

https://www.petecodes.co.uk/install-and-use-microsoft-dot-net-7-with-the-raspberry-pi/

# Run Code

Install Visual code with c# extension

Add to launch json, access to PI need to edited.

    {
        "name": ".NET Core Launch (remote)",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "RaspberryPiDeploy",
        "program": "dotnet",
        "args": ["/home/obenyaala/${workspaceFolderBasename}/${workspaceFolderBasename}.dll"],
        "cwd": "/home/obenyaala/${workspaceFolderBasename}",
        "stopAtEntry": false,
        "console": "internalConsole",
        "pipeTransport": {
            "pipeCwd": "${workspaceFolder}",
            "pipeProgram": "ssh",
            "pipeArgs": [
                "obenyaala@obenyaala"
            ],
            "debuggerPath": "/home/obenyaala/vsdbg/vsdbg"
        }
    }
    
Add to task.
    {
        "label": "RaspberryPiPublish",
        "command": "sh",
        "type": "shell",
        "dependsOn": "build",
        "windows": {
            "command": "cmd",
            "args": [
                "/c",
                "\"dotnet publish -r linux-arm64 -o bin\\linux-arm64\\publish --self-contained\""
            ],
            "problemMatcher": []
        }
        
    },
    {
        "label": "RaspberryPiDeploy",
        "type": "shell",
        "dependsOn": "RaspberryPiPublish",
        "presentation": {
            "reveal": "always",
            "panel": "new"
        },
        "windows": {
            "command": "copy bin\\linux-arm64\\publish\\ -Destination P:${workspaceFolderBasename} -Recurse -Container:$false"
        },
        "problemMatcher": []
    }


# Usefull Links

https://www.youtube.com/watch?v=atsN-LNaIO0&t=196s

https://www.youtube.com/watch?v=bJSSU5YuHKg

https://learn.microsoft.com/en-us/dotnet/iot/deployment

https://github.com/ATGNI/RaspberryPi/blob/main/Episode%201/Instructions.md

https://github.com/ATGNI/RaspberryPi/blob/main/Episode%202/Instructions.md

https://www.petecodes.co.uk/deploying-and-debugging-raspberry-pi-net-applications-using-vs-code/

https://www.petecodes.co.uk/install-and-use-microsoft-dot-net-7-with-the-raspberry-pi/

https://github.com/golaat/Adafruit.Pwm

https://github.com/dotnet/iot/blob/main/src/devices/ServoMotor/README.md

https://github.com/dotnet/iot/blob/main/src/devices/MotorHat/README.md

https://learn.sparkfun.com/tutorials/raspberry-gpio/gpio-pinout
