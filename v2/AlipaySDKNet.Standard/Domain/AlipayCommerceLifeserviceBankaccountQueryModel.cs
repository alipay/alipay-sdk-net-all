using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceBankaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceBankaccountQueryModel : AopObject
    {
        /// <summary>
        /// 商家账号 2088
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
