using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiBibifanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiBibifanQueryModel : AopObject
    {
        /// <summary>
        /// 司机身份证号
        /// </summary>
        [XmlElement("driver_cert_no")]
        public string DriverCertNo { get; set; }

        /// <summary>
        /// 查询截止时间-时间区间不超过1天
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 不同服务商来自不同
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
