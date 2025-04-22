const axios = require("axios");

const url = "https://ip.decodo.com/json";
const resp = axios.get(url, {
    proxy: {
        host: 'gate.decodo.com',
        port: 7000,
        auth: {
            username: 'username',
            password: 'password'
        }
    }
    
}). then(resp => {
    console.log(resp.data);
});
