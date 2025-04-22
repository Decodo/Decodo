<p align="center">
    <a href="https://decodo.com/"><img src="https://github.com/user-attachments/assets/209d01f2-3931-4e77-a6f3-0028b1ee2b72"></a>
  </a>
</p>

<p align="center">
    <a href="https://github.com/Decodo/Decodo"> Main Repository </a>
</p>

## Disclaimer

To continue further development with Java, make sure to read their [documentation](https://docs.oracle.com/en/java/javase/12/).

## Prerequisites
To run the following code example, you'll need Java, the Java SE Runtime Environment (JRE) and an IDE set up on your machine:
- [Java](https://www.java.com/en/)
- [Java SE Runtime Environment 8](https://www.oracle.com/java/technologies/downloads/#java8)
- [Eclipse](https://eclipseide.org/)

You should also have a [Decodo account](https://dashboard.decodo.com/register) with access to the [dashboard](https://dashboard.decodo.com/residential-proxies/proxy-setup) to get your credentials and endpoint information.

## Installation

This particular code was built using [Eclipse](https://www.eclipse.org/).

If you choose to run the code using a different method or want to execute the script with the `javac` command, you may need to install the [Server JRE](https://www.oracle.com/java/technologies/downloads/#java8).

1. Create a project folder by running the following command in your Terminal tool:
```
mkdir java_example
```
2. Navigate to the main directory of your project folder using `cd java_example`.
3. Copy the code directly from [here](https://github.com/Decodo/Decodo/blob/master/java/java.java), or execute the following command to download the proxy setup example file:
```
curl https://raw.githubusercontent.com/Decodo/Decodo/master/java/java.java > java.java
```
<img src="https://i.imgur.com/4NpvtzU.png" alt="curl Decodo java code sample">

4. You should see a new file named `java.java` in your project folder. Open it using an editor of your choice.


## Configuration

To run this Java example, set your username, password, and endpoint information you'd like to use and enter them in the following sections of the code:

<img src="https://i.imgur.com/1LKiH1K.png" alt="Decodo Java proxy username password authentication">

## Usage

You should see an IP address in the console window if everything was set up correctly:

<img src="https://i.imgur.com/CS80lMb.png">

**Note:** If you're targeting HTTPS, the Basic Authentication scheme in some setups may not work (*error: "HTTP/1.1 407 Proxy Authentication Required"*). You can solve this issue by proxying HTTP, changing the authentication scheme of the proxy to Digest Authentication, or disabling Basic Authentication for HTTPS tunneling by setting the system property to *""* (blank) when running the code:

```
java -Djdk.http.auth.tunneling.disabledSchemes="" java.java
```

## Need help?
Email - sales@decodo.com

<a href="https://direct.lc.chat/12092754/">Live chat 24/7</a>
