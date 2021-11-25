# Projeto Parcial 4 - Processamento Gráfico

## Especificações do projeto

Para este projeto, optamos por utilizar a ferramenta Unity, na sua versão `2018.4.20f1`.

### PP3

Para o PP3, criamos um ambiente 3D, com um bastão e uma bola de baseball, cada um deles sendo formato por figuras geométricas simples disponibilizadas pela própria ferramenta.

Também utilizamos um pacote adicional, disponibilizado pelo package manager do Unity, chamado de ProBuilder. Deste pacote, nós utilizamos a figura geométrica do cone, que serviu de base para o bastão.

Além disso, criamos três materiais para colorir os objetos, e utilizamos dois assets gratuitos da loja de assets do Unity apenas para complementar o ambiente do projeto, colocando uma textura de grama para o chão e um script de movimentação para a câmera. Desse modo, o ambiente 3D fica coloridinho e bonito e temos uma câmera móvel, permitindo que possamos observar os objetos em vários ângulos.

### PP4

Para o PP4, criamos uma simulação de movimentação com o bastão acertando a bola e a mesma voando. Também posicionamos algumas caixas em volta, para o caso da bola acertar outros objetos.

Colocamos algumas paredes em volta do cenário para evitar que os objetos da simulação saissem do cenário.

Criamos alguns scripts em C# para permitir as interações com a simulação, como iniciar a movimentação do bastão, reiniciar a simulação e trocar entre as duas câmeras disponíveis na simulação (uma para cada projeção presente no Unity).

Obs: É importante selecionar a cena correta, presente na pasta `scenes`, para visualizar e executar o projeto.

## Modo de interação

Com as teclas WASD, é possível andar pelo cenário 3D com a câmera.

Com o mouse, é possível rotacionar a câmera pelo cenário.

Outros botões importantes:
- "Z" - inicia simulação de movimento
- "R" - recomeça a simulação
- "X" - troca entre a câmera livre (projeção perspectiva) e a câmera da bola (projeção paralela/ortográfica)
 
## Caracterísiticas e elementos implementados

Lucas:
- Câmeras:
  - Criação de câmera da bola, na projeção paralela
  - Câmera padrão do Unity, na projeção perspectiva
  - Script de mudança de câmeras

Marcus:
- Movimentações:
  - Animação de movimentação do bastão
  - Movimentação da bola (e do suporte da bola) ao serem acertados pelo movimento do bastão
  - Movimentação das caixas
  - Movimentação do "Player", permitindo andar pela simulação
  
- Interações:
  - Colliders e rigidbodys para permitir colisão entre objetos
  - Scripts para iniciar e reiniciar simulação

## Grupo

- Lucas Martins Silva, RA: 620556
- Marcus Vinícius Natrielli Garcia, RA: 743578
