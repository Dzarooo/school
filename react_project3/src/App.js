import React from "react";
import { useState } from "react";
import BookDetails from "./components/BookDetails";
import BooksList from "./components/BooksList";

function App() {

  const [activeBook, setActiveBook] = useState();

  function receiveActiveBook(book) {
    setActiveBook(book);
    console.log("new active book received in app.js");
    console.log(book);
  }

  return (
    <>
      <div className="flex flex-col w-full min-h-[100vh] items-center justify-center"> {/* container centering the whole content */}
        <div>HOLY BOOKS</div>
        <div className="flex">
          <BooksList setActiveBookOnClick={receiveActiveBook}/>
          <BookDetails activeBook={activeBook}/>
        </div>
      </div>
    </>
  );
}

export default App;
