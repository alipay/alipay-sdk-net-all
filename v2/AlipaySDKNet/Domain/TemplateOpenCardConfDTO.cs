using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateOpenCardConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateOpenCardConfDTO : AopObject
    {
        /// <summary>
        /// 领卡权益信息
        /// </summary>
        [XmlArray("card_rights")]
        [XmlArrayItem("template_rights_content_d_t_o")]
        public List<TemplateRightsContentDTO> CardRights { get; set; }

        /// <summary>
        /// 配置，预留字段，暂时不用
        /// </summary>
        [XmlElement("conf")]
        public string Conf { get; set; }

        /// <summary>
        /// 开卡渠道类型 外部系统：ISV （代理运营） 商户直连对接：MER （商家自运营）
        /// </summary>
        [XmlElement("open_card_source_type")]
        public string OpenCardSourceType { get; set; }

        /// <summary>
        /// 开卡链接，必须http、https开头
        /// </summary>
        [XmlElement("open_card_url")]
        public string OpenCardUrl { get; set; }

        /// <summary>
        /// 渠道APPID，提供领卡页面的服务提供方
        /// </summary>
        [XmlElement("source_app_id")]
        public string SourceAppId { get; set; }
    }
}
