# E-DOC - Gerador de Documentos Fiscais

## 📄 Sobre o Projeto

O **E-DOC** é um aplicativo simples e eficiente criado para facilitar a geração de documentos fiscais. Ele combina características de **nota fiscal** e **ordem de serviço**, permitindo a geração de um **Documento Eletrônico** com informações essenciais de transações comerciais. O sistema foi desenvolvido pensando em microempresas que precisam organizar e gerar documentos de forma rápida, prática e sem complicação.

Com uma interface gráfica intuitiva, o usuário pode inserir dados como:

- Nome do Cliente
- CNPJ do Cliente
- Valor do Serviço/Produto
- Endereço, Cidade e Bairro
- Data do Serviço/Venda
- Número do Orçamento
- Dados da Empresa
- E muito mais!

Após inserir os dados, o sistema gera automaticamente um arquivo `.txt` bem estruturado com todas as informações.

## 🚀 Funcionalidades

- **Interface Gráfica Intuitiva:** Interface simples e amigável, projetada para facilitar o uso.
- **Geração de Arquivos `.txt`:** O sistema gera um arquivo `.txt` com os dados preenchidos para fácil armazenamento ou compartilhamento.
- **Limpeza de Campos:** Um botão para limpar todos os campos e reiniciar o processo de criação de documentos.
- **Exibição Automática do Arquivo Gerado:** O arquivo gerado é automaticamente aberto no Bloco de Notas para fácil visualização.
- **Exportação para PDF sem framework:** Permite exportar o documento gerado para PDF através da funcionalidade "Imprimir" do bloco de notas, no qual o usuário pode escolher a opção de salvar como PDF.
  
## 🛠 Tecnologias Utilizadas

- **C# com Windows Forms:** A aplicação foi desenvolvida utilizando a linguagem C# e a plataforma Windows Forms, que oferece uma maneira rápida de criar interfaces gráficas simples.
- **.NET Framework:** Utilizado para dar suporte à construção do aplicativo e garantir que ele seja estável e compatível com o sistema operacional Windows.

## 📝 Como Usar

1. **Baixe o Executável:** Faça o download do .zip do projeto e extraia.
2. **Abrir o Aplicativo:** Clique no aplicativo e-doc para iniciar.
3. **Criar Documento:**
   - Clique em **Criar Documento**.
   - Preencha os campos com as informações necessárias, como nome do cliente, CNPJ, valor do serviço/produto, e dados da empresa.
4. **Gerar e Exibir Arquivo `.txt`:**
   - Clique em **Mostrar TXT** para gerar o arquivo e visualizá-lo imediatamente no Bloco de Notas.
5. **Exportar para PDF:**
   - No menu "Arquivo", clique em **Imprimir**.
   - Escolha a opção de **salvar como PDF** e defina o local para salvar o arquivo.
6. **Limpar Dados Anteriores:** Se precisar criar um novo documento, clique em **Limpar dados anteriores** para resetar os campos.

## 📌 Roadmap Futuro

O E-DOC está em constante evolução. Aqui estão algumas das funcionalidades previstas para o futuro:

- **Exportação Nativa para PDF:** Adicionar suporte direto para exportação de documentos como arquivos PDF sem depender de impressão.
- **Integração com Banco de Dados:** Implementar armazenamento de documentos em um banco de dados para facilitar o acesso e a gestão de documentos.
- **Melhoria no Design da Interface:** Tornar a interface ainda mais intuitiva e agradável para o usuário, incluindo novas opções de customização e visualizações.

## 🤝 Contribuição

Contribuições são bem-vindas! Se você deseja contribuir para o E-DOC, siga estas etapas:

1. **Faça um Fork do Repositório:** Crie um fork do repositório para começar a trabalhar na sua versão local.
2. **Crie uma Branch:** Crie uma branch para sua funcionalidade ou correção de bug.
3. **Faça Commit das Mudanças:** Faça commits claros e concisos com uma descrição explicativa do que foi alterado.
4. **Envie um Push:** Após realizar os commits, envie um push para a branch do seu fork.
5. **Abra um Pull Request:** Abra um Pull Request para que possamos revisar suas mudanças e, se apropriado, integrá-las ao projeto.

Se você tiver alguma dúvida ou sugestão, não hesite em abrir uma **issue** no repositório para discutir!

## 📜 Licença

Este projeto é distribuído sob a **Licença MIT**. Você pode ver mais detalhes no arquivo [LICENSE](LICENSE).

---

Agradecemos por sua visita ao repositório do **E-DOC**. Esperamos que este projeto ajude muitas microempresas a otimizar sua geração de documentos fiscais e aumentar a eficiência no dia a dia!
