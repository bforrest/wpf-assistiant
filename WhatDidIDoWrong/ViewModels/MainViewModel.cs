using Assisticant;
using System.Windows.Input;
using System.Windows.Media;
using WhatDidIDoWrong.Models;
using WhatDidIDoWrong.Services;

namespace WhatDidIDoWrong.ViewModels
{
    public class MainViewModel
    {
        private readonly ApiServices apiServices;
        private readonly ResponseMessageModel response;

        public MainViewModel(ApiServices apiServices, ResponseMessageModel response)
        {
            this.apiServices = apiServices;
            this.response = response;
        }

        public string ActionName
        {
            get
            {
                return response.ActionName;
            }
            set
            {
                response.ActionName = value;
            }
        }

        public string JsonResponse
        {
            get
            {
                return response.JsonResponse;
            }
            set
            {
                response.JsonResponse = value;
            }
        }

        public bool IsSuccess
        {
            get
            {
                return response.IsSuccess;
            }
            set
            {
                response.IsSuccess = value;
            }
        }

        public Brush HeaderColor
        {
            get
            {
                if ( response.IsSuccess)
                {
                    return new BrushConverter().ConvertFrom(ResponseMessageModel.SuccessColor) as Brush;
                }
                else
                {
                    return Brushes.Red;
                }
            }
        }

        public ICommand GetApiReaderIssuersAsync
        {
            get
            {
                return MakeCommand.Do(delegate
                {
                    var msg = apiServices.GetApiReaderIssuersAsync();

                    ActionName = msg.ActionName;
                    JsonResponse = msg.JsonResponse;
                    IsSuccess = msg.IsSuccess;
                });
            }
        }

        public ICommand GetApiErrorResponse
        {
            get
            {
                return MakeCommand.Do(delegate
                {
                    ActionName = "Something that caused an error";
                    JsonResponse = "Forbidden";
                    IsSuccess = false;
                });
            }
        }
    }
}
