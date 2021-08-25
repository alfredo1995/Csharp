Capaz de desenvolver programas com a linguagem C#

Algoritmo, Estrutura de Dados, Fundamentos, OO, Coleções, Lambdas, Generics, Dynamics, LINQ e vários recursos


     1) Introdução - Temas abordados são: algoritmos, estrutura de dados e introdução ao .NET framework;  

     2) Configuração do Ambiente - Os passos necessários para configurar o computador para executar o C#;

      3) Fundamentos - Tem por objetivo estabelecer bases sólidas sobre a linguagem;
    
      4) Estruturas de Controle - Aqui aprenderemos a controlar o fluxo da aplicação;

      5) Classes & Métodos - Aqui inicia a nossa jornada pela Orientação a Objetos

      6) Coleções - Estruturas de dados clássicas serão abordadas: array, listas, filas, pilhas, dicionários

      7) Orientação a Objetos - Os pilares das Orientação a Objetos e como aplicar na prática;

      8) Métodos e Funções - O C# também suporte recursos do mundo do funcional, funções, lambdas e métodos;
    
      9) Exceções - Quando os erros ocorrem entram em cenas as exceções e as técnicas de tratamento de erro;

     10) Explorando API - Aprenderemos a mexer com arquivos, datas e intervalos de datas; 

     11) Tópicos Avançados - Generics, LINQ, Dynamic, Nullables e etc;
      
<br>


Subindo arquivos p/ um repositório no github

              - git init                                                     ->  iniciar project no git
              - git status                                                   ->  ver as alterações no projeto
              - git add --all                                                ->  add as alterações no projeto                                         
              - git push -f                                                  ->  pra forçar o envio e salvar no repositório
              - git commit -m "first commit"                                 ->  mensagem explicando a mudança no código
              - git branch -M main                                           ->  criar branches do projeto
              - git remote add origin https://github.com/alfredo1995/2.git   ->  onde e o caminho do acesso ao github
              - git push -u origin main                                      ->  confirmando o push


Atualizando arquivos existente de um repositório no github

              - git status                                                   ->  ver alterações na branch
              - git add .                                                    ->  adicionar as alterações no projeto
              - git commit -m "descriçãodocommit"                            ->  descrever o commit
              - git push -f                                                  ->  pra forçar o envio do arquivo pro git 


Comandos GIT's utilizados frequentemente

              - git config --global user.name "alfredo1995"  	      	    -> configurando o usuario do git
              - git config --global user.email "alfredogomes1995@gmail.com" -> configurando o email do usuario do git
              - git clone <https://nome-do-link>                            -> baixar o código-fonte existente de um repositório
              - git branch <nome-do-branch>                                 -> criar, listar e excluir branches
              - git push -u <remote> <nome-da-branch>                       -> criará uma branch localmente
              - git branch or git branch --list                             -> para ver as branches
              - git branch -d <nome-da-branch>                              -> deletar as branches
              - git checkout <nome-da-branch>                               -> alternar de um branch para outro
              - git checkout -b <nome-da-branch>                            -> criar e trocar para um branch
              - git git add <arquivo>                                       -> para adicionar arquivos     
              - git add -A                                                  -> para adicionar tudo de uma vez
              - git push -u origin <nome-do-branch>                         -> upload do branch 
              - git pull <remote>                                           -> obter atualizações do repositório remoto
              - git revert 'número do hash'                                 -> desfazer os commits
              - git log -- oneline                                          -> número do hash
              - git merge <nome-da-branch>                                  -> mesclar as branches
	      - cd NomeDaPasta                                              -> cd acessa a pasta
	      - .. 							    -> dois pontos volta a pasta
             
arrumar a indentação vs code e vs

	      SHIFT + ALT + F ou CTRL + K + D
              
	      

criar a branch

	Repos > New Branch 
	feature/AG/ID-NomeDaHistoria
	seleciona a branch a ser criada na develop
	
Subindo a branch
	
	git fetch 
		
selecionei a feature no visual studio e o code

	remotes > no lugar de devolop vai ser feature/AG/ID-NomeDaHistoria
	git pull

Subindo a branch 

	git fetch 
	git status
	git add .
	git commit -m ""
	git push

alteração nos campos da aplicação ... puxando a branch atualizada e mandando as alterações da nova 
	
	git fetch 
	git pull

subindo as alterações
	
	git status 
	git merge 
	git commit "descricao"
        git push
	
  
	      
<br>

Configuração do ambiente de desenvolvimento Local .NET Core 5 / Angular

	1) clonar projetos Back e Front >
		Azure DevOps> Repos > Clonar ( back e front ) 
		Criar pasta Renova> git bash> git clone "endereçoProjetoASerClonado"
	2) baixar depedencia do Front end Packages
		Cola depedencia > dentro da pasta front clonada

	3) inicialização do front end > 
		vs code> terminal : npm start

	4) Configuração do back end >
		Ferramentas > Pacotes Nuget > Configurações pacote Nuget
		Adicionar um novo > Nome: nuget.org  Origem: https://api.nuget.org/v3/index.json
		Ferramentas > Pacotes Nuget > Gerenciador pacotes Nuget > restaurar	
		Pacote Nuget> Instalar o office ou a dependência Microsoft.interop.excel
		Limpar solução > ctrl + shift + b = copilar 

	5) Conexão com o banco de dados >
		Azure DevOps > Dowloado do banco de dados Renova
		SQL Server > Nome do servidor: (localdb)\MSSQLLocalDB > autenticação windows
		botao direito em cima do "banco de dados" > importar banco SQL Renova
		Conexão com a Conecte string > web.config > "nome da string de conexao"

	6) Inicialização do back end >
		vs 2019> Projeto Back End > Solução > Definir API como Projeto de inicialização
		terminal nuget > selecionar> projeto padrao : RENOVA.Infra.Dados
		terminal nuget > Update-Database -Verbose -force 
		Depuração : shift + f5


<br><br><br><br>





Etapas de desenvolvimento de task

	desenvolvendo as tarefas da sprint
	
criar roteiro de teste
	
	exemplo de roteiro de teste

atualizar a develop no Azure DevOps com o roteiro de teste criado
	
	validação do roteiro de teste
	
criar a branch

	Repos > New Branch 
	feature/AG/ID-NomeDaHistoria
	seleciona a branch a ser criada na develop
	
Subindo a branch
	
	git fetch 
	git pull
	
selecionei a feature no visual studio e o code

	remotes > no lugar de devolop vai ser feature/AG/ID-NomeDaHistoria

requesito da task

	Deverão ser incluídos os campos:
	Contenção Lote
	Status do processo
	% do avanço (decimal)
	Data Prevista (Date Time)
	Data Programada/Realizada (Date Time)
	ID Exclusivo do Project (int)

implementando os requisitos da historia na sprint

	criando o objeto em ExecucaoObraEdificacao.cs

criando a propriedade do objeto(tipo enum) na entidade ExecucaoObraEdificacao.cs

	public StatusExecucaoObraEdificacao Status_Do_Processo { get; set; }
        public const bool status_do_processo_obrigatorio = false;

setando a propriedade do objeto(tipo enum) no construtor e injetando a propriedade no response da entidade ExecucaoObraEdificacaoResponse.cs  (DePara)

	//chamando a propriedade do obj no construtor ( fazendo build )
 	public StatusExecucaoObraEdificacao Status_Do_Processo_Id { get; set; }
        public ResponseEnum<StatusExecucaoObraEdificacao> Status_Do_Processo { get; set; }
	
	//injetando o obj response da entidade ( chamando build )
	Status_Do_Processo_Id = obj.Status_Do_Processo;
        Status_Do_Processo = new ResponseEnum<StatusExecucaoObraEdificacao>(obj.Status_Do_Processo);

setando a propriedade do objeto no resquest da entidade
	
	//chamando o parametro
	public int? Status_Do_Processo_Id { get; set; }
	//instanciando objeto
	Status_Do_Processo = this.Status_Do_Processo_Id,
	
	
obs sobre a forma de criar e setar as propriendade do objeto nas entidades: 

     quando o obejeto e do tipo enum, na hora de setar os atributos no response e request e obrigatorio passar o id 
     quando o obejto  e do tipo int, na hora de setar os atributos no response e request apenas e necessario setar a propriedade direto, sem id
     
criando a propriedade do objeto(tipo int(nullable)) na entidade ExecucaoObraEdificacao.cs

	public int? Status_Do_Processo { get; set; }
        public const bool status_do_processo_obrigatorio = false;

setando a propriedade do objeto(tipo enum(null))  no construtor e injetando a propriedade no response da entidade ExecucaoObraEdificacaoResponse.cs  (DePara)

	//chamando a propriedade do obj no construtor ( fazendo build )
        public int? Status_Do_Processo { get; set; }
	
	//injetando o obj response da entidade ( chamando build )
        Status_Do_Processo = obj.Status_Do_Processo;

setando a propriedade do objeto(tipo enum(null)) no resquest da entidade
	
	//chamando o parametro
	//instanciando objeto
	Status_Do_Processo = this.Status_Do_Processo,



subindo a alterações

	Update-Database
	git status 
	git merge 
	git commit "descriçao"
        git push





<br><br><br><br>



Exemplo de roteiro de teste

	Feature: #54 - Readequação da rotina Controle de Obra

	Sucesso:
	Cenário: Usuário acessa as telas Execução das Edificações de Bento
	Dado que o Usuário acesse a tela Execução das Edificações de Bento
	Quando o usuário acessar a tela Execução das Edificações de Bento
	Então deverá conter os novos campos de Contenção Lote: Status do processo, % do avanço, Data Prevista, Data Programada/Realizada

	Cenário: Usuário acessa a tela Execução das Edificações do Familiar
	Dado que o Usuário acesse a tela Execução das Edificações de Familiar
	Quando o usuário acessar a tela Execução das Edificações de Familiar
	Então deverá conter os novos campos de Contenção Lote: Status do processo, % do avanço, Data Prevista, Data Programada/Realizada

	Cenário: Usuário acessa a tela Execução das Edificações dos Gesteira
	Dado que o Usuário acesse a tela Execução das Edificações de Gesteira
	Quando o usuário acessar a tela Execução das Edificações de Gesteira
	Então deverá conter os novos campos de Contenção Lote: Status do processo, % do avanço, Data Prevista, Data Programada/Realizada


	
Exercitando a logica para entendimento dos requisito da Task 

		Se NÃO houver um processo de Aquisição (imóvel cadastrado) aberto:
		Aquisição = vazio à SubStatus = Visita de Qualificação
		Aquisição = vazio e Interesse Manifestado = verdadeiro à SubStatus = Manifestação de Interesse

	Se HOUVER um processo de Aquisição (imóvel cadastrado) aberto:
	
	Aquisição ≠ vazio e StatusAquisicaoImovel  = Análise Documental Concluída à Substatus = Formalização de Indicação	
	Aquisição ≠ vazio e StatusAquisicaoImovel   = Estudos Técnicos Concluídos à Substatus = Caderno Imobiliário


implementação o requisito > Back end > AtendimentoSocial.cs
	
	        if (Status != StatusAtendimentoSocial.EmAtendimento) return null;

                var aquisicoes = Aquisicoes?.Where(c => c.Excluido == false).ToList();

                if (aquisicoes == null || aquisicoes.Count == 0)
                {
                    return (this.InteresseManifestado == true) ? SubStatusAtendimentoSocial.ManifestacaoDeInteresseDoImóvel :   
		    SubStatusAtendimentoSocial.VisitaDeQualificacao;
                }

	if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.AnaliseDocumentalConcluida)) return SubStatusAtendimentoSocial.FormalizacaoDaIndicacaoDoImovel;
	if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.EstudosTecnicosConcluido)) return SubStatusAtendimentoSocial.CadernoImobiliario;
	if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.Adquirido)) return SubStatusAtendimentoSocial.Adquirido;
	if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.Cancelado)) return SubStatusAtendimentoSocial.ManifestacaoDeInteresseDoImóvel;

	return null;
	
	
Segundo requisito da Task

	StatusAquisicaoImovel  que devem ser criados:
     	   Manifestacaoo De Interesse Técnicos
      	   Selecionado

implementação do segundo requisito da Task> Back end > StatusAquisicaoImovel.cs
	
	StatusAquisicaoImovel.cs > adicionar nova propriedade AnaliseDocumental = 8 no Enum 
	
	namespace RENOVA.Geral.Dominio.Enumeradores        {

        public enum StatusAquisicaoImovel  {
          Ativo = 1,
          Cancelado = 2,
          Selecionado = 3,
          ManifestacaooDeInteresse = 4,
          Adquirido = 5,         }}

