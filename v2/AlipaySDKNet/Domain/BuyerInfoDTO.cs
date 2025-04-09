using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BuyerInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BuyerInfoDTO : AopObject
    {
        /// <summary>
        /// 买家的用户身份证信息
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 买家的手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 买家的用户名字
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
