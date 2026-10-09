using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingRedeemResponse.
    /// </summary>
    public class AlipayVoyagerMarketingRedeemResponse : AopResponse
    {
        /// <summary>
        /// 核销单号，三方用于对账和后续退款
        /// </summary>
        [XmlElement("redeem_order_id")]
        public string RedeemOrderId { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
