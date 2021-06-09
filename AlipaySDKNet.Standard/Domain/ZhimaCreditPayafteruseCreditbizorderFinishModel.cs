using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafteruseCreditbizorderFinishModel : AopObject
    {
        /// <summary>
        /// 芝麻后付订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 用户此订单是否守约
        /// </summary>
        [XmlElement("is_fulfilled")]
        public string IsFulfilled { get; set; }

        /// <summary>
        /// 商户外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户对本次操作的附言描述
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
