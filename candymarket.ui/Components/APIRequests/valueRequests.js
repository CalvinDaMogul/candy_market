import axios from 'axios';

const baseUrl = 'http://localhost:50555/api';


const getValues = () => new Promise((resolve, reject) => {
    axios.get(`${baseUrl}/values`).then((result) => {
        resolve(result.data);
    })
    .catch((error) =>{
        reject(error);
    })
})