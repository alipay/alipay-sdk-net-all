using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentAftersaleFundItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentAftersaleFundItemVO : AopObject
    {
        /// <summary>
        /// 当前费用项支付金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
