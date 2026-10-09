using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionPayCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionPayCancelModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 业务场景： ● 购房冻资:HOUSE_PURCHASED
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
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
    }
}
