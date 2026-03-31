using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAlipaymemberGradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAlipaymemberGradeQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
