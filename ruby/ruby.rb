require "uri" 
require 'net/http' 

proxy_host = 'gate.decodo.com' 
proxy_port = 7000 
proxy_user = 'username' 
proxy_pass = 'password' 

uri = URI.parse('https://ip.decodo.com/json') 
proxy = Net::HTTP::Proxy(proxy_host, proxy_port, proxy_user, proxy_pass) 

req = Net::HTTP::Get.new(uri.path) 

result = proxy.start(uri.host, uri.port, use_ssl: true) do |http| 
   http.request(req) 
end 

puts result.body 
