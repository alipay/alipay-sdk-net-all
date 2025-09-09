using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemFixQueryVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemFixQueryVoucherInfo : AopObject
    {
        /// <summary>
        /// 券面额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 门槛金额，单位：元
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }
    }
}
