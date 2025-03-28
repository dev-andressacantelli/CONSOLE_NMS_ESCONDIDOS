Olá, este projeto é de minha autoria, portanto solicito respeito pelo meu trabalho e que não o plagie, mas fique à vontade para clona-lo para avaliação ou estudos.  
  
O objetivo deste projeto é avaliação técnica referente ao exercício descrito abaixo:  
  
O Quebra-Cabeça dos Números Escondidos   
Você foi contratado para desenvolver um sistema que ajude a resolver um antigo quebra-cabeça lógico chamado "Números Escondidos".  
O objetivo é encontrar todos os números inteiros positivos dentro de um intervalo dado [A, B] que satisfaçam as seguintes condições:  
● O número deve ser divisível por  C .   
● A soma dos dígitos do número deve ser maior ou igual a  D .   
● O número não pode conter nenhum dígito que esteja presente na lista  E .
   
Entrada   
Dois inteiros  A  e  B  (1 <  A  <  B  < 10000) representando o intervalo.   
- Um inteiro  C  (1 <  C  < 100) representando o divisor.  
- Um inteiro  D  (1 <  D  < 50) representando a soma mínima dos dígitos.  
- Uma lista de inteiros  E  (0 < tamanho(  E  ) < 10), onde cada elemento é 
um dígito único (0-9) que não pode estar presente no número.   
  
Saída   
Retorne uma lista de todos os números que satisfazem as condições acima, ordenados em ordem crescente.   
  
Caso de Exemplo   
Entrada     

int A = 10;   
int B = 50;  
int C = 5;   
int D = 5;   
List<int> E = new List<int> { 3, 7 };   
  
Processamento      
Intervalo: [10, 50]   
Divisível por 5: 10, 15, 20, 25, 30, 35, 40, 45, 50   
Soma dos dígitos > 5: 15 (1+5=6), 25 (2+5=7), 35 (3+5=8), 45 (4+5=9)   
Não contém os dígitos 3 ou 7: Elimina 35 (contém 3).   
  
Saída 
List<int> resultado = new List<int> { 15, 25, 45 };  

Tarefa   
Escreva uma função em C# chamada EncontrarNumerosEscondidos que implementa a lógica descrita acima.   
A assinatura da função deve ser:     
 
public static List<int> EncontrarNumerosEscondidos(int A, int B, int C, int D, List<int> E)  

Pontos de Avaliação   
● Compreensão do Problema: O candidato deve entender claramente as condições e como elas interagem entre si.   
● Implementação Eficiente: A solução deve ser eficiente e evitar cálculos desnecessários.    
● Organização do Código: O código deve estar bem estruturado, com funções auxiliares se necessário.   
● Tratamento de Casos Especiais: O candidato deve considerar casos extremos, como intervalos pequenos ou listas E vazias.   
● Testes: O candidato deve fornecer exemplos de testes para validar sua solução.   
