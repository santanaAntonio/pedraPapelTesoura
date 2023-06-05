import axios from "axios";

export const axiosInstance = axios.create({
    baseURL: "http://localhost:7297",
    timeout: 5000,
});