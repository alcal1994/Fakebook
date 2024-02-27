import './App.css';
import Wrapper from './Containers/Wrapper.jsx';
import {
    createBrowserRouter,
    RouterProvider,
} from "react-router-dom";
import Profile from './Components/Profile.jsx';
import NewsFeed from './Components/NewsFeed.jsx';

function App() {

    const router = createBrowserRouter([
        {
            path: "/",
            element: <Wrapper><NewsFeed /></Wrapper>,
        },
        {
            path: "profile/:profileId",
            element: <Wrapper><Profile /></Wrapper>,
        },
    ]);

    return (
        <RouterProvider router = { router } />
    );
    
}

export default App;