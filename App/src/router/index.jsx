import {createBrowserRouter} from "react-router-dom";
import {PrivateRoute} from "./private-route.component";
import { ProfileSelection } from "../ui/screens/profile-selection/profile-selection";
import { Match } from "../ui/screens/match/match";

export const router = createBrowserRouter([
    {
        path: "/",
        element: <ProfileSelection/>,
    },
    {
        path: "/match",
        element: <PrivateRoute Screen={Match}/>,
    },
]);
