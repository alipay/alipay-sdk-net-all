using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIotnspoperationDeliveryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIotnspoperationDeliveryCreateModel : AopObject
    {
        /// <summary>
        /// 枚举值： ·SELF_MODE 商户自接入模式 ·AGENCY_MODE 服务商代接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 推广计划基础信息
        /// </summary>
        [XmlElement("n_delivery_base_info")]
        public NDeliveryBaseInfo NDeliveryBaseInfo { get; set; }

        /// <summary>
        /// 推广发放规则配置
        /// </summary>
        [XmlElement("n_delivery_paly_config")]
        public NDeliveryPalyConfig NDeliveryPalyConfig { get; set; }

        /// <summary>
        /// 支持指定收单账号、指定设备SN，各规则之间为且关系
        /// </summary>
        [XmlElement("n_delivery_target_rule")]
        public NDeliveryTargetRule NDeliveryTargetRule { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
