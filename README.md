# AWS Lambda S3 .NET Web API

Este repositório é um guia prático para gerenciar credenciais da AWS em aplicações .NET, cobrindo desde o desenvolvimento local até a implantação em serviços serverless como o AWS Lambda. O foco principal é a segurança e o uso correto do IAM (Identity and Access Management).

## 📋 Sobre o Projeto

Este projeto foi desenvolvido baseando-se no excelente guia [AWS Credentials for .NET Applications](https://codewithmukesh.com/blog/aws-credentials-for-dotnet-applications/) e inclui:

- ✅ Atualização completa para **.NET 10**
- ✅ Exemplos de integração com **AWS Lambda**
- ✅ Operações com **Amazon S3**
- ✅ Boas práticas de segurança para credenciais AWS
- ✅ Guia de migração de versões anteriores do .NET

## 🎯 Objetivos

- Demonstrar as melhores práticas para gerenciar credenciais AWS em aplicações .NET
- Fornecer exemplos práticos de integração com AWS Lambda e S3
- Facilitar a migração de projetos .NET para versões mais recentes
- Mostrar como configurar e validar credenciais em diferentes ambientes

## 🚀 Tecnologias Utilizadas

- **.NET 10**: Framework moderno e otimizado
- **ASP.NET Core Web API**: Para criar APIs RESTful
- **AWS SDK for .NET**: Para integração com serviços AWS
- **AWS Lambda**: Para computação serverless
- **Amazon S3**: Para armazenamento de objetos

## 📦 Estrutura do Projeto

```
aws-lambda-s3-dotnet-webapi/
├── README.md                    # Documentação principal
├── src/
│   ├── YourLambdaFunction/     # Projeto AWS Lambda
│   ├── YourWebApi/             # Projeto Web API
│   └── Shared/                 # Código compartilhado
├── docs/                        # Documentação adicional
└── tests/                       # Testes unitários
```

## 🔐 Gerenciamento de Credenciais AWS

### Desenvolvimento Local

1. **AWS Credentials File**
   ```
   ~/.aws/credentials
   [default]
   aws_access_key_id = YOUR_ACCESS_KEY
   aws_secret_access_key = YOUR_SECRET_KEY
   ```

2. **Environment Variables**
   ```bash
   export AWS_ACCESS_KEY_ID=your_access_key
   export AWS_SECRET_ACCESS_KEY=your_secret_key
   export AWS_REGION=us-east-1
   ```

3. **Configuration no appsettings.json**
   ```json
   {
     "AWS": {
       "Profile": "default",
       "Region": "us-east-1"
     }
   }
   ```

### Deployment em AWS Lambda

Para aplicações rodando em Lambda, use:

- **IAM Roles**: A forma mais segura de gerenciar credenciais
- **Environment Variables**: Para configurações específicas do ambiente
- **AWS Secrets Manager**: Para dados sensíveis

## 📚 Atualizações para .NET 10

Este projeto foi atualizado para aproveitar os benefícios do .NET 10:

- Melhorias de performance
- Novos recursos de linguagem C#
- Tooling aprimorado
- Melhor suporte a containerização

### Guia de Migração

Se você está migrando de versões anteriores do .NET, consulte:

- [.NET 10 Release Notes](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
- Pasta `/docs/migration-guide.md` neste repositório

## 🔧 Como Começar

### Pré-requisitos

- .NET 10 SDK instalado
- Conta AWS com credenciais configuradas
- Visual Studio 2022+ ou VS Code com C# extension

### Instalação

1. Clone o repositório
   ```bash
   git clone https://github.com/GuilhermeYasuda/aws-lambda-s3-dotnet-webapi.git
   cd aws-lambda-s3-dotnet-webapi
   ```

2. Restaure as dependências
   ```bash
   dotnet restore
   ```

3. Configure suas credenciais AWS (veja seção acima)

4. Execute o projeto
   ```bash
   dotnet run
   ```

## 🧪 Testes

Execute os testes unitários:

```bash
dotnet test
```

## 📖 Documentação Completa

Para documentação detalhada sobre:

- Configuração de credenciais
- Exemplos de uso com S3
- Deployment em Lambda
- Troubleshooting

Consulte a pasta `/docs` deste repositório.

## 🔗 Referências

- **Base**: [AWS Credentials for .NET Applications](https://codewithmukesh.com/blog/aws-credentials-for-dotnet-applications/)
- [AWS SDK for .NET Documentation](https://docs.aws.amazon.com/sdk-for-net/)
- [AWS Lambda Developer Guide](https://docs.aws.amazon.com/lambda/)
- [Amazon S3 API Reference](https://docs.aws.amazon.com/s3/latest/API/)
- [.NET Documentation](https://learn.microsoft.com/dotnet/)

## 💡 Boas Práticas de Segurança

✅ Nunca armazene credenciais no código-fonte
✅ Use IAM Roles sempre que possível
✅ Implemente princípio do menor privilégio
✅ Rotacione credenciais regularmente
✅ Use AWS Secrets Manager para dados sensíveis
✅ Ative logging e monitoramento

## 🤝 Contribuindo

Contribuições são bem-vindas! Por favor:

1. Faça um Fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## 👤 Autor

**Guilherme Yasuda**
- GitHub: [@GuilhermeYasuda](https://github.com/GuilhermeYasuda)

## 📧 Suporte

Para questões, problemas ou sugestões, abra uma [issue](https://github.com/GuilhermeYasuda/aws-lambda-s3-dotnet-webapi/issues) no repositório.

---

**Última atualização:** Maio de 2026

**Versão do .NET:** 10.0+
