using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsCashierInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsCashierInfo : AopObject
    {
        /// <summary>
        /// 门店的收银类型
        /// </summary>
        [XmlElement("cashier_type")]
        public string CashierType { get; set; }
    }
}
