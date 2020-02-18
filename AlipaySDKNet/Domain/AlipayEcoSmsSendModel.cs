using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoSmsSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSmsSendModel : AopObject
    {
        /// <summary>
        /// 发送内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 待收信人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
