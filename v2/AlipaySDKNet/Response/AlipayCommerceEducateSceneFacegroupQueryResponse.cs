using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneFacegroupQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneFacegroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 学校人脸库ID
        /// </summary>
        [XmlElement("school_group_id")]
        public string SchoolGroupId { get; set; }
    }
}
