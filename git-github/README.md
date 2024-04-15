# DIO | Resumos Git e Github

Arquivo para armazenar resumos sobre Git e Github do curso de versionamento de código da [Digital Innovation One](https://www.dio.me/)

## Documentação
- [Documentação Git](https://git-scm.com/doc)
- [Documentação GitHub](https://docs.github.com/pt)

## Resumos
| Comando | Função |
|-------|---------|
| `git init `| Inicia um repositório|
| `git status`| Mostra o status do repositório atual|
| `git add NomeDoArquivo`| Adiciona um arquivo ou diretório específico|
| `git add .` | Adiciona todos os arquivos untracked ao staged|
| `git clone URL` | Clona um repositório remoto|
|-----|------|
| `git commit -m` | Faz um commit com uma mensagem em string|
| `git commit --amend -m` | Muda a mensagem do último commit|
|-----|------|
| `git log` | Mostra os commits feitos no repositório`|
| `git restore NomeDoArquivo` | Restaura o arquivo para o último commit|
|-----|------|
| `git config --global` | Inicializa uma configuração glogal|
| ` user.name` | Configuração de username para git config|
| `user.email` | Configuração de email para git config|
| `Exemplo acima` | git config --global user.name "email@email"|
|-----|------|
| `git push origin main` | envia commits locais para repositorio remoto |
| `git pull origin main` | atualiza repositorio local com a branch especificada
| `git remote add upstream URL` | Adiciona o repositório remoto de um projeto fork
| `git pull upstream main` | atualiza repositorio local com repositório remoto do fork principal
|-----|------|
