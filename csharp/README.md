<p align="center">
    <a href="https://decodo.com/"><img src="https://github.com/user-attachments/assets/209d01f2-3931-4e77-a6f3-0028b1ee2b72"></a>
  </a>
</p>

<p align="center">
    <a href="https://github.com/Decodo/Decodo"> Main Repository </a>
</p>

## Disclaimer

This code example best suits people with at least a beginner's experience using the C# programming language.

## Prerequisites

To run this code you'll need a C# compiler such as [Visual Studio](https://visualstudio.microsoft.com/). You can follow [this tutorial](https://learn.microsoft.com/en-us/visualstudio/get-started/visual-basic/tutorial-console?view=vs-2022) to create a simple Visual Basic console application.

You should also have a [Decodo account](https://dashboard.decodo.com/register) with access to the [dashboard](https://dashboard.decodo.com/residential-proxies/proxy-setup) to get your credentials and endpoint information.

## Installation

The example is built using Visual Studio. You can run it by following these steps:

1. Create a new Console App.
2. Using a terminal of your choice, navigate to the project's directory.
3. Copy the code from [here](https://raw.githubusercontent.com/Decodo/Decodo/master/csharp/csharp.cs) or run this cURL command to download the code:

`curl https://raw.githubusercontent.com/Decodo/Decodo/master/csharp/csharp.cs > csharp.cs`

4. You should see a new file named *csharp.cs* in your project folder.

## Usage

To run this C# example, set your username, password, and endpoint information you'd like to use and enter them in the following sections of the code:

```
var proxy = new WebProxy("gate.decodo.com:7000")
{
    UseDefaultCredentials = false,

    Credentials = new NetworkCredential(
        username: "username",
        password: "password",
    )
};
```

You should see an IP address in the console window if everything was set up correctly.

<img src="https://i.imgur.com/wKh9fj7.png">

## Need help?
Email - sales@decodo.com

<a href="https://direct.lc.chat/12092754/">Live chat 24/7</a>
