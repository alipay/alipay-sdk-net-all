using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetCardDepositResponse.
    /// </summary>
    public class AlipayAssetCardDepositResponse : AopResponse
    {
        /// <summary>
        /// 扩展属性，json格式。 KEY:VcpExtendInfoKeyEnum.BIZ_FUND_ORDER_ID bizFund的订单ID KEY:VcpExtendInfoKeyEnum.BIZ_FUND_CASHIER_ORDER_ID 收银台订单ID
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 充值交易号
        /// </summary>
        [XmlElement("recharge_no")]
        public string RechargeNo { get; set; }
    }
}
