using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCorpusDetailQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCorpusDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 政策文件
        /// </summary>
        [XmlElement("doc_dto")]
        public DocDTO DocDto { get; set; }

        /// <summary>
        /// faq问答
        /// </summary>
        [XmlElement("faq_dto")]
        public CommonQaDTO FaqDto { get; set; }

        /// <summary>
        /// 办事事项
        /// </summary>
        [XmlElement("item_dto")]
        public ServiceItemDTO ItemDto { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [XmlElement("service_dto")]
        public GovOrgServiceDTO ServiceDto { get; set; }
    }
}
