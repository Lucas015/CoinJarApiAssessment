using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Net;  
using System.Net.Http;
using CoinJarApiAssessment.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CoinJarApiAssessment.Controllers
{
    [ApiController]
    [Route("api/CoinJar")]
    public class CoinJarsController: ControllerBase
    {

        private ICoinJar _coinJar;
        public CoinJarsController(ICoinJar coinJar)
        {
            _coinJar = coinJar;
        }


        [HttpGet]
        public decimal Amount()
        {
            return _coinJar.GetTotalAmount();
        }

        [HttpPost]
        public void AddCoin(eCoinType coinType)
        {
            _coinJar.AddCoin(coinType);
        }

        [HttpPost]
        public void Reset()
        {
            _coinJar.Reset();
        }

    }
    
}