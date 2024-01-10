import Head from 'next/head'
import Header from '@/components/Header'
import Footer from '@/components/Footer'
import { useState, useEffect } from 'react';
import  axios from 'axios';

export default function Home() {
  const [clients, setClients] = useState([]);
 
  const fetchData = async () => {
    try {
      const response = await axios.get('https://localhost:7052/api/Usuarios');
      setClients(response.data);
    } catch (error) {
      console.error('Erro ao buscar dados: >> ', error);
    }
  };
 
  useEffect(() => {
    fetchData()
  }, [])

  return (
    <>
      <Head>
        <title>The Discoverer Experience</title>
      </Head>
        <Header/>
        <main>
        <div className="table-responsive">
              <table className="table">
                <thead>
                  <tr>
                    <th scope="col">ID do Usuário</th>
                    <th scope="col">Nome</th>
                    <th scope="col">CPF</th>
                    <th scope="col">Email</th>
                    <th scope="col">Ações</th>
                  </tr>
                </thead>
                <tbody>
                    {clients.map((cliente, index) => (
                    <tr key={index}>
                      <th scope="row">{cliente.id}</th>
                      <td>{cliente.nome}</td>
                      <td>{cliente.cpf}</td>
                      <td>{cliente.email}</td>
                      <td>
                          <a href=""
                              className="btn btn-primary btn-edit mb-1">
                              Editar
                          </a>
                          <a href=""
                              className="btn btn-danger btn-edit mb-1"
                              >
                              Excluir
                          </a>
                      </td>
                  </tr>
                  ))}
                </tbody>
              </table>
            </div>
        </main>
        <Footer/>
    </>
  )
}
