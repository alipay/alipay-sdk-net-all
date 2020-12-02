using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppApiSceneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppApiSceneQueryModel : AopObject
    {
        /// <summary>
        /// 接口英文名。
        /// </summary>
        [XmlElement("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 接口出参字段英文名。
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }
    }
}
