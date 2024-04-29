import React from "react";
import Books from "./Books"
import { useState, useEffect } from "react";

function App() {
  const [users, setUsers] = useState([]);
  const url = "https://run.mocky.io/v3/ec912e06-8d6d-41a5-bd03-81e02063ef96";

  useEffect(() => {
    fetch(url)
      .then(response => response.json())
      .then(data => {
        setUsers(data);
      })
      .catch(error => console.log('Error', error))
  }, []);

  return (
    <>
      {/* <div><p>Users of our family friendly great and happy website!!!!</p></div>
      <div>
        {users.map((user,index) => (
          <div key={index}>
            <p>Name: {user.name}, Age: {user.age}</p>
          </div>
        ))}
      </div> */}
      <div className="w-full min-h-[100vh]">
        <Books />
      </div>
    </>
  );
}

export default App;