using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverSendModel : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 司机身份证号
        /// </summary>
        [XmlElement("driver_cert_no")]
        public string DriverCertNo { get; set; }

        /// <summary>
        /// 司机工号
        /// </summary>
        [XmlElement("driver_job_no")]
        public string DriverJobNo { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [XmlElement("driver_phone")]
        public string DriverPhone { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 来源方，由支付宝分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
