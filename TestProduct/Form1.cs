namespace TestProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #include "stdafx.h"
#include <iostream>
#include <Windows.h>

using namespace System;
    using namespace System::Windows::Forms;

    const int mazeWidth = 10;
    const int mazeHeight = 10;

    // Function to draw the maze
    void drawMaze(array<array<Char>^>^ maze, Graphics^ g)
    {
        for (int i = 0; i < mazeHeight; i++)
        {
            for (int j = 0; j < mazeWidth; j++)
            {
                switch (maze[i][j])
                {
                    case '#': // Wall
                        g->FillRectangle(Brushes::Blue, j * 50, i * 50, 50, 50);
                        break;
                    case '.': // Empty space
                        g->FillRectangle(Brushes::White, j * 50, i * 50, 50, 50);
                        break;
                    case 'P': // Player
                        g->FillEllipse(Brushes::Yellow, j * 50, i * 50, 50, 50);
                        break;
                }
            }
        }
    }

    public Form1()
    {
        this->Width = mazeWidth * 50;
        this->Height = mazeHeight * 50;
        this->Paint += gcnew PaintEventHandler(this, &PacmanForm::PacmanForm_Paint);
        this->KeyDown += gcnew KeyEventHandler(this, &PacmanForm::PacmanForm_KeyDown);
    }

    void PacmanForm_Paint(Object^ sender, PaintEventArgs^ e)
    {
        Graphics ^ g = e->Graphics;
        drawMaze(maze, g);
    }

    void PacmanForm_KeyDown(Object^ sender, KeyEventArgs^ e)
    {
        switch (e->KeyCode)
        {
            case Keys::W: // Move up
                if (maze[playerY - 1][playerX] != '#')
                {
                    maze[playerY][playerX] = '.';
                    playerY--;
                }
                break;
            case Keys::S: // Move down
                if (maze[playerY + 1][playerX] != '#')
                {
                    maze[playerY][playerX] = '.';
                    playerY++;
                }
                break;
            case Keys::A: // Move left
                if (maze[playerY][playerX - 1] != '#')
                {
                    maze[playerY][playerX] = '.';
                    playerX--;
                }
                break;
            case Keys::D: // Move right
                if (maze[playerY][playerX + 1] != '#')
                {
                    maze[playerY][playerX] = '.';
                    playerX++;
                }
                break;
            case Keys::Q: // Quit the game
                Application::Exit();
                break;
            default:
                break;
        }

        this->Invalidate();
    }
}
}