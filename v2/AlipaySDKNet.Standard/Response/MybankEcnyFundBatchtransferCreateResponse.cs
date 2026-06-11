using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyFundBatchtransferCreateResponse.
    /// </summary>
    public class MybankEcnyFundBatchtransferCreateResponse : AopResponse
    {
        /// <summary>
        /// 转账页面跳转地址
        /// </summary>
        [XmlElement("ecny_batch_transfer_url")]
        public string EcnyBatchTransferUrl { get; set; }

        /// <summary>
        /// 网商银行订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 由双方约定分配值
        /// </summary>
        [XmlElement("out_request_from")]
        public string OutRequestFrom { get; set; }

        /// <summary>
        /// 调用方订单号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
