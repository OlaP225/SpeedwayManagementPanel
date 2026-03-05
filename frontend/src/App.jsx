
import {BrowserRouter, Routes, Route} from "react-router-dom";
import Dashboard from "./pages/Dashboard";
import Teams from "./pages/Teams";
import Players from "./pages/Players";
import Matches from "./pages/Matches";

 function App() {
  return (

    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Dashboard />} />
        <Route path="/teams" element={<Teams />} />
        <Route path="/player" element={<Players />} />
        <Route path="/matches" element={<Matches />} />
      </Routes>
    
    </BrowserRouter>


  )
 }

 export default App
