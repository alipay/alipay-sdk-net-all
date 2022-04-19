using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskAccountbookQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskAccountbookQueryModel : AopObject
    {
        /// <summary>
        /// 资金代扣签约时的出资方uid
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }
    }
}
