using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationPointDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationPointDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回用户积分明细数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("alipay_point_detail")]
        public List<AlipayPointDetail> Data { get; set; }

        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }
    }
}
