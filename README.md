***Terminal***

```
cd C:\xampp\mysql\bin
```

```Acesso ao BD```

```
mysql -u root
```

***Criação do BD***

```
CREATE database db_agenda;

USE db_agenda;

CREATE TABLE contato (
    id INT AUTO_INCREMENT,
    nome VARCHAR(150),
    email VARCHAR(150),
    telefone VARCHAR(12),
    PRIMARY KEY(id)
);
```

```
SELECT * FROM contato;
```

***Instalação da Extensão do MySQL***

Gerenciador de Soluções -> Dependências -> Gerenciar Pacotes do NuGet... <br>
Procurar -> MySql.Data -> Instalar