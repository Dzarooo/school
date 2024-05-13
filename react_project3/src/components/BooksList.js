import React from 'react';
import { useState, useEffect } from 'react'

function BooksList(props) {
    const [books, setBooks] = useState([]);

    useEffect(() => {
        setBooks([
            {
                id:0,
                name:"Book1",
                description:"Description of book1"
            },
            {
                id:1,
                name:"Book2",
                description:"Description of book2"
            },
            {
                id:2,
                name:"Book3",
                description:"Description of book3"
            },
        ])
    }, []);

    function sendActiveBook(e) {
        props.setActiveBookOnClick(books[e.target.getAttribute('data-key')]);
    }


    return (
        <div className="border-solid border-[2px] border-black p-2">
            <h1>List of Books</h1>
            <div>
                {books.map((book) => {
                    return (
                        <p key={book.id} data-key={book.id} onClick={sendActiveBook}>{book.name}</p>
                    )
                })}
            </div>
        </div>
    )
}

export default BooksList;