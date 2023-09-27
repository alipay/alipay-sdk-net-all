using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderLogisticsInformationRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsInformationRequest : AopObject
    {
        /// <summary>
        /// 物流公司编号。  物流公司编号值请查看产品文档
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
