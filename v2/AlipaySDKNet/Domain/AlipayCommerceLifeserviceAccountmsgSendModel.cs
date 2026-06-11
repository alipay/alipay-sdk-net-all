using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceAccountmsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceAccountmsgSendModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("settle_account_id_list")]
        [XmlArrayItem("string")]
        public List<string> SettleAccountIdList { get; set; }
    }
}
