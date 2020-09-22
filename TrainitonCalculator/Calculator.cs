using System;

namespace TrainitonCalculator {
    public class Calculator {

        public Calculator(string initialTextOnScreen) {
            _textOnScreen = initialTextOnScreen;
            _operation = "";
        }
        
        public string NumberPressed(string textOnButton) {
            if(_textOnScreen == "0") {
                _textOnScreen = textOnButton;
                return _textOnScreen;
            }
            else if (_startNew) {
                _textOnScreen = textOnButton;
                _startNew = false;
                return _textOnScreen;
            }
            _textOnScreen += textOnButton;
            return _textOnScreen;
        }

        public string ClearScreen() {
            _textOnScreen = "0";
            _operation = "";
            return _textOnScreen;
        }

        public string BackSpace() {
            if (_textOnScreen.Length > 1) {
                _textOnScreen = _textOnScreen.Remove(_textOnScreen.Length - 1);
            }
            else {
                _textOnScreen = "0";
            }
            return _textOnScreen;
        }

        public string Negate() {
            if(_textOnScreen == "0" || _textOnScreen == "0.") {
                return _textOnScreen;
            }
            else if (_textOnScreen.Contains("-")) {
                _textOnScreen = _textOnScreen.Replace("-", "");
            }
            else {
                _textOnScreen = $"-{_textOnScreen}";
            }
            return _textOnScreen;
        }

        public string Dot() {
            if (_textOnScreen.Contains(".")) {
                return _textOnScreen;
            }
            else {
                _textOnScreen += ".";
            }
            return _textOnScreen;
        }

        public string Sine() {
            var number = double.Parse(_textOnScreen);
            var converted = (number * Math.PI) / 180;
            var result = Math.Sin(converted);
            _textOnScreen = result.ToString();
            _lastAnswer = _textOnScreen;
            return _textOnScreen;
        }

        public void Add() {
            _startNew = true;
            _firstValue = _textOnScreen;
            _operation = "ADD";
        }

        public string EqualsTo(string secondValue) {
            switch (_operation) {
                case "ADD":
                    var first = double.Parse(_firstValue);
                    var second = double.Parse(secondValue);
                    var result = first + second;
                    _textOnScreen = result.ToString();
                    _lastAnswer = _textOnScreen;
                break;
                default:
                    return _lastAnswer;
            }

            return _textOnScreen;
        }

        private string _firstValue;
        private string _textOnScreen;
        private string _operation;
        private string _lastAnswer;
        private bool _startNew;
    }
}
