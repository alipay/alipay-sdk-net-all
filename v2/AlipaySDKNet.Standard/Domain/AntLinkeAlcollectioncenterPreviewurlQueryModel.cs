using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntLinkeAlcollectioncenterPreviewurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntLinkeAlcollectioncenterPreviewurlQueryModel : AopObject
    {
        /// <summary>
        /// 查询案件下的函件预览链接
        /// </summary>
        [XmlElement("affair_id")]
        public string AffairId { get; set; }
    }
}
