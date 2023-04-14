using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountFundBtocTransferResponse.
    /// </summary>
    public class AlipayFundJointaccountFundBtocTransferResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧转账订单号
        /// </summary>
        [XmlElement("biz_trans_id")]
        public string BizTransId { get; set; }

        /// <summary>
        /// 商户侧单号（与当前请求参数中传入值保持一致）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转账单据状态<br> SUCCESS：成功<br> FAIL：失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转账时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
