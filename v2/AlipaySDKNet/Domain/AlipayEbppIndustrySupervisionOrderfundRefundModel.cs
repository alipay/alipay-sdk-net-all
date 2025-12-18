using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderfundRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionOrderfundRefundModel : AopObject
    {
        /// <summary>
        /// 用户支付宝uid
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 操作金额（整数，单位：分）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单归属的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 本次请求流水号、相同流水好幂等返回
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 需要进行冻资划拨的关联订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 操作场景类型
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
