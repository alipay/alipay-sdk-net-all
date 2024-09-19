using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PreOrderContactUser Data Structure.
    /// </summary>
    [Serializable]
    public class PreOrderContactUser : AopObject
    {
        /// <summary>
        /// 联系人身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 联系人的姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
