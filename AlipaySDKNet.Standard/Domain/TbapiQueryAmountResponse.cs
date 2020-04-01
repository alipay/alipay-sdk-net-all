using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TbapiQueryAmountResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TbapiQueryAmountResponse : AopObject
    {
        /// <summary>
        /// 指定产品码额度
        /// </summary>
        [XmlElement("amt_map")]
        public string AmtMap { get; set; }

        /// <summary>
        /// 可用产品组额度
        /// </summary>
        [XmlElement("available_group_amt")]
        public string AvailableGroupAmt { get; set; }
    }
}
