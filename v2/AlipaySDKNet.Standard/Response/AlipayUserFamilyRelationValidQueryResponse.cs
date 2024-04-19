using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFamilyRelationValidQueryResponse.
    /// </summary>
    public class AlipayUserFamilyRelationValidQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否加入过家庭
        /// </summary>
        [XmlElement("has_family")]
        public bool HasFamily { get; set; }

        /// <summary>
        /// 是否加入有效家庭
        /// </summary>
        [XmlElement("has_valid_family")]
        public bool HasValidFamily { get; set; }
    }
}
