using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptMerchantExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptMerchantExtendInfo : AopObject
    {
        /// <summary>
        /// 收银机ID
        /// </summary>
        [XmlElement("cash_register_id")]
        public string CashRegisterId { get; set; }

        /// <summary>
        /// 收银员ID
        /// </summary>
        [XmlElement("cashier_id")]
        public string CashierId { get; set; }

        /// <summary>
        /// 收银员名
        /// </summary>
        [XmlElement("cashier_name")]
        public string CashierName { get; set; }

        /// <summary>
        /// 字体颜色，传入色号
        /// </summary>
        [XmlElement("font_colour")]
        public string FontColour { get; set; }

        /// <summary>
        /// 服务热线，电话号码
        /// </summary>
        [XmlElement("hot_line")]
        public string HotLine { get; set; }

        /// <summary>
        /// 商户标语文案，限制在20字以内
        /// </summary>
        [XmlElement("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// 小票流水号
        /// </summary>
        [XmlElement("ticket_record_no")]
        public string TicketRecordNo { get; set; }

        /// <summary>
        /// 温馨提示, 限制在40字以内
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }
    }
}
