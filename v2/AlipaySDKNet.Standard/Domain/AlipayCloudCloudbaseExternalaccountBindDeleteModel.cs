using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseExternalaccountBindDeleteModel : AopObject
    {
        /// <summary>
        /// 服务商账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }
    }
}
