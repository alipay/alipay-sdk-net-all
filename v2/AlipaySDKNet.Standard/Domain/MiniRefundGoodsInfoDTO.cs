using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniRefundGoodsInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniRefundGoodsInfoDTO : AopObject
    {
        /// <summary>
        /// 商品退款凭证信息，在本地生活等场景下，需要填入凭证号进行退款。
        /// </summary>
        [XmlElement("certificate_info")]
        public MiniRefundCertificateDTO CertificateInfo { get; set; }

        /// <summary>
        /// 商户侧商品的编号，应与alipay.open.mini.order.create接口所传的商品goods_id保持一致
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商户商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户商品sku_id,提报商品库的商品，sku维度的商品该字段必传
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品退款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
