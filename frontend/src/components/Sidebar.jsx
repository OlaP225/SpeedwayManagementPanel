import { Link } from "react-router-dom";

function Sidebar () {
    return (
        <div style= {{width: "200px", backgroundColor: "#eee", padding: "20px", height: "100vh"}}>
            <h2> Panel zarządzania </h2>
            <ul>
                <li>
                    <Link to="/">Dashboard</Link>
                </li>
                <li>
                    <Link to="/teams">Teams</Link>
                </li>
                <li>
                    <Link to="/player">Players</Link>
                </li>
                <li>
                    <Link to="/matches">Matches</Link>
                </li>
            </ul>
    

        </div>

    )
}
export default Sidebar