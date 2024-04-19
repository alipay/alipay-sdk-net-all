using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractSignatory Data Structure.
    /// </summary>
    [Serializable]
    public class ContractSignatory : AopObject
    {
        /// <summary>
        /// 签署人证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 签署人证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户身份证姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
