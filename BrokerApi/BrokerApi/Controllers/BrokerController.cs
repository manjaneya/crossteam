using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApii.Models;

namespace BrokerWebApi.Controllers
{
    [RoutePrefix("api/broker")]
    public class BrokerController:ApiController
    {
        /// <summary>
        /// Post Customer designs to Broker
        /// </summary>
        /// <param name="model">CustomerDesignModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("posttobroker")]
        public IHttpActionResult PostCustomertoBroker([FromBody]CustomerDesignModel model)
        {
            CustomerDesignResponseModel customerDesignResponse = null;
            try
            {
                customerDesignResponse = new CustomerDesignResponseModel();
                customerDesignResponse.Customer = new Customer()
                {
                    Customerid = "09a209d0-6329-45d0-90e7-1622c9e65673",
                    Name = "Fred Flintstone",
                    Email = "Fred@foo.net",
                    PrimaryPhone = "5555555555",
                    SecondaryPhone = "7777777777",
                    Address = "123 Somewhere, Houston, TX 77377"
                };

                customerDesignResponse.Store = new Store()
                {
                    Associate = "jdoe123",
                    StoreNumber = "123",
                    StoreAddress = "123 Somewhere, Houston, TX 77377",
                    StorePhone = "7135551212"
                };

                List<Designs> designList = new List<Designs>() {
                    new Designs(){  AgreementNumber = "123-8888", DesignID = "2dbb565e-0123-ea77-5f8f-a7b08a8948df" },
                    new Designs() { AgreementNumber = "123-9999", DesignID = "bd3ee4dc-e0f2-2427-3abb-241cc75507e7" }
                };

                customerDesignResponse.Designs = designList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(customerDesignResponse);
        }


        /// <summary>
        /// Post Customer Design Response to Autobahn
        /// </summary>
        /// <param name="customerDesignResponseModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("posttocustomer")]
        public IHttpActionResult PostCustomerSessionId([FromBody]CustomerDesignResponseModel customerDesignResponseModel)
        {
            CustomerSessionModel customerSessionModel = new CustomerSessionModel() { SessionId = customerDesignResponseModel.Customer.Customerid.ToString() };
            return Ok(customerSessionModel);
        }
    }
}