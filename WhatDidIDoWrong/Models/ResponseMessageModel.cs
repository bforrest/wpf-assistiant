using Assisticant.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDidIDoWrong.Models
{
    public class ResponseMessageModel
    {
        public ResponseMessageModel()
        {

        }
        public string ActionName
        {
            get => _actionName.Value;
            set => _actionName.Value = value;
        }

        public string JsonResponse
        {
            get => _jsonResponse.Value;
            set => _jsonResponse.Value = value;
        }

        public bool IsSuccess
        {
            get => _isSuccess.Value;
            set => _isSuccess.Value = value;
        }

        // Soothing blue
        public const string SuccessColor = "#4E87D4";

        // Red
        public const string WarningColor = "Red";

        private readonly Observable<String> _actionName = new Observable<string>();
        private readonly Observable<String> _jsonResponse = new Observable<string>();
        private readonly Observable<bool> _isSuccess = new Observable<bool>();
    }
}
