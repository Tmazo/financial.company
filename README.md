# Financial company
Aplicação de finança do tipo WebAPI, utilizando a linguagem de programação C# e rodando em docker.

## Pré requisitos
1. Possuir o C# instalado;
2. Possuir o docker instalado;
3. Possuir o Postman em sua maquina. 

## Inicio do processo de execução da aplicação
1 - Copie a aplicação para a sua máquina

## Executando a aplicação
No Visual Studio rodar aplicação pela API. Este campo fica ao lado do "Any CPU"


### Url API 
Caminho camada de API: `https://localhost:49158`

#### Recursos da API
base path: https://localhost:49158

| Método    | Recurso                      | Descrição                  |
|---------- |:-----------------------------|:---------------------------|
| `GET`     | `/financial/name`            | Buscar o nome por id       |


| Método  	| Recurso                      | Descrição                 	|
|---------- |:-----------------------------|:--------------------------	|
| `POST`    | `/financial/calculate        | Realizar calculo total    	|

### Métodos

#### GET
Enviar o Id de busca através do header

#### POST
Enviar dois campos do header :
**Installments** -> número de parcelas.
**ValueInstallments** -> valor da parcela.
