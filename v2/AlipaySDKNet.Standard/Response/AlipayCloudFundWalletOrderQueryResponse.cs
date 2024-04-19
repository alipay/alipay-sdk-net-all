using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletOrderQueryResponse.
    /// </summary>
    public class AlipayCloudFundWalletOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 实际交易金额，单位元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 交易最后处理时间
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 退款明细
        /// </summary>
        [XmlArray("refund_payment_asset_infos")]
        [XmlArrayItem("refund_payment_asset_infos")]
        public List<RefundPaymentAssetInfos> RefundPaymentAssetInfos { get; set; }

        /// <summary>
        /// 交易总金额，单位元
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
