using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LatestVerifyError Data Structure.
    /// </summary>
    [Serializable]
    public class LatestVerifyError : AopObject
    {
        /// <summary>
        /// 支付宝账号未实名认证
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 异常描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 异常时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
