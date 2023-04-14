using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 优惠券金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户出资
        /// </summary>
        [XmlElement("merchant_contribute")]
        public string MerchantContribute { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他出资，非交易本商家
        /// </summary>
        [XmlElement("other_contribute")]
        public string OtherContribute { get; set; }

        /// <summary>
        /// 其他出资方明细
        /// </summary>
        [XmlArray("other_contribute_detail")]
        [XmlArrayItem("contribute_detail_info")]
        public List<ContributeDetailInfo> OtherContributeDetail { get; set; }

        /// <summary>
        /// 购买该张券时内部出资的部分（包含支付宝/口碑出资的部分）
        /// </summary>
        [XmlElement("purchase_ant_contribute")]
        public string PurchaseAntContribute { get; set; }

        /// <summary>
        /// 购买该张券的资金中买家自已出资的部分
        /// </summary>
        [XmlElement("purchase_buyer_contribute")]
        public string PurchaseBuyerContribute { get; set; }

        /// <summary>
        /// 购买该张券的资金中商户出资的部分
        /// </summary>
        [XmlElement("purchase_merchant_contribute")]
        public string PurchaseMerchantContribute { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券类型，如： ALIPAY_FIX_VOUCHER - 全场代金券 ALIPAY_DISCOUNT_VOUCHER - 折扣券 ALIPAY_ITEM_VOUCHER - 单品优惠券 ALIPAY_CASH_VOUCHER - 现金抵价券 ALIPAY_BIZ_VOUCHER - 商家全场券 注：不排除将来新增其他类型的可能，商家接入时注意兼容性避免硬编码
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
