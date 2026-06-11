using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceAccountmsgSendResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceAccountmsgSendResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("settle_account_id_list")]
        [XmlArrayItem("string")]
        public List<string> SettleAccountIdList { get; set; }
    }
}
