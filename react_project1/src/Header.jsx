import React from 'react'

function Header(props) {
    return (
        <>
            <h1>This is my header!</h1>
            <h2>{props.message}</h2>
        </>
    )
}

export default Header