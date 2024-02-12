import { Container, Menu } from "semantic-ui-react";

export default function NavBar(){
    return(
        <Menu inverted fixed='top'>  
            <Container>
                <Menu.Item header style={{fontSize: '20px'}}>Vinicius Botto</Menu.Item>
                <Menu.Item name='About' />
                <Menu.Item name='Contact' />
                <Menu.Item name='Projects' />
            </Container>
        </Menu>
    )
}
