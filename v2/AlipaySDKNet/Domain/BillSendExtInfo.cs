using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillSendExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillSendExtInfo : AopObject
    {
        /// <summary>
        /// 账单唤起收银台的方式： 1-手机wap;2-当面付。默认值为1（不传值或传非数字值）
        /// </summary>
        [XmlElement("order_pay_type")]
        public string OrderPayType { get; set; }

        /// <summary>
        /// 分账金额
        /// </summary>
        [XmlElement("royalty_amount")]
        public string RoyaltyAmount { get; set; }

        /// <summary>
        /// 2088xxx
        /// </summary>
        [XmlElement("trans_in_pid")]
        public string TransInPid { get; set; }
    }
}
