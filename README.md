Able to develop programs with the C# language 

Algorithm, Data Structure, Fundamentals, OO, Collections, Lambdas, Generics, Dynamics, LINQ and various resources.

       1) Introduction - algorithms, data structure and introduction to the .NET framework;

       2) Environment Configuration - steps necessary to configure the computer to run C#

       3) Fundamentals - Aims to establish solid foundations on the language;
     
       4) Control Structures - Here we will learn how to control the application flow;

       5) Classes & Methods - Here begins our journey through Object Orientation

       6) Collections - Data structures will be covered: array, lists, queues, stacks, dictionaries

       7) Object Orientation - The pillars of Object Orientation and how to apply it in practice;

       8) Methods and Functions - C# also supports resources from the functional world, functions, lambdas and methods
    
       9) Exceptions - Exceptions and error handling techniques
 
      10) Advanced Topics - Generics, LINQ, Dynamic, Nullables, etc.;
      
<br><br>
 
Creating a repository on GitHub

	- git init
	- git status
	- git add .
	- git commit -m "first commit" 
	- git branch -M main
	- git remote add origin https://github.com/alfredo1995/fdasd.git
	- git push -u origin main
	       
Uploading changes to the branch of an existing repository on github

	- git init                                                     ->  iniciar project no git
	- git status                                                   ->  ver alterações na branch
	- git add .  ou git add --all                                  ->  adicionando alterações
	- git commit -m "descriçãodocommit"                            ->  descrever o commit
	- git push -f                                                  ->  forçar envio pro git 

Frequently used GIT commands

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

creating the branch in Azure DevOps with GitBash

	Repos > New Branch 
	feature/AG/ID-NomeDaHistoria
	basead on Develop
	user story ID 
		
pulling the branch

	Selecionei a feature no visual studio e o code
	remotes > selecionar a branch criada feature/AG/ID-NomeDaHistoria
	
	git branch
	git fetch 	
	git pull
	git checkout -b feature/AG/322-NomeDaHistoria
	
rising to changes

	git fetch 
	git status
	git add .
	git commit -m "initial commit"
	git push,  git merge ou git push --set-upstream origin feature/AG/317-BotaoRelatorioExecel
	

<br><br>

creating branch in GitLab with GitHub DeskTop

	GitHub desktop > file > clone repository
	GitLab > copiar url https > colar no clone repository do GitHub Desktop
	GitHub Desktop > New Branch > name > select dev > create branch >
	Github Desktop > changes > commiit > Public branch > feature/322/AG-NomeDaHistoria
	GitLab > merge request > change branch dev > assine and review > create merge request
	
Getting updates from the current dev after creating a branch based on the old dev

	github desktop > minha branch criada > menu branch > merch into current branch > selecione a dev >
	solucionando confiltro no merge > open in visual studio code > acepter current branch

	
	
	
