import React from 'react';
import './App.css';
import Welcome from './Header';
import BowlerList from './BowlerList';

function App() {
  return (
    <div className="App">
      <Welcome />
      <BowlerList />
    </div>
  );
}

export default App;
