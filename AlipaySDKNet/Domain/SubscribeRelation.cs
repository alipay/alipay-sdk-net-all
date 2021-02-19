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
        /// 订阅保持状态，下次静默订阅的时的状态。0:保持订阅，1:保持拒绝订阅
        /// </summary>
        [XmlElement("keep_state")]
        public string KeepState { get; set; }

        /// <summary>
        /// 模板是否展示在订阅组件中。ture:订阅组件中展示查询的模板，false:订阅组件中不展示模板
        /// </summary>
        [XmlElement("show")]
        public bool Show { get; set; }

        /// <summary>
        /// 订阅状态。0:拒绝订阅，1:订阅
        /// </summary>
        [XmlElement("subscribe_state")]
        public string SubscribeState { get; set; }

        /// <summary>
        /// 消息模板的订阅类型。longterm:长期性订阅，onetime:一次性订阅
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
