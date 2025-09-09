using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyinfoInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyIdentifyinfoInfoQueryModel : AopObject
    {
        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 查询的值
        /// </summary>
        [XmlElement("query_value")]
        public string QueryValue { get; set; }
    }
}
