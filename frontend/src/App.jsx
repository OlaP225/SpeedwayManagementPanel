
import {BrowserRouter, Routes, Route} from "react-router-dom";
import Dashboard from "./pages/Dashboard";

import Sidebar from "./components/Sidebar";

import Teams from "./pages/Teams";
import Players from "./pages/Players";
import Matches from "./pages/Matches";


 function App() {
  return (

    <BrowserRouter>
      <div style={{display: "flex"}}>
        <Sidebar />
        <div style={{flex:1, padding: "20px"}}>
          <Routes>
            <Route path="/" element={<Dashboard />} />
            <Route path="/teams" element={<Teams />} />
            <Route path="/player" element={<Players />} />
            <Route path="/matches" element={<Matches />} />
          </Routes>
        </div>
      </div>
  
    </BrowserRouter>


  )
 }

 export default App
