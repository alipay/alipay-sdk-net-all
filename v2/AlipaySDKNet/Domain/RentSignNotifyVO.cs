using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSignNotifyVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentSignNotifyVO : AopObject
    {
        /// <summary>
        /// 预授权冻结单号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 用户签约产品
        /// </summary>
        [XmlElement("sign_product")]
        public string SignProduct { get; set; }

        /// <summary>
        /// 用户签约成功时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }
    }
}
