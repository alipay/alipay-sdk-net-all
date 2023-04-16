using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FamilyPayQuotaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FamilyPayQuotaInfo : AopObject
    {
        /// <summary>
        /// 额度周期： PER_DAY(单日)、PER_TRANSACTION(单笔)、PER_MONTH(单月）
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 额度值，单位元
        /// </summary>
        [XmlElement("quota")]
        public string Quota { get; set; }
    }
}
