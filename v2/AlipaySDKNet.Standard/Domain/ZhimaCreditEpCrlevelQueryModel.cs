using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCrlevelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCrlevelQueryModel : AopObject
    {
        /// <summary>
        /// 外部授权记录编号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 外部授权记录URL链接
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }

        /// <summary>
        /// 企业法人证件号
        /// </summary>
        [XmlElement("cognizant_cert_no")]
        public string CognizantCertNo { get; set; }

        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        [XmlElement("cognizant_name")]
        public string CognizantName { get; set; }

        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }
    }
}
