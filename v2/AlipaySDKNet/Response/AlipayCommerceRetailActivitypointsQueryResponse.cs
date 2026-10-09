using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailActivitypointsQueryResponse.
    /// </summary>
    public class AlipayCommerceRetailActivitypointsQueryResponse : AopResponse
    {
        /// <summary>
        /// 积分活动
        /// </summary>
        [XmlArray("activity_info")]
        [XmlArrayItem("retail_activity_point_info")]
        public List<RetailActivityPointInfo> ActivityInfo { get; set; }

        /// <summary>
        /// 数据行数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
