using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdentitylibraryEntitycategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdentitylibraryEntitycategoryQueryModel : AopObject
    {
        /// <summary>
        /// 类目ID,如果不传则返回一级类目相关信息
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
