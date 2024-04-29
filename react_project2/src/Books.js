import React from "react";
import { useEffect, useState } from "react";
import Book from "./Book";

function Books() {
    const [books, setBooks] = useState([]);
    const url = "https://run.mocky.io/v3/31a34e73-3f1c-4f1d-9a0d-06f66134e228";

    useEffect(() => {
      fetch(url)
        .then(response => response.json())
        .then(data => {
          setBooks(data);
        })
        .catch(error => console.log('Error', error))
    }, []);

    return (
        <div className="w-full h-[100vh] flex flex-col justify-center items-center">
            <h1 className="text-4xl mb-5">Books</h1>
                <div className="w-[620px] flex flex-wrap gap-5">
                    {books.map((book) => (
                        <Book book={book}/>
                    ))}
                </div>
        </div>
    )
}

export default Books;