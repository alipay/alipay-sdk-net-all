using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemFixVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemFixVoucherInfo : AopObject
    {
        /// <summary>
        /// 【描述】券的优惠面额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 【描述】满减券的门槛金额
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }
    }
}
