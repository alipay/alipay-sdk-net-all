using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneSettleWorkersaasSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneSettleWorkersaasSyncModel : AopObject
    {
        /// <summary>
        /// 收款人户名
        /// </summary>
        [XmlElement("emp_name")]
        public string EmpName { get; set; }

        /// <summary>
        /// 收款人手机号
        /// </summary>
        [XmlElement("emp_phone")]
        public string EmpPhone { get; set; }

        /// <summary>
        /// 交易流水号。取转账渠道交易流水。
        /// </summary>
        [XmlElement("front_log_no")]
        public string FrontLogNo { get; set; }

        /// <summary>
        /// 取收款人证件号码。
        /// </summary>
        [XmlElement("license_id")]
        public string LicenseId { get; set; }

        /// <summary>
        /// 收款人证件类型
        /// </summary>
        [XmlElement("license_type")]
        public string LicenseType { get; set; }

        /// <summary>
        /// 取蚂蚁保结算单号。
        /// </summary>
        [XmlElement("outer_trade_no")]
        public string OuterTradeNo { get; set; }

        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("pay_account")]
        public string PayAccount { get; set; }

        /// <summary>
        /// 交易金额，单位 元。
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 取转账渠道失败code。
        /// </summary>
        [XmlElement("trade_fail_code")]
        public string TradeFailCode { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
