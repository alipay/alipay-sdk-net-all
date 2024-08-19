using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseBillItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseBillItem : AopObject
    {
        /// <summary>
        /// 收费账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 账户绑定手机号或者绑定邮箱，优先取绑定手机号，脱敏返回
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 收费账户Open ID
        /// </summary>
        [XmlElement("account_open_id")]
        public string AccountOpenId { get; set; }

        /// <summary>
        /// 收费金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收费主体
        /// </summary>
        [XmlElement("charge_ou")]
        public string ChargeOu { get; set; }

        /// <summary>
        /// 收费/退费
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 计费时间
        /// </summary>
        [XmlElement("occurrence_time")]
        public string OccurrenceTime { get; set; }

        /// <summary>
        /// 费用码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 凭证核销的次序号 例：商品为次卡，可使用三次，则一个凭证能够进行三次核销，生成三个核销次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
