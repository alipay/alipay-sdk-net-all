using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VisitorConfigQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class VisitorConfigQueryVO : AopObject
    {
        /// <summary>
        /// 开门配置
        /// </summary>
        [XmlElement("entrance_open_config")]
        public string EntranceOpenConfig { get; set; }

        /// <summary>
        /// 开门调用类型 API|SPI
        /// </summary>
        [XmlElement("entrance_open_type")]
        public string EntranceOpenType { get; set; }

        /// <summary>
        /// 是否需要用户授权 true|false
        /// </summary>
        [XmlElement("need_owner_check")]
        public bool NeedOwnerCheck { get; set; }

        /// <summary>
        /// 鉴权配置
        /// </summary>
        [XmlElement("owner_check_config")]
        public string OwnerCheckConfig { get; set; }

        /// <summary>
        /// 鉴权调用类型 API|SPI
        /// </summary>
        [XmlElement("owner_check_type")]
        public string OwnerCheckType { get; set; }

        /// <summary>
        /// 是否支持自动开门 true|false
        /// </summary>
        [XmlElement("support_open")]
        public bool SupportOpen { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
