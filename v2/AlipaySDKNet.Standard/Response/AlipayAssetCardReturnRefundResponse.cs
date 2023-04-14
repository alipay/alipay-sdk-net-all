using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetCardReturnRefundResponse.
    /// </summary>
    public class AlipayAssetCardReturnRefundResponse : AopResponse
    {
        /// <summary>
        /// 账务操作时间
        /// </summary>
        [XmlElement("account_dt")]
        public string AccountDt { get; set; }

        /// <summary>
        /// 系统退卡订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退卡资金，单位元，包含手续费
        /// </summary>
        [XmlElement("return_amount")]
        public string ReturnAmount { get; set; }

        /// <summary>
        /// 退款面额，单位元，包含手续费
        /// </summary>
        [XmlElement("return_asset_amont")]
        public string ReturnAssetAmont { get; set; }

        /// <summary>
        /// 退卡手续费资金，单位元
        /// </summary>
        [XmlElement("return_fee_amount")]
        public string ReturnFeeAmount { get; set; }

        /// <summary>
        /// 退卡手续费面额，单位元
        /// </summary>
        [XmlElement("return_fee_asset_amount")]
        public string ReturnFeeAssetAmount { get; set; }
    }
}
