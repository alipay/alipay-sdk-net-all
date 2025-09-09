using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcTradeIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcTradeIdentityInfo : AopObject
    {
        /// <summary>
        /// 收单pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 一个收单身份下用来区分门店的id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
