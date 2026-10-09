using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeApplySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodeApplySendModel : AopObject
    {
        /// <summary>
        /// 投诉地址
        /// </summary>
        [XmlElement("complain_url")]
        public string ComplainUrl { get; set; }

        /// <summary>
        /// 资金存管模式。 TEMPLATE：储值模式；BANK：银行模式。 默认不传为TEMPLATE模式
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 商家监管户信息
        /// </summary>
        [XmlElement("monitor_info")]
        public MonitorInfo MonitorInfo { get; set; }

        /// <summary>
        /// 外部申请单号
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 商家结算户信息
        /// </summary>
        [XmlElement("payee_info")]
        public PayeeInfo PayeeInfo { get; set; }

        /// <summary>
        /// 场景类型："normal"-经典类型；"driving"-驾校场景。默认为经典类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 商户账户
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 返佣pid
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
