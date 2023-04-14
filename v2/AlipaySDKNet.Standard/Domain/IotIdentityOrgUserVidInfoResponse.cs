using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgUserVidInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgUserVidInfoResponse : AopObject
    {
        /// <summary>
        /// 支付宝账号uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 刷脸成功的vid
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
