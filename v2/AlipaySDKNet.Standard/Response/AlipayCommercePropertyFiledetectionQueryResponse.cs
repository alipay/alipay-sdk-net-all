using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyFiledetectionQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyFiledetectionQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("property_file_detection_v_o")]
        public List<PropertyFileDetectionVO> List { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
