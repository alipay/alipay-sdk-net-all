using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyLogisticsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyLogisticsDetail : AopObject
    {
        /// <summary>
        /// 收件人或寄件人手机号后四位
        /// </summary>
        [XmlElement("check_phone_no")]
        public string CheckPhoneNo { get; set; }

        /// <summary>
        /// 用于存储物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 用于记录物流公司名称
        /// </summary>
        [XmlElement("logistics_company")]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 用于存储快递公司物流运单号
        /// </summary>
        [XmlElement("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
