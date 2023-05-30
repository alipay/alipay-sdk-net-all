using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockTrustUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockTrustUserQueryModel : AopObject
    {
        /// <summary>
        /// 券商代销信托业务用户ID
        /// </summary>
        [XmlElement("trust_user_id")]
        public string TrustUserId { get; set; }
    }
}
