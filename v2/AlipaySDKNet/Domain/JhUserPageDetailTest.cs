using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JhUserPageDetailTest Data Structure.
    /// </summary>
    [Serializable]
    public class JhUserPageDetailTest : AopObject
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
