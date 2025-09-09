using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataPrescriptionstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataPrescriptionstatusQueryModel : AopObject
    {
        /// <summary>
        /// 外部机构自己的处方编码
        /// </summary>
        [XmlElement("ext_prescription_code")]
        public string ExtPrescriptionCode { get; set; }

        /// <summary>
        /// 支付宝问诊订单号
        /// </summary>
        [XmlElement("inquiry_id")]
        public string InquiryId { get; set; }

        /// <summary>
        /// 平台编号，支付宝分配
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
