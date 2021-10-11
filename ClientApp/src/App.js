import { NavLink, Switch,Route } from 'react-router-dom';
import './App.css';
import Configure from './components/Search/Configure';
import SearchBar from './components/Search/SearchBar';

function App() {
  return (
    <div className="App">
      <header className="header">
      <nav className="nav">
        <ul>
          <li>
            <NavLink to="/">
               Search
            </NavLink>
          </li>
          <li>
            <NavLink to="/configure">
                Configure
            </NavLink>
          </li>
        </ul>
      </nav>
    </header>

     <Switch>
        <Route path="/" exact>
             <SearchBar />
        </Route>
        <Route path="/configure" >
             <Configure />
        </Route>
     </Switch>
 
       
    

    </div>
  );
}

export default App;
