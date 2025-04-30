<p align="center">
    <a href="https://decodo.com/"><img src="https://github.com/user-attachments/assets/209d01f2-3931-4e77-a6f3-0028b1ee2b72"></a>
  </a>
</p>

<p align="center">
    <a href="https://github.com/Decodo/Decodo"> Main Repository </a>
</p>

## Disclaimer

If you want to continue development with Node.js, we highly recommend reading their [documentation](https://nodejs.org/en/docs/).

## Prerequisites
To run the following code example, you'll need Node.js and the Axios HTTP client:
* [Node.js](https://nodejs.org/en/download/)
* [Axios](https://axios-http.com/)

You should also have a [Decodo account](https://dashboard.decodo.com/register) with access to the [dashboard](https://dashboard.decodo.com/residential-proxies/proxy-setup) to get your credentials and endpoint information.

## Installation

Once you have the prerequisites installed, follow these steps to set up your project:

1. Using the Command Prompt/Terminal, create your project directory using the `mkdir node_example` command.
2. Navigate to your project folder using the `cd node_example` command.
3. Copy the code directly from the above or execute the following command to download the proxy setup example file:

HTTP(s):
`curl https://raw.githubusercontent.com/Decodo/Decodo/master/nodejs/node.js > node.js`

SOCKS5:
`curl https://raw.githubusercontent.com/Decodo/Decodo/master/nodejs/node.js > nodesocks5h.js`

<img width="674" alt="image" src="https://github.com/user-attachments/assets/1e89f7f8-78aa-472c-b79a-95bf873ce3e2" />

4. You should see a new file named `node.js` in your project folder. Open it using a code editor of your choice.

5. To run this example, set your username, password, and endpoint information you'd like to use and enter them in the following sections of the code:
```
proxy: {
    host: 'gate.decodo.com'
    port: 7000,
    auth: {
        username: 'user',
        password: 'password'
    }
}
```
## Usage

To execute the Node.js example, simply run `node node.js`.

You should see an IP address in the console window if everything was set up correctly:

<img width="290" alt="image" src="https://github.com/user-attachments/assets/27b23578-9070-4af4-b8d7-7fa8a24bd25e" />

## Need help?
Email - sales@decodo.com

<a href="https://direct.lc.chat/12092754/">Live chat 24/7</a>
