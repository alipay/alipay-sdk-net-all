using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscribeRelation Data Structure.
    /// </summary>
    [Serializable]
    public class SubscribeRelation : AopObject
    {
        /// <summary>
        /// 订阅保持状态，即用户勾选“总是保持以上选择，不再询问”选项时勾选的订阅状态。说明：若用户“总是保持以上选择，不再询问”选项，且选择订阅消息。下次触发消息订阅组件时，支付宝将自动发起一次静默订阅（不再拉起订阅组件，无需用户手动订阅）。
        /// </summary>
        [XmlElement("keep_state")]
        public string KeepState { get; set; }

        /// <summary>
        /// 模板是否展示在订阅组件中
        /// </summary>
        [XmlElement("show")]
        public bool Show { get; set; }

        /// <summary>
        /// 订阅状态
        /// </summary>
        [XmlElement("subscribe_state")]
        public string SubscribeState { get; set; }

        /// <summary>
        /// 消息模板的订阅类型
        /// </summary>
        [XmlElement("subscribe_type")]
        public string SubscribeType { get; set; }

        /// <summary>
        /// 消息模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
