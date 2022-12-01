# WebAPI

- Tecnologais: C#, Aps.net MVC, Framework=4.6.2
- Comunicação de dados com SQL Server
- Script de dados no arquivo:  nas pasta do projeto ScriptsDB, arquivo : ScripotDbAssociado.sql
- Configuração do ceonxão com banco em: Web.Config : 
  <connectionStrings>
    <add name="PVProautoEntities"       connectionString="metadata=res://*/Models.ModeloAssociados.csdl|res://*/Models.ModeloAssociados.ssdl|res://*/Models.ModeloAssociados.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=localhost\sql2019;initial catalog=PVProauto;persist security info=True;user id=sa;password=123456;multipleactiveresultsets=True;application name=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>



   Sistema
   
    Login através do CPF e Placa, podendo apenas alterar o endereço, 
	  a consulta de dados será feita via api do projeto:WsApiProAssociados(https://github.com/elterteodoro1478/WsApiProAssociados)
    
	    
		Florenço Trindade Alburquerque	CPF: 56704296050	Placa:GTX1650
		Maria Cristina Silveira			    CPF: 20937653063	Placa:KMS4891
		Geraldo Magela Guerra			      CPF: 33942569086	Placa:QTR1128
		Celso Futrado Silva				      CPF: 04394372020	Placa:GBW5348
		Roberto Barbosa					        CPF: 57860148005	Placa:MJH3090
		José Antônio Gama				        CPF: 39875497002	Placa:AFA9910
     
    
     
