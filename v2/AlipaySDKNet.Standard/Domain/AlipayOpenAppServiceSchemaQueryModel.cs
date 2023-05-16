using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceSchemaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceSchemaQueryModel : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 服务模版类型。若当前服务类目只有一个服务模版，可不填。
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
