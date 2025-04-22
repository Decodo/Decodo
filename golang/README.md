<p align="center">
    <a href="https://decodo.com/"><img src="https://github.com/user-attachments/assets/209d01f2-3931-4e77-a6f3-0028b1ee2b72"></a>
  </a>
</p>

<p align="center">
    <a href="https://github.com/Decodo/Decodo"> Main Repository </a>
</p>

## Disclaimer
To continue development with Go, it's highly recommended to read their [documentation](https://golang.org/doc/).

## Prerequisites
You'll need the Go programming language installed and set up on your machine.
* [Download Go](https://golang.org/dl/)

You should also have a [Decodo account](https://dashboard.decodo.com/register) with access to the [dashboard](https://dashboard.decodo.com/residential-proxies/proxy-setup) to get your credentials and endpoint information.

## Installation
1. Create a directory for your project.
2. Open the directory using a Terminal tool utilizing the `cd` command.
3. Copy the code directly from [here](https://github.com/Decodo/Decodo/blob/master/golang/golang.go), or execute the following command to download the proxy setup example file:
 
`curl https://raw.githubusercontent.com/Decodo/Decodo/master/golang/golang.go > golang.go`

<img src="https://i.imgur.com/yZunHb6.png" alt="curl Decodo golang code sample">

4. You should see a new file named `golang.go` in your project folder. Open it using an editor of your choice.
5. To run this Go example, set your username, password, and endpoint information you'd like to use and enter them in the following sections of the code:
```
const (
    resourceUrl = "https://ip.decodo.com/json"
    proxyHost = "gate.decodo.com:7000"
    username = "username"
    password = "password"
)
```

## Usage

To execute the Go example, simply enter `go run golang.go` in your Terminal tool.

You should see an IP address in the console window if everything was set up correctly.

<img src="https://i.imgur.com/AtzZ4CU.png">

## Thanks

Big thanks to [@moeryomenko](https://github.com/moeryomenko) for submitting this code.

## Need help?
Email - sales@decodo.com

<a href="https://direct.lc.chat/12092754/">Live chat 24/7</a>
