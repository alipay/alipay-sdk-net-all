using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyWelfarewalletOpenPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyWelfarewalletOpenPreconsultModel : AopObject
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 默认身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 固定为STKJ，商通科技简称
        /// </summary>
        [XmlElement("partner_abbr_name")]
        public string PartnerAbbrName { get; set; }

        /// <summary>
        /// 合作机构的2088编码，识别商通身份
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 用户的2088编码
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
