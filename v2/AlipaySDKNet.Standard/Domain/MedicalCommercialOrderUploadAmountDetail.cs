using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalCommercialOrderUploadAmountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalCommercialOrderUploadAmountDetail : AopObject
    {
        /// <summary>
        /// 金额，精确到小数点后2位，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
