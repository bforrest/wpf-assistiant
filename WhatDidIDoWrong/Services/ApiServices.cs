using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatDidIDoWrong.Models;

namespace WhatDidIDoWrong.Services
{
    public class ApiServices
    {
        public ResponseMessageModel GetApiReaderIssuersAsync()
        {
            var response = new ResponseMessageModel
            {
                ActionName = "Get Issuers for Api User with [Read] permission"
            };

            response.JsonResponse = FakeIssuerResult;
            response.IsSuccess = true;
            return response;
        }

        private readonly string FakeIssuerResult = @"{
    'items': [
        {
            'id': 61,
            'abbreviation': 'AAC',
            'issuerName': 'AAC Group Holding Corp',
            'markitEntityId': '',
            'links': [
                {
                    'verb': 'get',
                    'rel': 'issuer',
                    'uri': 'http://localhost:50937/SecurityMaster/v1/Issuers/61'
                }
            ]
        },
        {
            'id': 2,
            'abbreviation': 'AB Acquisitions ',
            'issuerName': 'AB Acquisitions UK Topco 2 Limited',
            'markitEntityId': 'GB1L186079',
            'links': [
                {
                    'verb': 'get',
                    'rel': 'issuer',
                    'uri': 'http://localhost:50937/SecurityMaster/v1/Issuers/2'
                }
            ]
        },
        {
            'id': 3,
            'abbreviation': 'Alinta',
            'issuerName': 'Alinta Power Cat Pty Limited (fka BBP Finance)',
            'markitEntityId': 'AU1L334490',
            'links': [
                {
                    'verb': 'get',
                    'rel': 'issuer',
                    'uri': 'http://localhost:50937/SecurityMaster/v1/Issuers/3'
                }
            ]
        }
    ],
    'links': [
        {
            'verb': 'get',
            'rel': 'self',
            'uri': 'http://localhost:50937/SecurityMaster/v1/Issuers?PageNumber=1'
        },
        {
            'verb': 'post',
            'rel': 'add',
            'uri': 'http://localhost:50937/SecurityMaster/v1/Issuers'
        },
        {
            'verb': 'get',
            'rel': 'next',
            'uri': 'http://localhost:50937/SecurityMaster/v1/Issuers?PageNumber=2'
        }
    ]
}";

        public string FakeIssuerResult1 => FakeIssuerResult;
    }
}
