using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    public class Director
    {
        //Attributes
        bool _answercorrect = true;
        string _userChoice = "";
        bool _isPlaying = true;
        int _cardOne = 0;
        int _cardTwo = 0;
        int _score = 0;
        int _totalScore = 300;
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        public void GetInputs() 
        {
            Card _cardOne = new Card();
            Card _cardTwo = new Card();

            Console.Write($"The card is: {_cardOne}");
            Console.Write("Higher or lower? [h/l] ");
            string _userChoice = Console.ReadLine();
           _isPlaying = (_userChoice == "h");
        }
        public void DoUpdates()
        {
            if (_cardOne > _cardTwo && _userChoice == "l") {
                _answercorrect = true;
                _totalScore = _score + 100;

            }
            else if (_cardOne < _cardTwo && _userChoice == "h"){
                _answercorrect = true;
                _totalScore = _score + 100;
            }
            else{
                _answercorrect = false;
                _totalScore = _score -75;
            }
        }
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
        }

        

            Console.WriteLine($"The second card is: {_cardTwo}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_score > 0 );
    }
}