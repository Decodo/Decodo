import requests

url = 'https://ip.decodo.com/json'
username = 'username'
password = 'password'

proxy = f'http://{username}:{password}@gate.decodo.com:7000'
  
response = requests.get(url, proxies={'http': proxy, 'https': proxy})

print(response.text)
