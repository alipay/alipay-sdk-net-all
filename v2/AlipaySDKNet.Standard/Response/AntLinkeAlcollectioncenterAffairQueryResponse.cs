using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntLinkeAlcollectioncenterAffairQueryResponse.
    /// </summary>
    public class AntLinkeAlcollectioncenterAffairQueryResponse : AopResponse
    {
        /// <summary>
        /// 案件id
        /// </summary>
        [XmlElement("affair_id")]
        public string AffairId { get; set; }

        /// <summary>
        /// 根据案件id获取案件状态
        /// </summary>
        [XmlElement("affair_status")]
        public string AffairStatus { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
