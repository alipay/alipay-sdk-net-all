using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContributeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ContributeDetail : AopObject
    {
        /// <summary>
        /// 出资方金额
        /// </summary>
        [XmlElement("contribute_amount")]
        public string ContributeAmount { get; set; }

        /// <summary>
        /// 出资方类型
        /// </summary>
        [XmlElement("contribute_type")]
        public string ContributeType { get; set; }
    }
}
