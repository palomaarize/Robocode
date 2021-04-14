# Chegou a hora do Robozim brilhar!

#### O Robozim foi feito todinho usando o .NET Framework e está pronto para batalha no Robocode.
##### Ele funciona de modo que rastreia um inimigo e baseado no parâmetro de energia do mesmo toma a decisão de se aproximar e abatê-lo ou se afastar evitando o choque. A defesa do Robozim pode e dever ser melhorada, em compensação sua busca e posicionamento contra o inimigo é seu ponto forte.
##### Para apontar o seu canhão em direção ao inimigo ele conta com a função *AnguloNormal*, que como esperado, age para normalizar o valor de angulo passado como parâmentro na função, esse angulo é obtido através das variáveis *superApontar* e *apontar* que funcionam da seguinte forma:

| Varáveis        |  Função |
|-----------------|---------|
|  superApontar   | Pega a direção que o chassi do Robozim está apontando em graus  |
|                 | e soma com o angulo do robo adversário em relação ao Robozim.  |
|  apontar        | Pega o resultado da soma acima e passa por paramentro para a   |
|                 | função AnguloNormal subrtraindo pela direção que a arma do Robozim esta apontando.  |

##### Após o posicionamento necessário pra arma checa-se a temperatura dela para ir em frente e disparar.
##### Ao eliminar o adversário ele volta a buscar inimigos e travar batalhas até que não reste nenhum.

![](https://media.giphy.com/media/rhfxbPtm4m5uo/giphy.gif)

# Essa fase foi um amor!

##### Participar desa fase envolveu muita pesquisa e busca por melhores resultados, foi muito bom me desafiar, inclusive na documentação em inglês. Mas, o que mais gostei com certeza foi a sensação de dever cumprido de ver o Robozim prontinho e compilado com sucesso.
##### Obrigada pela oportunidade, e que venha a próxima fase!

![](https://media.giphy.com/media/VZXuygf0oUb5u/giphy.gif)