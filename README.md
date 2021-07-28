Capaz de desenvolver programas com a linguagem C#

Algoritmo, Estrutura de Dados, Fundamentos, OO, Coleções, Lambdas, Generics, Dynamics, LINQ e vários recursos dividos em 11 seções, quais sejam:


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

              -git config --global user.name "alfredo1995"  
              -git config --global user.email "alfredogomes1995@gmail.com" 
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
              
              
<br><br><br><br>

roteiro de teste

	descrever claramente o fluxo que vai ser desenvolvido
	
criar a branch 

	Repos > New Branch 
	feature/AG/ID-NomeDaHistoria

visual studio	remotes > develop > 

 	git fetch
   
Seleciona a branch da feature criada anteriomente : terminal

 	git pull 

Iniciar o desenvolvimento na nova branch

	implementar o novo fluxo do roteiro de teste

Primeiro requisito da Task 

	Se NÃO houver um processo de Aquisição (imóvel cadastrado) aberto:
Aquisição = vazio à SubStatus = Visita de Qualificação
Aquisição = vazio e Interesse Manifestado = verdadeiro à SubStatus = Manifestação de Interesse

Se HOUVER um processo de Aquisição (imóvel cadastrado) aberto:
Aquisição ≠ vazio e StatusAquisicaoImovel = Interesse Manifestado (atualmente devolve EmAberto – substituir por Interesse Manifestado) à Substatus = Análise Documental
Aquisição ≠ vazio e StatusAquisicaoImovel  = Análise Documental Concluída à Substatus = Formalização de Indicação
Aquisição ≠ vazio e StatusAquisicaoImovel   = Indicação Formalizada (atualmente “Formalizado indicação” substituir para "Indicação Formalizada") à Substatus = Estudos Técnicos
Aquisição ≠ vazio e StatusAquisicaoImovel   = Estudos Técnicos Concluídos à Substatus = Caderno Imobiliário
Aquisição ≠ vazio e StatusAquisicaoImovel   = Caderno Entregue à Substatus = Aprovação Caderno Imobiliário
Aquisição ≠ vazio e StatusAquisicaoImovel   = Caderno Aprovado à Substatus = Imóvel em Negociação


implementação do primeiro requisito > Back end > AtendimentoSocial.cs

	
	 if (Status != StatusAtendimentoSocial.EmAtendimento) return null;

                var aquisicoes = Aquisicoes?.Where(c => c.Excluido == false).ToList();

                if (aquisicoes == null || aquisicoes.Count == 0)
                {
                    return (this.InteresseManifestado == true) ? SubStatusAtendimentoSocial.ManifestacaoDeInteresseDoImóvel : SubStatusAtendimentoSocial.VisitaDeQualificacao;
                }

                if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.ManifestacaoDeInteresse)) return SubStatusAtendimentoSocial.AnaliseDocumental;
                if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.AnaliseDocumentalConcluida)) return SubStatusAtendimentoSocial.FormalizacaoDaIndicacaoDoImovel;
                if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.IndicacaoFormalizada)) return SubStatusAtendimentoSocial.EstudosTecnicos;
                if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.EstudosTecnicosConcluido)) return SubStatusAtendimentoSocial.CadernoImobiliario;
                if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.CadernoEntregue)) return SubStatusAtendimentoSocial.AprovacaoCadernoImobiliario;
                if (!aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.CadernoAprovado)) return SubStatusAtendimentoSocial.ImovelEmNegociacao;
                if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.Adquirido)) return SubStatusAtendimentoSocial.Adquirido;
                if (aquisicoes.Any(c => c.Status == StatusAquisicaoImovel.Cancelado)) return SubStatusAtendimentoSocial.ManifestacaoDeInteresseDoImóvel;

                return null;
	


Segundo requisito da Task

	StatusAquisicaoImovel  que devem ser criados:
       	   Análise Documental
     	   Estudos Técnicos
      	   Caderno Imobiliário
      	   Aprovação Caderno Imobiliário
        StatusAquisicaoImovel  que serão alterados:
           EmAberto = Manifestação de Interesse
           EmNegociacao = Imóvel em Negociação

Cenario 
	Cenário: Usuário altera o status do Imóvel para Adquirido
        Dado que o usuario realize a alteração do status do imóvel na aba Familiar Imóveis para Adquirido
	Quando houver um ou mais imóveis cadastrados
	Então o Status será alterado para Adquirido

implementação do segundo requisito da Task> Back end > StatusAquisicaoImovel.cs
	
	StatusAquisicaoImovel.cs > adicionar nova propriedade AnaliseDocumental = 8 no Enum 
	
	namespace RENOVA.Geral.Dominio.Enumeradores
        {

        public enum StatusAquisicaoImovel  {
          Ativo = 1,
          Cancelado = 2,
          Selecionado = 3,
          ManifestacaooDeInteresse = 4,
          Adquirido = 5,
          FormalizadoIndicacao = 6,
          ImovelEmNegociação = 7,
          AnaliseDocumental = 8,
          EstudosTecnicos = 9,
          CadernoImobiliario = 10,
          AprovaçãoCadernoImobiliario = 11,
        }}




git fetch 
git status
git add .
git commit -m ""
git push

