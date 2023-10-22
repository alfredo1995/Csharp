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

	- git init                                                     ->  start project in git
	- git status                                                   ->  see branch changes
	- git add .  ou git add --all                                  ->  adding changes
	- git commit -m "descriçãodocommit"                            ->  describe the commit
	- git push -f                                                  ->  force push to git

Frequently used GIT commands

	- git config --global user.name "alfredo1995"  	      	      -> configure git username
	- git config --global user.email "alfredogomes1995@gmail.com" -> configure git user email
	- git clone <https://nome-do-link>                            -> download existing source code      
	- git branch -M main                                          -> Create project branches
	- git remote add origin https://github.com/alfredo1995/2.git  -> where is the github access path
	- git push -u origin main                                     -> confirm the push
	- git branch or git branch --list                             -> to see the branches
	- git branch -d <nome-da-branch>                              -> delete the branches
	- git checkout <nome-da-branch>                               -> switch from one branch to another
	- git checkout -b <nome-da-branch>                            -> create and switch to a branch
	- git reset --hard                                            -> undo branch changes
	- git add -A                                                  -> to add everything at once
	- git pull <remote>                                           -> get update remote repository
	- git merge <nome-da-branch>                                  -> merge branches
	- cd NomeDaPasta                                              -> cd access the folder
	- .. 							      -> colon back to folder
	- selecionar varios para alterar tudo vs code                 -> CTRL + D
    	- prop, aperta duas vezes tab                                 -> create a class attribute
	- shift + windows + s                                         -> print on the screen in the form of a cutout
	- ctrl + k + d  ou shift + alt + f                            -> format the indentation vs code e vs
	- ctrl + k + c                                                -> comment visual studio and code 
	- ctrl + k + u                                                -> uncomment visual studio and code
	- ctrl + shift + a ou shift + alt + a                         -> comment and uncomment visual studio and code



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

	
	
	
