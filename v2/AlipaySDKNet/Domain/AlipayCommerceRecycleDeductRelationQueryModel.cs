using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleDeductRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleDeductRelationQueryModel : AopObject
    {
        /// <summary>
        /// 二级商户pid
        /// </summary>
        [XmlElement("second_merchant_open_id")]
        public string SecondMerchantOpenId { get; set; }

        /// <summary>
        /// 二级商户pid
        /// </summary>
        [XmlElement("second_merchant_pid")]
        public string SecondMerchantPid { get; set; }
    }
}
