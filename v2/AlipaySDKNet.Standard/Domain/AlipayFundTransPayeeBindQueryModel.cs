using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransPayeeBindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransPayeeBindQueryModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 证件类型,暂仅支持 IDENTITY_CARD （身份证）
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
