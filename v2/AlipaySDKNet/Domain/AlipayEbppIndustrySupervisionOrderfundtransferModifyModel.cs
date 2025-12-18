using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderfundtransferModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionOrderfundtransferModifyModel : AopObject
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
        /// 默认CNY 目前只支持CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 修改的划拨单请求流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 关联订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
