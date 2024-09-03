using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CreditInfoResponse : AopObject
    {
        /// <summary>
        /// 芝麻信用下单页面地址
        /// </summary>
        [XmlElement("credit_page_link")]
        public string CreditPageLink { get; set; }
    }
}
