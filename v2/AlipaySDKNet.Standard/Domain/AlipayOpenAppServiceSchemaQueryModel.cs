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
    }
}
