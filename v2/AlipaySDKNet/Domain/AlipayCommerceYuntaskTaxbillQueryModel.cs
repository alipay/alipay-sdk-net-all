using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskTaxbillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskTaxbillQueryModel : AopObject
    {
        /// <summary>
        /// 税筹签约用户的uid，此处指用户支付宝登录id
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }
    }
}
