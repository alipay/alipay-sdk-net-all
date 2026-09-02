using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentDistorderInspectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentDistorderInspectModel : AopObject
    {
        /// <summary>
        /// 分销订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 渠道买家ID
        /// </summary>
        [XmlElement("channel_buyer_id")]
        public string ChannelBuyerId { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [XmlElement("channel_order_id")]
        public string ChannelOrderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("deduct_fees")]
        [XmlArrayItem("distribution_order_inspect_deduct_fee_d_t_o")]
        public List<DistributionOrderInspectDeductFeeDTO> DeductFees { get; set; }

        /// <summary>
        /// 分销渠道
        /// </summary>
        [XmlElement("distribution_channel")]
        public string DistributionChannel { get; set; }

        /// <summary>
        /// 验货是否通过，未通过会发起赔付
        /// </summary>
        [XmlElement("inspection_result")]
        public bool InspectionResult { get; set; }

        /// <summary>
        /// 验货异常描述凭证
        /// </summary>
        [XmlElement("proof")]
        public DistributionOrderInspectProofDTO Proof { get; set; }
    }
}
