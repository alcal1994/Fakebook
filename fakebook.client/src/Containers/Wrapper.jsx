import { useEffect, useState } from 'react';
import { Layout, Menu, theme, Avatar } from 'antd';
import { HomeOutlined, GlobalOutlined, UsergroupAddOutlined, UserOutlined } from '@ant-design/icons';
import SiteLogo from '../assets/fakebook.png';
import {
    Link,
} from 'react-router-dom';


const { Header, Content, Footer } = Layout;


function Wrapper({ children }) {
    const {
        token: { colorBgContainer, borderRadiusLG },
    } = theme.useToken();

    return (
        <Layout>
            <Header
                style={{
                    display: 'flex',
                    alignItems: 'center',
                    background: '#3c5898',
                }}
            >
                <img src={SiteLogo} style={{ height: '70px', width: '156px', padding: '10px' }} alt="Fakebook" />
                <Menu
                    theme="light"
                    mode="horizontal"
                    defaultSelectedKeys={['2']}
                    items={
                        [
                            {
                                key: "FriendRequests",
                                icon: <UsergroupAddOutlined style={{ color: "white", fontSize: '25px' }} />
                            },
                            {
                                key: "Home",
                                icon: <Link to="/"><HomeOutlined style={{ color: "white", fontSize: '25px' }} /></Link>,
                            },
                            {
                                key: "Notifications",
                                icon: <GlobalOutlined style={{ color: "white", fontSize: '25px' }} />,
                            }
                        ]
                    }
                    style={{
                        flex: 1,
                        minWidth: 0,
                        background: "#3c5898",
                    }}
                />
                <div>
                    <Link to="/profile/toBeChanged">
                        <Avatar size={44} icon={<UserOutlined style={{ color: "white", fontSize: '25px' }} />} />
                    </Link>
                </div>
            </Header>
            <Content
                style={{
                    padding: '0 48px',
                }}
            >
                <div
                    style={{
                        background: colorBgContainer,
                        minHeight: 280,
                        padding: 24,
                        borderRadius: borderRadiusLG,
                    }}
                >
                    {children}
                </div>
            </Content>
            <Footer
                style={{
                    textAlign: 'center',
                }}
            >
                Fakebook ©{new Date().getFullYear()} Created by Albert Calamatta
            </Footer>
        </Layout>
    );

}

export default Wrapper;
