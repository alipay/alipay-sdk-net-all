using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrgbidataBlockinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrgbidataBlockinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据返回
        /// </summary>
        [XmlElement("block_content")]
        public string BlockContent { get; set; }

        /// <summary>
        /// 聚合数据的不同类型： "org_aggr_statistics","org_statistics_detail"
        /// </summary>
        [XmlElement("block_type")]
        public string BlockType { get; set; }
    }
}
