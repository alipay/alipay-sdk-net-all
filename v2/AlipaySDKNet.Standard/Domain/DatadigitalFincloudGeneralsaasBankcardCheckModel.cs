using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasBankcardCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasBankcardCheckModel : AopObject
    {
        /// <summary>
        /// 需核验的银行卡号
        /// </summary>
        [XmlElement("bankcard_no")]
        public string BankcardNo { get; set; }

        /// <summary>
        /// 银行卡核验具体类型
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户姓名，与身份证上的姓名相匹配
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 大陆身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 银行卡核验涉及的证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 客户业务单据号
        /// </summary>
        [XmlElement("outer_biz_no")]
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }
    }
}
