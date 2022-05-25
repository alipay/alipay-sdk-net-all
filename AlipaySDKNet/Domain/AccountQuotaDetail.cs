using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountQuotaDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AccountQuotaDetail : AopObject
    {
        /// <summary>
        /// 周期内的额度上限
        /// </summary>
        [XmlElement("quota_amount")]
        public long QuotaAmount { get; set; }

        /// <summary>
        /// 额度周期，有限枚举
        /// </summary>
        [XmlElement("quota_dimension")]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
