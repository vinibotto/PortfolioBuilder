import { Container } from 'semantic-ui-react'
import NavBar from './NavBar'
import About from '../../features/About'

function App() {
  return (
    <>
      <NavBar />
      <Container style={{marginTop: '7em'}}>
        <About />
      </Container>
    </>
  )
}

export default App
