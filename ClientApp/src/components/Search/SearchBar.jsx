import React, { useEffect, useState } from "react";
import Section from "../UI/Section";
import classes from "./SearchBar.module.css";

const SearchBar = (props) => {
  const [searchText, setSearchText] = useState("");
  const [searchEngines, setSearchEngine] = useState([]);
  const [selectedSearchengine, setSelectedSearchEngine] = useState();
  const [searchResult, setSearchResult] = useState([]);

  useEffect(() => {
    //TODO
    // Fetch registed SearchEngines
    // const respose = await fetch('serverAddress');
    // const data = await response.json();
    // example : data = [{ id:'1' , name: 'Google'} ,{id:'2' , name: 'Bing'}]; below dummy data
    const data = [
      { id: "1", name: "Google" },
      { id: "2", name: "Bing" },
    ];
    setSearchEngine(data);
   // can set 1st as default
    //  if(searchEngines && searchEngines.length >0)
    //   {
    //     setSelectedSearchEngine(searchEngines[0].id)
    //   }
    
  }, []);

  const searchInputHandler = (e) => {
    setSearchText(e.target.value);
  };

  const searchEngineDropdownHandler = (e) => {
    alert(e.target.value);
    setSelectedSearchEngine(e.target.value);
  };
  const submitHandler = (e) => {
    e.preventDefault();
    console.log(
      `selected search engine id ${selectedSearchengine} and name ${searchText}`
    );
    //TODO
    //call to server for search results using {selectedSearchengine} ${searchText}
    // fetch('serveraddress' , { methhod:'' , data : JSON.stringify({ id : selectedSearchengine , searchText: searchText })})
    // set response to setSearchResult , below dummy data
    setSearchResult([{id:'aSAJ', title: "Test", address: 'www.test.com?name="test"' }]);
  };

  return (
    <>
      <Section>
        <form className={classes.form} onSubmit={submitHandler}>
          <select
            value={selectedSearchengine}
            onChange={searchEngineDropdownHandler}
          >
            {searchEngines.map((engine) => {
              return (
                <option key={engine.id} value={engine.id}>
                  {engine.name}
                </option>
              );
            })}
          </select>

          <input type="text" value={searchText} onChange={searchInputHandler} />
          <button> Search </button>
        </form>
      </Section>
     
          {/* renders the search result here
            like 

           <Section>
            <ul>
                {searchResult.map(result => {
                    return  <li key={result.id} onClick={ () => linkOpenHanlder(result.address) }> { result.title } </li>
                })}
            </ul>
             </Section>
          */}
     
    </>
  );
};

export default SearchBar;
