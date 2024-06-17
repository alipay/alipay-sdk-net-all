using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionPayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionPayCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 支付单金额，单位:分  示例: 100元则传入 "10000"
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 业务场景： ● 购房冻资:HOUSE_PURCHASED
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 币种 "CNY"
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 用户支付宝uid对应openid,用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部流水号，本次创建支付单的请求id，重复请求幂等返回
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 外部订单号，本次发起支付关联的冻资单id
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 收银台展示的支付标题
        /// </summary>
        [XmlElement("pay_title")]
        public string PayTitle { get; set; }

        /// <summary>
        /// 收款方主体信息，字符串BASE64加密
        /// </summary>
        [XmlElement("payee_participant_info")]
        public string PayeeParticipantInfo { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 用于业务埋点分析
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 过期时间（整数单位：分钟），限制 最多 1440 分钟
        /// </summary>
        [XmlElement("time_expire")]
        public long TimeExpire { get; set; }
    }
}
