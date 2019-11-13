import axios from 'axios';

const baseUrl = 'http://localhost:44337';


const getValues = () => new Promise((resolve, reject) => {
    axios.get(`${baseUrl}/values`).then((result) => {
        resolve(result.data);
    })
    .catch((error) =>{
        reject(error);
    })
});

export default {getValues};