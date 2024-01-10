import 'bootstrap/dist/css/bootstrap.min.css';
import Head from 'next/head'

export default function Footer() {
    return (
        <>
        <Head>
            <link rel="stylesheet" href="https://cdn.jsdelivr.net/gh/devicons/devicon@v2.15.1/devicon.min.css"/>
            <link rel="shortcut icon" href="@{/assets/favicon.png}" type="image/x-icon"/>
        </Head>
        <footer className="ft-cntt">
            <p id="p-footer"><strong>&copy; 2023 Erika Alves </strong>. Todos os direitos reservados.</p>
            <p>
                <a href="https://www.linkedin.com/in/alveserika/" target="_blank">
                    <i className="devicon-linkedin-plain"></i>
                </a>
                <a href="https://github.com/alvserika" target="_blank">
                    <i className="devicon-github-original"></i>
                </a>
            </p>
        </footer>
        </>
    )
}