import React from "react";
import { useState } from "react";

export default function Book(props) {
    const [showDescription, setShowDescription] = useState(false);

    return (
    <div onClick={() => {showDescription ? setShowDescription(false) : setShowDescription(true); console.log("test")}} className="w-[300px] min-h-[100px] border-solid border-slate-300 border-2">
        <p>{props.book.title}</p>
        <p>{props.book.pages}</p>
        {showDescription ? <p>{props.book.description}</p> : <p>{props.book.description.slice(5)}...Show more</p>}
    </div>
    )
}