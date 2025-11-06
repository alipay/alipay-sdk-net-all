using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinSignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinSignInfo : AopObject
    {
        /// <summary>
        /// 数字签名签名位置
        /// </summary>
        [XmlElement("sign_keyword")]
        public CarfinKeyWord SignKeyword { get; set; }

        /// <summary>
        /// 协议的签署方
        /// </summary>
        [XmlElement("signer")]
        public string Signer { get; set; }

        /// <summary>
        /// 签署时间的签名位置
        /// </summary>
        [XmlElement("time_keyword")]
        public CarfinKeyWord TimeKeyword { get; set; }
    }
}
