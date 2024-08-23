using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasTwometaCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasTwometaCheckModel : AopObject
    {
        /// <summary>
        /// 身份证二要素核验具体类型
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户姓名，与身份证上的姓名相匹配
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码，如大陆身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件信息类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 客户业务单据号
        /// </summary>
        [XmlElement("outer_biz_no")]
        public string OuterBizNo { get; set; }
    }
}
