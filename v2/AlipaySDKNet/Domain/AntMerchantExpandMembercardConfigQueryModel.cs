using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardConfigQueryModel : AopObject
    {
        /// <summary>
        /// 商家的安心充配置的唯一编号， 如果有可以传；不传优先pid查询
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }
    }
}
