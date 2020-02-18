using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransAacollectPayorderCreateResponse.
    /// </summary>
    public class AlipayFundTransAacollectPayorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 业务类型,客户端透传给收银台。默认值：biz_account_transfer
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 付款订单号,小程序传给收银台
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }
    }
}
