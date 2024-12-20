using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppHexidemoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppHexidemoModifyModel : AopObject
    {
        /// <summary>
        /// 查询对象
        /// </summary>
        [XmlElement("model")]
        public HeXiQueryVo Model { get; set; }

        /// <summary>
        /// queryString查询
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
