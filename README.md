# RTIC18-ProjetoPessoal-G1

# Descrição do Projeto "Escambo":

Escambo consiste em uma rede social em que os usuários podem fazer
requisições de certos serviços, ao mesmo tempo que podem fazer serviços a
outros usuários, sendo que todos os serviços serão essencialmente gratuitos.

O projeto tem como intenção dar oportunidade à pessoas de adquirir experiência
com trabalhos de sua área que ela se candidatar, enquanto fornece soluções gratuitas
a problemas e demandas simples. Além disso, os trabalhos feitos poderão ser exibidos
no linkedin do usuário.

O Contratante (usuário que faz uma requisição de serviço) poderá entrar em contato
com o Prestador (usuário que presta o serviço) e vice-versa, para discutir detalhes
do serviço. Portanto, um chat será necessário.

## Entidades:

### usuario
Além das variáveis padrão de um usuário (nome, email, cpf, entre outros), ele também possui:
- "credito", que é uma moeda referente ao tempo e à complexidade dos trabalhos feitos
- "link_linkedIn" do usuário (não obrigatório);
- "sobre", que é uma descrição do usuário (não obrigatório)

ele tem uma relação de 0-n com "conversa" e 0-n com "prestacao_servico"

### conversa
Guarda o id tanto do remetente quanto do destinatário e possui uma relação 0-n com "mensagem"

### mensagem
Guarda o id do remetente e do destinatário, a Data-hora e o conteúdo da mensagem

### prestacao_servico
Guarda o id do Contratante e do Prestador, além da Data-hora de inicio e de conclusão.
 Cada prestação possui 0-1 item

### item
É o produto final de uma prestacao_serviço (a qual sempre está exclusivamente relacionado a 
um). Possui a descricao do item, o credito  e a categoria. 