<p align="center">
    <a href="https://decodo.com/"><img src="https://github.com/user-attachments/assets/209d01f2-3931-4e77-a6f3-0028b1ee2b72"></a>
  </a>
</p>

<p align="center">
    <a href="https://github.com/Decodo/Decodo"> Main Repository </a>
</p>

## Disclaimer

If you want to continue development with Python, we highly recommend reading their [documentation](https://docs.python.org/3/).

## Prerequisites
To run the following code example, you'll need Python installed:
* [Python](https://www.python.org/downloads/)

You should also have a [Decodo account](https://dashboard.Decodo.com/register) with access to the [dashboard](https://dashboard.Decodo.com/residential-proxies/proxy-setup) to get your credentials and endpoint information.
## Installation

Once you have Python installed, continue with the following steps:
1. Open the Terminal/Command Prompt.
2. Create your project directory using the `mkdir python_example` command.
3. Navigate to your project folder using the `cd python_example` command.
4. Execute the following command to download the proxy setup example file:

HTTP(s):
`curl https://raw.githubusercontent.com/Decodo/Decodo/master/python/python.py > python.py`

SOCKS5:
`curl https://raw.githubusercontent.com/Decodo/Decodo/master/python/pythonsocks5h.py > pythonsocks5h.py

<img width="689" alt="image" src="https://github.com/user-attachments/assets/10fb5ad8-145e-4e41-b43c-189179bf14eb" />

5. You should see a new file named `python.py` in your project folder. Open it using an editor of your choice.
6. To run this Python example, set your username, password, and endpoint information you'd like to use and enter them in the following sections of the code:
```
username = 'username'
password = 'password'

proxy = f'https://{username}:{password}@gate.decodo:7000'
```

## Usage

To execute the Python example, simply run `python python.py` in your Terminal tool.
You should see an IP address in the console window if everything was set up correctly:

<img src="https://i.imgur.com/S9ySUhh.png" alt="Decodo successful python connection example">

## Need help?
Email - sales@decodo.com

<a href="https://direct.lc.chat/12092754/">Live chat 24/7</a>
