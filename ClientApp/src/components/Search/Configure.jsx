import { useEffect, useRef, useState } from "react";
import classes from "./Configure.module.css";

const Configure = () => {
  const [isFormvisible,setFormVisible] = useState(false);
  const [searchEngines,setSearchEngines] = useState([]);

  useEffect(()=>{
      // fetch saved search engine form server
     // const response = await fetch('server')
     // const data = await response.json();
     setSearchEngines([{id:1, name:'Google'}])
  },[])

  const addressInputRef = useRef();
  const nameInputRef = useRef();

  function submitFormHandler(event) {
    event.preventDefault();

    const enteredTitle = addressInputRef.current.value;
    const enteredName = addressInputRef.current.value;
    // save the search engine call here
    //  fetch('URL', { method:'POST' , data: JSON.stringify({id:0, title:enteredTitle,name: enteredName})})
    // added search enigne returned via api can be added to existing list using :  setSearchEngines()
    setSearchEngines([{id:1 , name : 'Google' }])
    setFormVisible(false);
  }
  
  const AddSearchEngineHandler= ()=>{
    setFormVisible(true)
  }

  const deleteHandler = (id)=>{
      // send delet call from here
  }
  return (
    <>
      <button style={{marginTop : 5}} onClick={AddSearchEngineHandler}> Add Search Enigne</button>
     { isFormvisible &&
       <form className={classes.form} onSubmit={submitFormHandler}>
        <div className={classes.control}>
          <label htmlFor="name">Name</label>
          <input type="text" id="name" ref={addressInputRef} />
        </div>
        <div className={classes.control}>
          <label htmlFor="address">Address</label>
          <input id="address" ref={addressInputRef}></input>
        </div>
        <div className={classes.actions}>
          <button className="btn">Add</button>
        </div>
      </form>}
   
      <ul className={classes.list}>
        {searchEngines.map((engine) => (
          <li key={engine.id}>{engine.name} &nbsp;
           <button onClick={()=> deleteHandler(engine.id)}>Delete</button>
          </li>
           
        ))}
      </ul>
   
    </>

    
  );
};

export default Configure;
