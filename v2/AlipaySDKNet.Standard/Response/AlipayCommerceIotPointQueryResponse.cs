using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotPointQueryResponse.
    /// </summary>
    public class AlipayCommerceIotPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前分页
        /// </summary>
        [XmlElement("cur_page")]
        public long CurPage { get; set; }

        /// <summary>
        /// 点位列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("point_info")]
        public List<PointInfo> Data { get; set; }

        /// <summary>
        /// 总点位数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
