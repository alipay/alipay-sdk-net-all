using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPagetemplateGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasDesignPagetemplateGetModel : AopObject
    {
        /// <summary>
        /// 数据库id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
