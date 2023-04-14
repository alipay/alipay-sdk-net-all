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
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 用户此订单是否守约。 传true时，用户在芝麻信用-守约记录中，该笔订单是已守约状态； 传false时，用户在芝麻信用-守约记录中，该笔订单是已取消状态。
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
