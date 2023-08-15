using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteFilelistQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteFilelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页游标
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 文件列表
        /// </summary>
        [XmlElement("object_list")]
        public StaticSiteFile ObjectList { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
