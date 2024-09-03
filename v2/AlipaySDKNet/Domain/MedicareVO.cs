using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicareVO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicareVO : AopObject
    {
        /// <summary>
        /// 医保个账退款金额
        /// </summary>
        [XmlElement("mi_personal_amount")]
        public string MiPersonalAmount { get; set; }

        /// <summary>
        /// 医保统筹退款金额
        /// </summary>
        [XmlElement("mi_pool_amount")]
        public string MiPoolAmount { get; set; }

        /// <summary>
        /// 医保自付退款金额，单位：元
        /// </summary>
        [XmlElement("mi_self_amount")]
        public string MiSelfAmount { get; set; }
    }
}
