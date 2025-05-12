using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPharmacistsignqrurlCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthcaPharmacistsignqrurlCreateModel : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 药师姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 红框红体（姓名样式）
        /// </summary>
        [XmlElement("name_style")]
        public string NameStyle { get; set; }

        /// <summary>
        /// 药师UID
        /// </summary>
        [XmlElement("pharmacist_code")]
        public string PharmacistCode { get; set; }

        /// <summary>
        /// 请求唯一标识（与后续的结果消费和主动查询对应，需要存储）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
