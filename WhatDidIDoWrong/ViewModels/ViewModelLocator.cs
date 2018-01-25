using Assisticant;
using WhatDidIDoWrong.Models;
using WhatDidIDoWrong.Services;

namespace WhatDidIDoWrong.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        public ViewModelLocator()
        {
            if (DesignMode)
            {
                response = new ResponseMessageModel
                {
                    IsSuccess = true,
                    JsonResponse = "{ \"json_response\" : \"not available\"}",
                    ActionName = "Initialized and Awating Action"
                };
            }
            else
            {
                response = new ResponseMessageModel();
            }
        }

        public object Main
        {
            get { return ViewModel(() => new MainViewModel(new ApiServices(), response)); }
        }

        private readonly ResponseMessageModel response;
    }
}
