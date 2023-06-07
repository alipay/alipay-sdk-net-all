using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletOrderQueryResponse.
    /// </summary>
    public class AlipayFundWalletOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 实际交易金额
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 交易最后处理时间
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 退款明细。仅充值退查询时，且退款单据成功且才会展示。
        /// </summary>
        [XmlArray("refund_payment_asset_infos")]
        [XmlArrayItem("refund_payment_asset_info")]
        public List<RefundPaymentAssetInfo> RefundPaymentAssetInfos { get; set; }

        /// <summary>
        /// 交易总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trans_status")]
        public string TransStatus { get; set; }
    }
}
