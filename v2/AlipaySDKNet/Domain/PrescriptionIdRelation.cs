using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrescriptionIdRelation Data Structure.
    /// </summary>
    [Serializable]
    public class PrescriptionIdRelation : AopObject
    {
        /// <summary>
        /// 外部处方单编号
        /// </summary>
        [XmlElement("prescription_code")]
        public string PrescriptionCode { get; set; }

        /// <summary>
        /// 支付宝内部存储处方id
        /// </summary>
        [XmlElement("prescription_id")]
        public string PrescriptionId { get; set; }
    }
}
