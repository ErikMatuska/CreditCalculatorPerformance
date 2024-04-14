import http from 'k6/http'

export let options = {
    vus: 1,
    duration: '5s'
};

export default function () {
    const person = {
        firstName: "string",
        lastName: "string",
        email: "string",
        dateOfBirth: "2024-01-01T00:00:00.000Z",
        companyId: 0
    };
    
    const payload = JSON.stringify(person, null, 2);
    const headers = { 'Content-Type': 'application/json' };
    http.post('https://localhost:7272/CreditCalculator', payload, { headers });
  }