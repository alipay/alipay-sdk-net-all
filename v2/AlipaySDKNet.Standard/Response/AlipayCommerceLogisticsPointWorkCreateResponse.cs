using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsPointWorkCreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsPointWorkCreateResponse : AopResponse
    {
        /// <summary>
        /// 特定点位的作业单ID
        /// </summary>
        [XmlElement("logistics_point_work_id")]
        public string LogisticsPointWorkId { get; set; }
    }
}
