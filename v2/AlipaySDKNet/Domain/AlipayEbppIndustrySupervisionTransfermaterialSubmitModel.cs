using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionTransfermaterialSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionTransfermaterialSubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 确认期限（单位天）
        /// </summary>
        [XmlElement("confirm_period")]
        public string ConfirmPeriod { get; set; }

        /// <summary>
        /// ATFS文件id集合
        /// </summary>
        [XmlArray("file_ids")]
        [XmlArrayItem("string")]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 外部商户订单
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
