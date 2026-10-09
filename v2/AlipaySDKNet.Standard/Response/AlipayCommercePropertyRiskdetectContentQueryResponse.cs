using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyRiskdetectContentQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyRiskdetectContentQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("content_results")]
        [XmlArrayItem("device_content_d_t_o")]
        public List<DeviceContentDTO> ContentResults { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
