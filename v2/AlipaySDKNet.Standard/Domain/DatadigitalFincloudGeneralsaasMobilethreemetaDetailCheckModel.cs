using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasMobilethreemetaDetailCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasMobilethreemetaDetailCheckModel : AopObject
    {
        /// <summary>
        /// 业务产品码
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
        /// 客户业务单据号
        /// </summary>
        [XmlElement("outer_biz_no")]
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 需核验的手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
