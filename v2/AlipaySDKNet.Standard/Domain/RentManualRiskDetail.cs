using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentManualRiskDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RentManualRiskDetail : AopObject
    {
        /// <summary>
        /// 人工审核的判断依据和备注信息
        /// </summary>
        [XmlElement("judge")]
        public string Judge { get; set; }

        /// <summary>
        /// 是否审核通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }
    }
}
