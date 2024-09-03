using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicareInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicareInfoVO : AopObject
    {
        /// <summary>
        /// 医保个账金额
        /// </summary>
        [XmlElement("mi_personal_amount")]
        public long MiPersonalAmount { get; set; }

        /// <summary>
        /// 医保统筹金额
        /// </summary>
        [XmlElement("mi_pool_amount")]
        public long MiPoolAmount { get; set; }

        /// <summary>
        /// 医保自付金额
        /// </summary>
        [XmlElement("mi_self_amount")]
        public long MiSelfAmount { get; set; }
    }
}
