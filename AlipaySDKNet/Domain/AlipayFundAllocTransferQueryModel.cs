using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAllocTransferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAllocTransferQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 分佣单号（与out_biz_no二选一）
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务单号（与order_id二选一）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码，默认值 TRANSFER_ALLOC
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
