import logo from './logo.svg';
import './App.css';
import { router } from "./router";
import { RouterProvider } from 'react-router-dom';
import { GlobalUserProvider } from "./context/user/user.context";

function App() {
  return (
    <div className="App">
      <GlobalUserProvider>
      <RouterProvider router={router} />
      </GlobalUserProvider>
    </div>
  );
}

export default App;
/*
import {RouterProvider} from "react-router-dom";
import {ToastContainer} from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import {GlobalUserProvider} from "./context/user/user.context";
import "./index.css";
import {router} from "./router";

function App() {
    return (
        <div className="App">
            <GlobalUserProvider>
                <RouterProvider router={router}/>
                <ToastContainer
                    position='top-right'
                    autoClose={3000}
                    newestOnTop={false}
                    closeOnClick
                    rtl={false}
                    pauseOnFocusLoss
                    draggable
                    pauseOnHover
                    toastStyle={{backgroundColor: "black"}}
                />
            </GlobalUserProvider>
        </div>
    );
}

export default App;
*/