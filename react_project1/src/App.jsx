import React, { useState } from 'react'
import Header from './Header'

function App() {
    const [count, setCount] = useState(0)

    return (
        <>
            <div>This is my app!</div>
            <p onClick={() => setCount(count + 1)}>clicker, you clicked me {count} times</p>
            <Header message="HELOŁ WORLD" />
        </>
    )
}

export default App