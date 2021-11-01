import React from 'react'
import ReactDom from 'react-dom'
import App from './app.jsx'

const store = configureStore();

ReactDom.render(

    <App />,
    document.getElementById('content')
)
