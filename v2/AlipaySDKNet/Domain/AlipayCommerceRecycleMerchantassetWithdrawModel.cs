using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleMerchantassetWithdrawModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleMerchantassetWithdrawModel : AopObject
    {
        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔提现请求，商户需保证该订单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 提现总金额，单位：分
        /// </summary>
        [XmlElement("trans_amount")]
        public long TransAmount { get; set; }
    }
}
