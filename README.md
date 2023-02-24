# estudogit
# Projeto de estudo de Git
Neste projeto o objetivo é apenas testar e estudar os comandos do git

## Comandos Iniciais

### git init
Inicializa o git naquele repositorio

### git status
Verifica a situação atual do repositorio


## Registro do Computador
### git config --global user.name "Usuario Nome"
### git config --global user.email "usuario@email.com"
### git config --list


## Gerar as chaves SSH
### ssh-keygen -t ed25519 -C "tlguibor@gmail.com"
Depois adicionar o arquivo .pub no github


## Comandos do dia a dia
### git add .
Seleciona os arquivos pra que farão parte da atualização
### git commit -m "message"
Registra uma versão informando do que se trata


## Tratando de Branchs
### git branch
Mostra as branch que tem atualmente
### git branch <novabranch>
Altera para a branch selecionada


### git checkout
Mostra as branch disponiveis
### git checkout <nomebranch>
Altera para a branch selecionada

### git checkout -b <branchlocal> origin/<branchremota>
### git fetch origin

### git branch -d nomebranch
Apagar a branch local

### git push origin --delete <brancremota>
Apagar a branch remota
