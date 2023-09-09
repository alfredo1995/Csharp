Capaz de desenvolver programas com a linguagem C#

Algoritmo, Estrutura de Dados, Fundamentos, OO, Coleções, Lambdas, Generics, Dynamics, LINQ e vários recursos

      1) Introdução - algoritmos, estrutura de dados e introdução ao .NET framework;  

      2) Configuração do Ambiente - passos necessários para configurar o computador para executar o C#

      3) Fundamentos - Tem por objetivo estabelecer bases sólidas sobre a linguagem;
    
      4) Estruturas de Controle - Aqui aprenderemos a controlar o fluxo da aplicação;

      5) Classes & Métodos - Aqui inicia a nossa jornada pela Orientação a Objetos 

      6) Coleções - Estruturas de dados serão abordadas: array, listas, filas, pilhas, dicionários  

      7) Orientação a Objetos - Os pilares das Orientação a Objetos e como aplicar na prática; 

      8) Métodos e Funções - C# tb suporte recursos do mundo do funcional, funções, lambdas e métodos
    
      9) Exceções - Exceções e as técnicas de tratamento de erro
 
     10) Tópicos Avançados - Generics, LINQ, Dynamic, Nullables e etc;   
      
<br><br>
 
Criando um repositorio no GitHub

	- git init
	- git status
	- git add .
	- git commit -m "first commit" 
	- git branch -M main
	- git remote add origin https://github.com/alfredo1995/fdasd.git
	- git push -u origin main
	       
Subindo alterações na branch de um repositório existente no github

	- git init                                                     ->  iniciar project no git
	- git status                                                   ->  ver alterações na branch
	- git add .  ou git add --all                                  ->  adicionando alterações
	- git commit -m "descriçãodocommit"                            ->  descrever o commit
	- git push -f                                                  ->  forçar envio pro git 

Comandos GIT's utilizados frequentemente

	- git config --global user.name "alfredo1995"  	      	      -> configura o nome do usuario git
	- git config --global user.email "alfredogomes1995@gmail.com" -> configura email do usuario git
	- git clone <https://nome-do-link>                            -> baixar código-fonte existente	      
	- git branch -M main                                          -> Criar branches do projeto
	- git remote add origin https://github.com/alfredo1995/2.git  -> onde e o caminho de acesso github
	- git push -u origin main                                     -> confirma o push
	- git branch or git branch --list                             -> para ver as branches
	- git branch -d <nome-da-branch>                              -> deletar as branches
	- git checkout <nome-da-branch>                               -> alternar de um branch para outro
	- git checkout -b <nome-da-branch>                            -> criar e trocar para um branch
	- git reset --hard                                            -> desfazer alterações branch
	- git add -A                                                  -> para adicionar tudo de uma vez
	- git pull <remote>                                           -> obter update repositório remoto
	- git merge <nome-da-branch>                                  -> mesclar as branches
	- cd NomeDaPasta                                              -> cd acessa a pasta
	- .. 							      -> dois pontos volta a pasta
	- selecionar varios para alterar tudo vs code                 -> CTRL + D
    	- prop, aperta duas vezes tab                                 -> cria um atributo de class
	- shift + windows + s                                         -> print na tela em forma de recorte 
	- ctrl + k + d  ou shift + alt + f                            -> formata a indentação vs code e vs
	- ctrl + k + c                                                -> comentar visual studio e code  
	- ctrl + k + u                                                -> descomentar visual studio e code  
	- ctrl + shift + a ou shift + alt + a                         -> comentar e descomentar visual studio e code  



<br><br>

criando a branch no Azure DevOps com GitBash

	Repos > New Branch 
	feature/AG/ID-NomeDaHistoria
	basead on Develop
	user story ID 
		
puxando a branch
	
	Selecionei a feature no visual studio e o code
	remotes > selecionar a branch criada feature/AG/ID-NomeDaHistoria
	
	git branch
	git fetch 	
	git pull
	git checkout -b feature/AG/322-NomeDaHistoria
	
subindo a alterações
	
	git fetch 
	git status
	git add .
	git commit -m "initial commit"
	git push,  git merge ou git push --set-upstream origin feature/AG/317-BotaoRelatorioExecel
	

<br><br>

criando branch no GitLab com GitHub DeskTop

	GitHub desktop > file > clone repository
	GitLab > copiar url https > colar no clone repository do GitHub Desktop
	GitHub Desktop > New Branch > name > select dev > create branch >
	Github Desktop > changes > commiit > Public branch > feature/322/AG-NomeDaHistoria
	GitLab > merge request > change branch dev > assine and review > create merge request
	
Pegando atualização da dev atual apos criado a branch baseado na dev antiga

	github desktop > minha branch criada > menu branch > merch into current branch > selecione a dev >
	solucionando confiltro no merge > open in visual studio code > acepter current branch

	
	
	
