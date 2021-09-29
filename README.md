Capaz de desenvolver programas com a linguagem C#

Algoritmo, Estrutura de Dados, Fundamentos, OO, Coleções, Lambdas, Generics, Dynamics, LINQ e vários recursos


      1) Introdução - algoritmos, estrutura de dados e introdução ao .NET framework;  

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
      
<br><br>

Subindo arquivos p/ um repositório no github

              - git init                                                     ->  iniciar project no git
              - git status                                                   ->  ver as alterações no projeto
              - git add --all                                                ->  add as alterações no projeto                                         
              - git push -f                                                  ->  pra forçar o envio e salvar no repositório
              - git commit -m "first commit"                                 ->  mensagem explicando a mudança no código

Atualizando arquivos existente de um repositório no github

              - git status                                                   ->  ver alterações na branch
              - git add .                                                    ->  adicionar as alterações no projeto
              - git commit -m "descriçãodocommit"                            ->  descrever o commit
              - git push -f                                                  ->  pra forçar o envio do arquivo pro git 

Comandos GIT's utilizados frequentemente

              - git config --global user.name "alfredo1995"  	      	    -> configurando o usuario do git
              - git config --global user.email "alfredogomes1995@gmail.com" -> configurando o email do usuario do git
              - git clone <https://nome-do-link>                            -> baixar o código-fonte existente de um repositório	      
              - git branch -M main                                          -> Criar branches do projeto
              - git remote add origin https://github.com/alfredo1995/2.git  -> onde e o caminho do acesso ao github
              - git push -u origin main                                     -> confirmando o push
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
	      - arrumar a indentação vs code e vs            		    -> SHIFT + ALT + F ou  CTRL + K + D   
	      - comentar e descomentar visual studio                        -> CTRL + K + C    /   CRTL + K + U
	      - comentar e descomentar visual studio                        -> CTRL + SHIFT + A /  SHIFT + Alt + A

<br><br>     
 

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
		console gerenciador  > Update-Database -Verbose
		Definir a Api como projeto de inicialização > Limpar solução > ctrl + shift + b = copilar 

	5) Conexão com o banco de dados >
		Azure DevOps > Dowloado do banco de dados Renova
		SQL Server > Nome do servidor: (localdb)\MSSQLLocalDB > autenticação windows
		botao direito em cima do "banco de dados" > importar banco SQL Renova
		Conexão com a Conecte string > web.config > "nome da string de conexao"

	6) Inicialização do back end >
		vs 2019> Projeto Back End > Solução > Definir API como Projeto de inicialização
		terminal nuget > selecionar> projeto padrao : RENOVA.Infra.Dados
		terminal nuget > Update-Database -Verbose -f 
		Depuração : shift + f5
		
	7) cadastrar novos usuario
		entidade do backend Atributo e Autenticação > Descomente o “return true”.
		abrir o Swagger > usuario > geral usuario post > modelo de parameters
		
		{
		  "Email": "alfredo.gomes@ketra.com.br",
		  "Nome": "Alfredo Gomes",
		  "Senha": "ketra123",
		  "PrimeiroAcesso": true,
		}	
		
	
		
<br><br>


criar a branch

	Repos > New Branch 
	feature/AG/ID-NomeDaHistoria
	
Subindo a branch
	
	Selecionei a feature no visual studio e o code
	remotes > no lugar de devolop vai ser feature/AG/ID-NomeDaHistoria
	git fetch 
	git pull

Subindo a branch 

	git fetch 
	git status
	git add .
	git commit -m ""
	git push

subindo as alterações nos campos da aplicação

	git status 
	git merge 
	git commit "descricao"
        git push
	  	      

<br><br><br><br>







Etapas de desenvolvimento das task referente a Sprint

	Implementando os requisitos da task
	
criar roteiro de teste

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

adicioanar o roteiro de teste da develop no Azure DevOps 

	validação do roteiro de teste
	
criar a branch do front e back

	Repos > New Branch 
	feature/AG/ID-NomeDaHistoria
	seleciona a branch a ser criada na develop
		
puxando a branch

	selecionei a branch (feature) no visual studio e o code
	remotes > no lugar de devolop vai ser feature/AG/ID-NomeDaHistoria
	git checkout <nome-da-branch>
	git fetch 
	git pull
	
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

	//chamando a propriedade do obj  ( fazendo build )
 	public StatusExecucaoObraEdificacao Status_Do_Processo_Id { get; set; }
        public ResponseEnum<StatusExecucaoObraEdificacao> Status_Do_Processo { get; set; }
	
	//injetando o obj no construtor do response da entidade ( chamando build )
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

	//chamando a propriedade do obj  ( fazendo build )
        public int? Status_Do_Processo { get; set; }
	
	//injetando no obj construtor response da entidade ( chamando build )
        Status_Do_Processo = obj.Status_Do_Processo;

setando a propriedade do objeto(tipo enum(null)) no resquest da entidade
	
	//chamando o parametro
	//instanciando objeto
	Status_Do_Processo = this.Status_Do_Processo,

	
requisito de calculo do status (id) de cada objeto

	% do avanço = 0 ("Não iniciado") 
	% do avanço entre 1 e 99% ("Em andamento")
	% do avanço = 100% ("Finalizado")

implementando requisito de calculo no back end

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


subindo a alterações
	
	Update-Database
	ctrl + shift + b
	adcionar todas as alteraçores em preparação	
	git status 
	git commit "descriçao"
        git push ou git merge



2.1) requisito
	Exibir somente os atendimentos relacionados às seguintes Modalidades: 
	Coletivo Bento
	Coletivo Paracatu

2.1) implementando requesito

//acessa a controller da entidade

atendimentosocialcontroller.cs  

	//acessar a rota da entidade
	[Route("relatorioPlanejamentoSocial")]

        //acessar o response dessa entidade onde retorna uma listaResponse (onde esta o nosso enum) f12
	 var response = PlanejamentoSocialHistoricoDatasResponse.ListaResponse(resultado);  .... rertonado um colletion (lista)

//coletion do response da entidade q foi chamada

planejamentosocialhistoricodataresponse.cs

	public static ICollection<PlanejamentoSocialHistoricoDatasResponse> ListaResponse(ICollection<PlanejamentoSocialHistoricoDatas> listaDominio)
        {

//entidade recebe um coletion( coletion retorna a lista toda)  all
// vou implementar o requisito fazendo uma condição if() 
// para que retorne apenas o atendimento coletivos bento e paracuta em vez de tudo 


// if(se) item(lista). atendimentosocial(entidade). objeto da entidade(modalidade) ==(recebe) vai dar a opção de onde esta vindo kkk. Coletivo_Bento(propriedade do objeto)

if (item.AtendimentoSocial.Modalidade == RENOVA.Geral.Dominio.Enumeradores.ModalidadeAtendimentoSocial.Coletivo_Bento || item.AtendimentoSocial.Modalidade == RENOVA.Geral.Dominio.Enumeradores.ModalidadeAtendimentoSocial.Coletivo_Paracatu)


	public static ICollection<PlanejamentoSocialHistoricoDatasResponse> ListaResponse(ICollection<PlanejamentoSocialHistoricoDatas> listaDominio)
        {
            if (listaDominio == null) return null;
            ICollection<PlanejamentoSocialHistoricoDatasResponse> listaResponse = new Collection<PlanejamentoSocialHistoricoDatasResponse>();
            foreach (var item in listaDominio)
            {
                if (item.AtendimentoSocial.Modalidade == RENOVA.Geral.Dominio.Enumeradores.ModalidadeAtendimentoSocial.Coletivo_Bento || item.AtendimentoSocial.Modalidade == RENOVA.Geral.Dominio.Enumeradores.ModalidadeAtendimentoSocial.Coletivo_Paracatu)
                {
                    if (item.AtendimentoSocial.Status == RENOVA.Geral.Dominio.Enumeradores.StatusAtendimentoSocial.EmAtendimento || item.AtendimentoSocial.Status == RENOVA.Geral.Dominio.Enumeradores.StatusAtendimentoSocial.Interrompido || item.AtendimentoSocial.Status == RENOVA.Geral.Dominio.Enumeradores.StatusAtendimentoSocial.Finalizado)
                    {
                        var _response = new PlanejamentoSocialHistoricoDatasResponse(item);
                        listaResponse.Add(_response);
                    }
                }

            }




<br><br><br><br>

	
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


<br><br><br><br>


requisito 1

	Renomear o campo de data para “Data de Formalização da Alteração”. A data que o usuário fez a alteração também deverá ser salva no sistema e ficar disponível no relatório de dados históricos;
	
alterando o nome da propriedade do obj da entidade atendimentoSocial-modal-status.html

	 <label class="control-label">
            Data de Formalização da Alteração<span class="symbol required"></span>
         </label>


requisito 2/1

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


requisito 2/2

	Este campo deve ficar disponível no relatório de dados históricos;

atendimentosocialconfiguração 

	    if (AtendimentoSocial.Usuario_Obrigatorio) Property(c => c.Usuario).IsRequired();
            else Property(c => c.Usuario).IsOptional();

requisito 3 

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

requisito 4

	Excluir o campo “Verificado por”;

atendimentosocial-modal-status.html 

	            <!-- <div class="form-group col-md-12"
                ng-class="{'has-error':formAtendimentoSocialModalStatus.VerificadoPor.$dirty && formAtendimentoSocialModalStatus.VerificadoPor.$invalid, 'has-success':formAtendimentoSocialModalStatus.VerificadoPor.$valid}">
                <label class="control-label">
                    Verificado por<span class="symbol required"></span>
                </label>

                <ui-select 
                    ng-model="controller.entidade.VerificadoPor"
                    ng-change="controller.entidade.VerificadoPor_Id=controller.entidade.VerificadoPor.Id;"
                    name="VerificadoPor" theme="bootstrap"
                    required>
                    <ui-select-match placeholder="Verificado por..." >
                        {{$select.selected.Individuo.Pessoa.Nome}}
                    </ui-select-match>
                    <ui-select-choices repeat="item in controller.listaRecursosHumanos | filter : $select.search">
                        <div ng-bind-html="item.Individuo.Pessoa.Nome | highlight: $select.search"></div>                        
                    </ui-select-choices>
                </ui-select>
                <span class="error text-small block" ng-if="formAtendimentoSocialModalStatus.VerificadoPor.$dirty && formAtendimentoSocialModalStatus.VerificadoPor.$error.required">Verificador é obrigatório</span>
            </div>  -->	

