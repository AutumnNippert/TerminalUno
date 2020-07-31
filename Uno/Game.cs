using System;
using System.Collections.Generic;
using System.Text;

namespace Uno
{
    public class Game
    {
        Card _topCard;
        Deck drawDeck;
        Deck offDeck;
        Player _playerOne;
        Player _playerTwo;
        Player _playerThree;
        Player _playerFour;


        public Game()
        {
            //initializing players
            this._playerOne = new PersonPlayer();
            this._playerTwo = new AiPlayer();
            this._playerThree = new AiPlayer();
            this._playerFour = new AiPlayer();
        }
        public void startGame()
        {
            drawDeck = new Deck();
            offDeck = new Deck();
            drawDeck.populate();
            dealHand();
            _topCard = drawDeck.draw();
            display();
        }
        public void dealHand()
        {
            for (int i = 0; i < 8; i++)
            {
                Card cardDrawn = drawDeck.draw();
                _playerOne.addCard(cardDrawn);
            }
            for (int i = 0; i < 8; i++)
            {
                Card cardDrawn = drawDeck.draw();
                _playerTwo.addCard(cardDrawn);
            }
            for (int i = 0; i < 8; i++)
            {
                Card cardDrawn = drawDeck.draw();
                _playerThree.addCard(cardDrawn);
            }
            for (int i = 0; i < 8; i++)
            {
                Card cardDrawn = drawDeck.draw();
                _playerFour.addCard(cardDrawn);
            }

        }
        public void display()
        {
            //_topCard likes to be null
            Console.Write(
@"                      "+this._playerThree.getHandCount()+ @"                       
                                             
                                                        
 "+this._playerFour.getHandCount()+@"               " + _topCard.toString()+ @"          " + this._playerTwo.getHandCount() + @"
                                                        
                                                        
                                                        
" + this._playerOne.displayHand());
            ConsoleKeyInfo cfi = Console.ReadKey();
            if(cfi.Key == ConsoleKey.UpArrow)
            {
                if(_playerOne.xPos > 0)
                {
                    _playerOne.xPos -= 1;
                }
            }
            if (cfi.Key == ConsoleKey.DownArrow)
            {
                if (_playerOne.xPos < _playerOne.getHandCount()-1)
                {
                    _playerOne.xPos += 1;
                }
            }
            if (cfi.Key == ConsoleKey.Enter)
            {
                if (_playerOne.xPos > _playerOne.getHandCount()-1)
                {
                    _playerOne.addCard(drawDeck.draw());
                }
                else
                {
                    if (!(_playerOne.playCard(_topCard, _playerOne.getCard(_playerOne.xPos)) == null))
                    {
                        this._topCard = _playerOne.playCard(_topCard, _playerOne.getCard(_playerOne.xPos));
                    }
                }
            }
                Console.Clear();
            display();
        }
    }
}