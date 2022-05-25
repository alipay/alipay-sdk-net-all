using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBrandsolutionEnrollmerchantQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationBrandsolutionEnrollmerchantQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动状态，枚举：WAIT_AUDIT（审核中）/AUDIT_FAIL（审核拒绝）/AUDIT_SUCCESS（审核通过）/PAUSE（暂停）
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 活动报名商家权益信息
        /// </summary>
        [XmlArray("merchant_activity_goods_benefit")]
        [XmlArrayItem("merchant_activity_goods")]
        public List<MerchantActivityGoods> MerchantActivityGoodsBenefit { get; set; }
    }
}
