<p align="center">
    <a href="https://decodo.com/"><img src="https://github.com/user-attachments/assets/209d01f2-3931-4e77-a6f3-0028b1ee2b72"></a>
  </a>
</p>

<p align="center">
    <a href="https://github.com/Decodo/Decodo"> Main Repository </a>
</p>

## What is a shell?
A shell is a program used to execute other programs through text commands. Windows operating systems use shells like **Command Prompt** or **PowerShell**. Linux and macOS use **Bash**, **Zsh**, or **Dash**. Each shell has its own syntax and features, although they generally provide similar functionality for interacting with the operating system.

## Prerequisites
Most operating systems come with at least one shell pre-installed by default. You can install a different shell if you prefer a different interface or a set of features.

You should also have a [Decodo account](https://dashboard.Decodo.com/register) with access to the [dashboard](https://dashboard.Decodo.com/residential-proxies/proxy-setup) to get your credentials and endpoint information.

## Installation

To use the shell script file, follow these steps:

1. Open the Command Prompt/Terminal.
1. Create your project directory using the `mkdir shell_example` command.
2. Navigate to your project folder using the `cd shell_example` command.
3. Execute the following command to download the example file:

`curl https://raw.githubusercontent.com/Decodo/Decodo/master/shell/shell.sh > shell.sh`

<img width="871" alt="image" src="https://github.com/user-attachments/assets/82fd378d-f428-4965-96f2-8c4b9c526e75" />

4. You should see a new file named `shell.sh` in your project folder. Open it using an editor of your choice.

5. Set your username, password, and endpoint information you'd like to use and enter them in the script:
```
curl -x gate.decodo.com:7000 -U "username:password" https://ip.decodo.com/json
```

## Usage

To execute the shell example, simply copy it and run it in your shell.
You should see the IP details from the target website in the console window if everything was set up correctly.

## Need help?
Email - sales@decodo.com

<a href="https://direct.lc.chat/12092754/">Live chat 24/7</a>

