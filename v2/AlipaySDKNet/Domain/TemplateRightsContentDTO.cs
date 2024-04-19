using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateRightsContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateRightsContentDTO : AopObject
    {
        /// <summary>
        /// 权益内容详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 权益icon图片Id（目前用于开卡授权页使用），通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [XmlElement("logo_id")]
        public string LogoId { get; set; }

        /// <summary>
        /// 权益内容标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
