using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilldetailQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabilldetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 订单金额 or 订单退款金额
        /// </summary>
        [XmlElement("biz_order_amt")]
        public string BizOrderAmt { get; set; }

        /// <summary>
        /// 商家优惠金额或者退商家优惠金额，根据rpRecordType字段值判断方向，rpRecordType=1，则为商家优惠金额，rpRecordType=2，则为退商家优惠金额
        /// </summary>
        [XmlElement("mercht_disc_amt")]
        public string MerchtDiscAmt { get; set; }
    }
}
