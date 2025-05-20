
# Tic Tac toe C#

Projetinho simples desenvolvido no curso técnico de Desenvolvimento de sistemas feito na aula do dia 19/05 do proposito de fazer um jogo da velha no c# usando windons forms, o projeto em si foi muito de boa por que fizemos com a supervisão do profeesro Estevão 

🕹️ Jogo da Velha em C# com Windows Forms
Este é um simples projeto de Jogo da Velha (Tic-Tac-Toe) desenvolvido em C# utilizando a tecnologia Windows Forms (WinForms). É uma aplicação de interface gráfica (GUI) onde dois jogadores podem se alternar para jogar.

🚀 Tecnologias Utilizadas
C#

Windows Forms (WinForms)

Visual Studio (recomendado)

🧩 Funcionalidades
Interface gráfica com 9 botões representando o tabuleiro 3x3

Alternância entre os jogadores "X" e "O"

Verificação automática de vitória ou empate

Reinício de jogo sem reiniciar o programa

📦 Como Executar o Projeto
Clone este repositório:

bash
Copiar
Editar
git clone https://github.com/seu-usuario/jogo-da-velha-winforms.git
Abra o projeto no Visual Studio

Compile e execute pressionando F5 ou clicando em Start

🛠️ Estrutura do Projeto
Form1.cs: Contém o código da interface gráfica e a lógica do jogo

Program.cs: Ponto de entrada da aplicação

Recursos adicionais (ícones, fontes, etc.) podem estar na pasta Resources/

📚 Como o Jogo Funciona
Cada célula do tabuleiro é representada por um botão (Button).

Ao clicar em um botão, o texto é alterado para "X" ou "O", dependendo do jogador atual.

O programa verifica se houve vitória (3 iguais na horizontal, vertical ou diagonal) ou empate.

Após o fim do jogo, uma mensagem é exibida e os botões são resetados para iniciar outra partida.

✏️ Exemplo de Código (Verificação de Vitória)
csharp
Copiar
Editar
private bool VerificarVitoria()
{
    // Exemplo de verificação horizontal
    if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
        return true;
    
    // Outras verificações (vertical, diagonal) seguem o mesmo padrão
    return false;
}


