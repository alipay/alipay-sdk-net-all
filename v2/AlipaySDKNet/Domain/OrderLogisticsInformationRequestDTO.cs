using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderLogisticsInformationRequestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsInformationRequestDTO : AopObject
    {
        /// <summary>
        /// 物流公司编号。 注：该值为空时，有可能匹配不到物流信息。若有则必传
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流单号，logistics_info_list不为空时，必填
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
