using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderfundTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionOrderfundTransferModel : AopObject
    {
        /// <summary>
        /// 支付宝用户uid
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
        /// 交易币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 本次请求流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 需要进行冻资划拨的关联订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 收款方主体信息，字符串BASE64加密
        /// </summary>
        [XmlElement("payee_participant_info")]
        public string PayeeParticipantInfo { get; set; }

        /// <summary>
        /// 操作场景类型
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
