using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBenefitSingleQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationBenefitSingleQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内券活动对象
        /// </summary>
        [XmlElement("activity_benefit")]
        public ActivityBenefit ActivityBenefit { get; set; }

        /// <summary>
        /// 会员权益
        /// </summary>
        [XmlElement("privilege_benefit")]
        public PrivilegeBenefit PrivilegeBenefit { get; set; }
    }
}
