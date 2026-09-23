using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradePreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePreQueryModel : AopObject
    {
        /// <summary>
        /// 卖家登录id
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }
    }
}
