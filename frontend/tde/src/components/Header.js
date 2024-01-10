import { useState } from "react";
import { navLinks } from "../constants/data.js";
import 'bootstrap/dist/css/bootstrap.min.css';

export default function Header() {
  const [links, setlinks] = useState(navLinks)

  console.log(navLinks)

  return (
    <header className="container-fluid bg-white">
    <h1>The <span>Discoverer</span> Experience</h1>
    <p>Start exploring the best places in the entire world!</p>
    
    <nav>
      <ul className="nav nav-pills justify-content-center">
        {
           navLinks.map(({ text, page, index }) => {
              <li key={index} class="nav-item"> 
                <a class="nav-link active" href={page}>{text}</a> 
              </li>
          })
        }
        <li className="nav-item"> 
          <a className="nav-link active" href="/reserva">Cadastros</a> 
        </li>
      </ul>
    </nav>
    </header>
  )
}