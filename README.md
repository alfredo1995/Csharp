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
      
     11) Playlist no meu canal do youtube explicando cada exercicio: https://www.youtube.com/watch?v=PFRrl46Pnk0&list=PLk7LclgP8e9oIOKH7WRXt9pBlkl7Tnun1
<br>

Criando um repositorio no GitHub

	- git init
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

	- git config --global user.name "alfredo1995"  	      	      -> configura o nome  do usuario no git
	- git config --global user.email "alfredogomes1995@gmail.com" -> configura o email do usuario no git
	- git clone <https://nome-do-link>                            -> baixar código-fonte existente	      
	- git branch -M main                                          -> Criar branches do projeto
	- git remote add origin https://github.com/alfredo1995/2.git  -> onde e o caminho de acesso ao github
	- git push -u origin main                                     -> confirma o push
	- git branch or git branch --list                             -> para ver as branches
	- git branch -d <nome-da-branch>                              -> deletar as branches
	- git checkout <nome-da-branch>                               -> alternar de um branch para outro
	- git checkout -b <nome-da-branch>                            -> criar e trocar para um branch
	- git reset --hard                                            -> desfazer alterações branch com conflito
	- git add -A                                                  -> para adicionar tudo de uma vez
	- git pull <remote>                                           -> obter atualizações repositório remoto
	- git merge <nome-da-branch>                                  -> mesclar as branches
	- cd NomeDaPasta                                              -> cd acessa a pasta
	- .. 							      -> dois pontos volta a pasta
	- arrumar a indentação vs code e vs            		      -> SHIFT + ALT + F ou  CTRL + K + D   
	- comentar e descomentar visual studio e code                 -> CTRL + K + C    /   CRTL + K + U
	- comentar e descomentar visual studio e code                 -> CTRL + SHIFT + A /  SHIFT + Alt + A
	- selecionar varios para alterar tudo vs code                 -> CTRL + D
	- prop, aperta duas vezes tab                                 -> cria um atributo de class

<br><br>     

criando a branch no Azure DevOps

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
	git checkout -b feature/AG/322-modal-cancelamento-imovel
	
subindo a alterações
	
	git fetch 
	git status
	git add .
	git commit -m "initial commit"
	git push,  git merge ou git push --set-upstream origin feature/AG/317-BotaoRelatorioExecel
	
roteiro de teste de desenvolvimento das task referente a task da Sprint

	Cenário: Usuário acessa o Relatorio Planejamento Coletivos
	Dado que o usuário acesse o Relatorio Planejamento Coletivos
	Quando o usuário visualizar o Relatorio Planejamento Coletivos
	Então será visualizado a coluna Atendimento Coletivo, após “Id Auto Delimitação”;

	Cenário: Usuário acessa o Relatorio Planejamento Coletivos
	Dado que o usuário acesse o Relatorio Planejamento Coletivos
	Quando carregar a tabela do Relatorio Planejamento Coletivos
	Então serão listadas apenas as Modalidades: Coletivo bento e Coletivo Paracutu
	
requesito 1 da task

	Deverão ser incluídos os campos:
		
		Status_Do_Processo
		Atendimento Coletivo
		% do avanço (decimal)		
		Data Programada/Realizada (Date Time)
		ID Exclusivo do Project (int)

implementando requisito 1 , criando propriedade do objeto(tipo enum) na entidade ExecucaoObraEdificacao.cs

	public StatusExecucaoObraEdificacao Status_Do_Processo { get; set; }
        public const bool status_do_processo_obrigatorio = false;

setando a propriedade do objeto(tipo enum) no construtor e injetando a propriedade no response da entidade ExecucaoObraEdificacaoResponse.cs  (DePara)

	//chamando a propriedade do obj  ( fazendo build )
 	public StatusExecucaoObraEdificacao Status_Do_Processo_Id { get; set; }
        public ResponseEnum<StatusExecucaoObraEdificacao> Status_Do_Processo { get; set; }
	
	//injetando o obj no construtor do response da entidade ( chamando build )
	Status_Do_Processo_Id = obj.Status_Do_Processo;
        Status_Do_Processo = new ResponseEnum<StatusExecucaoObraEdificacao>(obj.Status_Do_Processo);

setando a propriedade do objeto no resquest da entidade
	
	//chamando por parametro
	public int? Status_Do_Processo_Id { get; set; }
	//instanciando objeto
	Status_Do_Processo = this.Status_Do_Processo_Id,
		
obs sobre a forma de criar e setar as propriendade do objeto nas entidades: 

     quando o obejeto e do tipo enum, na hora de setar os atributos no response e request e obrigatorio passar o id 
     quando o obejto  e do tipo int, na hora de setar os atributos no response e request apenas e necessario setar a propriedade direto, sem id
     
criando a propriedade do objeto(tipo int(nullable?)) na entidade ExecucaoObraEdificacao.cs

	public int? Status_Do_Processo { get; set; }
        public const bool status_do_processo_obrigatorio = false;

setando a propriedade do objeto(tipo enum(null))  no construtor e injetando a propriedade no response da entidade ExecucaoObraEdificacaoResponse.cs  (DePara)

	//chamando a propriedade do obj  ( fazendo build )
        public int? Status_Do_Processo { get; set; }
	
	//injetando no obj construtor response da entidade ( chamando build )
        Status_Do_Processo = obj.Status_Do_Processo;

setando a propriedade do objeto(tipo enum(null)) no resquest da entidade ExecucaoObraEdificacaoRequest.cs
	
	//instanciando objeto
	Status_Do_Processo = this.Status_Do_Processo,
	
<br><br>  

requisito 2 da task

	Exibir somente os atendimentos relacionados às seguintes Modalidades: 
	Coletivo Bento
	Coletivo Paracatu

mplementando requesito 2 acessando a controller da entidade  atendimentosocialcontroller.cs  

	[Route("relatorioPlanejamentoSocial")]

acessar o response dessa entidade onde a rota retorna uma listaResponse (enum) f12(acessar)

	 var response = PlanejamentoSocialHistoricoDatasResponse.ListaResponse(resultado);  //rertun colletion (lista)

acessada a entidade planejamentosocialhistoricodataresponse.cs
	
	//retornando toda colletion do response da entidade 
 	public static ICollection<PlanejamentoSocialHistoricoDatasResponse> ListaResponse(ICollection<PlanejamentoSocialHistoricoDatas> listaDominio)
        {
	
	ICollection<PlanejamentoSocialHistoricoDatasResponse> listaResponse = new Collection<PlanejamentoSocialHistoricoDatasResponse>();
	
	foreach (var item in listaDominio)
	
requisito entidade planejamentosocialhistoricodataresponse.cs

	Exibir somente os atendimentos relacionados às seguintes Modalidades: 
	Coletivo Bento
	Coletivo Paracatu
	
implementando requisito no foreach para que apenas retorne os atendimentos coletivo bento e paracuta

	//fazendo uma condição if()  para que o response dessa entidade retorne apenas um derteminado valor, em vez de tudo

		// if(se) item(lista). atendimentosocial(entidade). objeto da entidade(modalidade) ==(recebe) 
		//RENOVA.Geral.Dominio.Enumeradores.ModalidadeAtendimentoSocial vai dar a opção de onde esta vindo().
		//.Coletivo_Bento(acessando propriedade do objeto da entidade)
		
	foreach (var item in listaDominio)
        {
        if (item.AtendimentoSocial.Modalidade == RENOVA.Geral.Dominio.Enumeradores.ModalidadeAtendimentoSocial.Coletivo_Bento || item.AtendimentoSocial.Modalidade == RENOVA.Geral.Dominio.Enumeradores.ModalidadeAtendimentoSocial.Coletivo_Paracatu)
	
                {
		    //Exibir somente os atendimentos com os seguintes Status: Em Atendimento, Interrompido e Finalizado.
                    if (item.AtendimentoSocial.Status == RENOVA.Geral.Dominio.Enumeradores.StatusAtendimentoSocial.EmAtendimento || item.AtendimentoSocial.Status == RENOVA.Geral.Dominio.Enumeradores.StatusAtendimentoSocial.Interrompido || item.AtendimentoSocial.Status == RENOVA.Geral.Dominio.Enumeradores.StatusAtendimentoSocial.Finalizado)
                    {
                        var _response = new PlanejamentoSocialHistoricoDatasResponse(item);
                        listaResponse.Add(_response);
                    }
                }

            }	
		
<br><br>  

requisito 3 de calculo do status (id) de cada objeto

	% do avanço = 0 ("Não iniciado") 
	% do avanço entre 1 e 99% ("Em andamento")
	% do avanço = 100% ("Finalizado")

implementando requisito 3 de calculo no back end

	por padrão recebe get e usa set para setar os atributos
	para implementar uma função altera o metodo set pela função
	
implementando a função de calculo do status no back end ( ExecucaoObraEdificacao	

    public StatusExecucaoObraEdificacao StatusDoProcessoContencaoLote
        {
            get
            {
                return CalculoStatus(PorcentagemDoAvançoContencaoLote);
            }
                
                
         }
	 
	 
    private StatusExecucaoObraEdificacao? CalculoStatus(int? poncetagemAvanço)
        {
            if(poncetagemAvanço == null || poncetagemAvanço == 0)
            {
                return StatusExecucaoObraEdificacao.NaoIniciado;
            }else if (poncetagemAvanço > 00 && poncetagemAvanço < 100)
            {
                return StatusExecucaoObraEdificacao.EmAndamento;
            }else 
            {
                return StatusExecucaoObraEdificacao.NaoIniciado;
            }
        }


<br><br>
	
requisito  4 da Task

	StatusAquisicaoImovel  que devem ser criados:
     	   Manifestacaoo De Interesse Técnicos
      	   Selecionado

implementação requisito 4 da Task> Back end > StatusAquisicaoImovel.cs
	
	StatusAquisicaoImovel.cs > adicionar nova propriedade AnaliseDocumental = 8 no Enum 
	
	namespace RENOVA.Geral.Dominio.Enumeradores        {

        public enum StatusAquisicaoImovel  {
          Ativo = 1,
          Cancelado = 2,
          Selecionado = 3,
          ManifestacaooDeInteresse = 4,
          Adquirido = 5,         }}


<br><br>

requisito 5 da task

	Renomear o campo de data para “Data de Formalização da Alteração”. A data que o usuário fez a alteração também deverá ser salva no sistema e ficar disponível no relatório de dados históricos;
	
alterando o nome da propriedade do obj da entidade atendimentoSocial-modal-status.html

	 <label class="control-label">
            Data de Formalização da Alteração<span class="symbol required"></span>
         </label>

<br><br>  

requisito 6 da task

	O sistema deverá listar automaticamente o usuário logado como Responsável pela alteração.

criando a propriedade do objeto p/ response da entidade atendimoSocial-modal-statul-crtl.js

	 Usuario = $rootScope.user.name

recebendo request do back end setada na ControleRevisaoAtendimentoSocialcontroller.cs

	[Route("incluir")]
        [HttpPost]
        public IHttpActionResult Incluir([FromBody] ControleRevisaoAtendimentoSocialRequest request, ResponsavelRequest responsavel)
        {
            try
            {
                var obj = request.RetornoDominio();
                var resultado = _controleRevisaoAtendimentoSocialAppServico.Adicionar(obj, responsavel.Usuario);
                var response = new ControleRevisaoAtendimentoSocialResponse(resultado);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

                
setada na ControleRevisaoAtendimentoSocialcontrollerRequest.cs   

	 public string Usuario { get; set; }

injetou no construtor atendimentosocialcontrollerRequest.cs 
    
	Usuario = this.Usuario      

controleRevisaoatendimentosocialappservico.cs

	     private AtendimentoSocial NovoAtendimentoSocial(ControleRevisaoAtendimentoSocial entidade)
        {
            return new AtendimentoSocial
            {
                Atingido_Id = entidade.Atingido_Id,
                Usuario =  entidade.Usuario 
            };
        }

<br><br>  

requisito 7 da task

	Campo Novo Status: excluir as categorias: Aquisicao_Imovel DefinicaoDeLote AguardandoFicha atendimentosocial.cs 

atendimentosocail.cs

       public static StatusAtendimentoSocial[] StatusDoUniversoElegivel
        {
            get
            {
                return new StatusAtendimentoSocial[]
                {
                    //StatusAtendimentoSocial.AguardandoFicha,
                    //StatusAtendimentoSocial.Aquisicao_Imovel,
                    //StatusAtendimentoSocial.DefinicaoDeLote,
                    StatusAtendimentoSocial.EmAtendimento,
                    StatusAtendimentoSocial.Finalizado,
                    StatusAtendimentoSocial.Interrompido,
                    StatusAtendimentoSocial.InterrompidoNaoIniciado,
                };
            }
        }

<br><br>  

requisito 8 da task

	Exibir campo de Data de Cancelamento obrigatório. Data deverá ser lançada manualmente,
	uma vez que será considerada a data da evidência (ng-class e span-class)
	
implementando requisito 8 aquisicaoImovel-modal-status.html

	       <div class="form-group col-md-12 margin-top-10"
                ng-class="{'has-error':formAtendimentoSocialModalStatus.DataCancelamentoImovel.$dirty && formAtendimentoSocialModalStatus.DataCancelamentoImovel.$invalid, 'has-success':formAtendimentoSocialModalStatus.DataCancelamentoImovel.$valid}">
                <label class="control-label">
                    Data de Cancelamento<span class="symbol required"></span>
                </label>
                <input type="date"
                    class="form-control"
                    name="Data"
                    required
                    ng-model="controller.entidade.DataCancelamentoImovel">
                <span class="error text-small block" ng-if="formAtendimentoSocialModalStatus.DataCancelamentoImovel.$dirty && formAtendimentoSocialModalStatus.DataCancelamentoImovel.$error.required">Data é obrigatório</span>
            </div>

aquisicaoImovel-form-ctrl.js

	_vm.dados.entidade.CancelamentoImovel = registro.CancelamentoImovel;
	
implementando requisito 8 AquisicaoImovel.cs (back)

        public DateTime? DataCancelamentoImovel { get; set; }
        public const bool DataCancelamentoImovel_Obrigatorio = false;
	
AquisicaoImovelResponse.cs, setando o objeto e injetando no construtor

        public DateTime? DataCancelamentoImovel { get; set; }

        DataCancelamentoImovel = obj.DataCancelamentoImovel;

AquisicacaoImovelAlteracaoStatusRequest.cs, setando o objeto e injetando no construtor

        public DateTime? DataCancelamentoImovel { get; set; }
	
	DataCancelamentoImovel = DataCancelamentoImovel,

AquisicaoImovelConfiguracao.cs

     if (AquisicaoImovel.DataCancelamentoImovel_Obrigatorio) Property(c => c.DataCancelamentoImovel).IsRequired();
     else Property(c => c.DataCancelamentoImovel).IsOptional();

<br><br>

requisito 9 da task 

	Incluir campo de [Data de Cancelamento] no relatório “Planejamento Social RF”, 
	após [Situação do Imóvel]
	
implementando requisito 9 da task ( relatorioPlanejamentoFamiliar.ctrl.js )

            { Label: 'Data de Cancelamento do Imóvel', Id: 43 }

            entidade.Aquisicoes[0].DataCancelamentoImovel = entidade.Aquisicoes[0].DataCancelamentoImovel ? 
	    dataSemHora(entidade.Aquisicoes[0].DataCancelamentoImovel) : null
	    
relatorioPlanejamentoFamiliar.ctrl.js * function filtrarPorPeriodo

             case 43:
             atendimentosFiltrados = _vm.atendimentosArray.filter(function (atendimento) {
             return atendimento.Aquisicoes[0].DataCancelamentoImovel >= dataInicial &&
             atendimento.Aquisicoes[0].DataCancelamentoImovel <= dataFinal;});
	     
relatorioPlanejamentoFamiliar.ctrl.js * function filtrarMenorQue

             case 43:
             atendimentosFiltrados = _vm.atendimentosArray.filter(function (atendimento) {
             return atendimento.Aquisicoes[0].DataCancelamentoImovel <= DataCancelamentoImovel; });
             _vm.dados.tabela.data = atendimentosFiltrados;
	   
relatorioPlanejamentoFamiliar.ctrl.js * function filtrarMaiorQue

             case 43:
             atendimentosFiltrados = _vm.atendimentosArray.filter(function (atendimento) {
             return atendimento.Aquisicoes[0].DataCancelamentoImovel >= DataCancelamentoImovel  });
             _vm.dados.tabela.data = atendimentosFiltrados;

relatorioPlanejamentoFamiliar.ctrl.js * function definicaoDeColunas

	      ,{
	      name: 'Data de Cancelamento do Imóvel ',
              field: 'Aquisicoes[0].DataCancelamentoImovel',
              enableCellEdit: false,
              allowCellFocus: true,
              width: 200,
              visible: true,
              cellFilter: 'date:"dd/MM/yyyy"'
	      ,}



<br>L<br><br>

Configuração do ambiente de desenvolvimento Local back e front end

	1) clonar projetos Back e Front >
		Azure DevOps> Repos > Clonar ( back e front ) 
		Criar pasta Projeto> terminal git bash> git clone "endereçoProjetoASerClonado"
		
	3) inicialização do front end > 		
		baixar depedencia do Front end Packages
		vs code> terminal : npm start

	4) Configuração do back end >
		Ferramentas > Pacotes Nuget > Configurações pacote Nuget
		Adicionar um novo > Nome: nuget.org  Origem: https://api.nuget.org/v3/index.json
		Ferramentas > Pacotes Nuget > Gerenciador pacotes Nuget > restaurar	
		Pacote Nuget> Instalar o office ou a dependência Microsoft.interop.excel se necessario
		console gerenciador  > Update-Database -Verbose
		Definir a Api como projeto de inicialização > Limpar solução > ctrl + shift + b = copilar 

	5) Conexão com o banco de dados >
		Azure DevOps > Dowloado do banco de dados Renova
		SQL Server > Nome do servidor: (localdb)\MSSQLLocalDB > autenticação windows
		botao direito em cima do "banco de dados" > importar banco SQL Renova
		Conexão com a Conecte string > web.config > "nome da string de conexao"

	6) Inicialização do back end >
		vs 2019> Projeto Back End > Solução > Definir API como Projeto de inicialização
		terminal nuget > selecionar> projeto padrao : PROJETO.Infra.Dados
		terminal nuget > Update-Database -Verbose -f 
		Depuração : shift + f5
		
	7) cadastrar novos usuario
		backend entidade Atributo e Autenticação > Descomente o “return true”.
		F5 > abrir o Swagger > usuario > geral usuario post > modelo de parameters
		
		{
		  "Email": "alfredo.gomes@7070.com.br",
		  "Nome": "Alfredo Gomes",
		  "Senha": "7070",
		  "PrimeiroAcesso": true,
		}	
		
	8) Criando consulta para registros de novos Membros do Perfil no banco de dados
	
		SELECT *  FROM Usuarios
		
		SELECT *  FROM MembroDoPerfil
		WHERE Usuario_Id = 142

		INSERT INTO MembroDoPerfil VALUES (27, 143)

