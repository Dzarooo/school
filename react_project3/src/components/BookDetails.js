import React from 'react';

function BookDetails(props) {
    return (
        <div className="border-solid border-[2px] border-black border-l-[0px] p-2">
            <p>BookDetails</p>
            {props.activeBook ? <p>{props.activeBook.description}</p> : <p>Select a book</p>}
        </div>
    )
}

export default BookDetails;