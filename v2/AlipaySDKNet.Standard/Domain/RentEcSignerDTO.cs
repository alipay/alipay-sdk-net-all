using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentEcSignerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentEcSignerDTO : AopObject
    {
        /// <summary>
        /// 用户身份证号或者统一社会信用代码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户姓名或企业名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签署方类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
