using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTradeOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTradeOrderCreateModel : AopObject
    {
        /// <summary>
        /// 订单描述信息
        /// </summary>
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 可打折金额。 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。 如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        [XmlElement("discountable_amount")]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 商品名字
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 区分业务类型字段
        /// </summary>
        [XmlElement("merchant_biz_type")]
        public string MerchantBizType { get; set; }

        /// <summary>
        /// 支付宝服务器主动通知商户服务器里指定的页面 http/https 路径
        /// </summary>
        [XmlElement("notify")]
        public string Notify { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 和订单状态同步订单号一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代扣账期订单号
        /// </summary>
        [XmlElement("out_sub_biz_no")]
        public string OutSubBizNo { get; set; }

        /// <summary>
        /// 平台商uniqueCod
        /// </summary>
        [XmlElement("partner_unique_code")]
        public string PartnerUniqueCode { get; set; }

        /// <summary>
        /// 业务参数
        /// </summary>
        [XmlElement("portable")]
        public string Portable { get; set; }

        /// <summary>
        /// 商品价格，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量，单位辆
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 二级商户号
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 二级商户名字
        /// </summary>
        [XmlElement("sub_merchant_name")]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// 二级商户的服务描述
        /// </summary>
        [XmlElement("sub_merchant_service_description")]
        public string SubMerchantServiceDescription { get; set; }

        /// <summary>
        /// 二级商户的服务名称
        /// </summary>
        [XmlElement("sub_merchant_service_name")]
        public string SubMerchantServiceName { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额。 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。 如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        [XmlElement("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 商户签约号
        /// </summary>
        [XmlElement("withholding_agreement_no")]
        public string WithholdingAgreementNo { get; set; }

        /// <summary>
        /// 代扣详情信息
        /// </summary>
        [XmlElement("withholding_detail")]
        public WithholdingDetail WithholdingDetail { get; set; }
    }
}
