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
        /// 物流公司编号。物流公司编号值请查看<a href="https://opendocs.alipay.com/mini/00au7e?highlight_field=logistics_code" target="_blank">产品文档</a>
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
