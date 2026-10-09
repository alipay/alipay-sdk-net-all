using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperateNotifyExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OperateNotifyExtInfo : AopObject
    {
        /// <summary>
        /// 提前收款标识，提前收款场景下有值
        /// </summary>
        [XmlElement("receipt_advanced")]
        public string ReceiptAdvanced { get; set; }
    }
}
