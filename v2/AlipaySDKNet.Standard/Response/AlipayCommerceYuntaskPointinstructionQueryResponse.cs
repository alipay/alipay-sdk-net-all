using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskPointinstructionQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskPointinstructionQueryResponse : AopResponse
    {
        /// <summary>
        /// 积分流水信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("point_instruction")]
        public List<PointInstruction> Data { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
