using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppMarketingConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppMarketingConsultModel : AopObject
    {
        /// <summary>
        /// 业务场景，用于区分商户具体的咨场景，示例：ORDER_PAGE：下单页营销咨询；其他新场景接入时需与支付宝协商约定
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 使用morse匿名技术对原始手机号MD5值进行盲化后的结果(可通过morse工具包生成)； 若接口调用采用morse匿名方式，此字段必须与混淆后的手机号列表(confused_mobile_list)字段一起传入，二者缺一不可
        /// </summary>
        [XmlElement("blind_mobile")]
        public string BlindMobile { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 身份证类别
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 混淆后的手机号MD5值列表； 若接口调用采用morse匿名方式，此字段必须与盲化的原始手机号MD5值(blind_mobile)字段一起传入，二者缺一不可；
        /// </summary>
        [XmlArray("confused_mobile_list")]
        [XmlArrayItem("string")]
        public List<string> ConfusedMobileList { get; set; }

        /// <summary>
        /// 设备号，设备号类型由device_type字段指定；（设备号或morse匿名查询，两种匹配方式至少有一种参数不能为空）
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备号类型，与设备号device_id字段组合使用，默认为IMEI
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 手机号md5值密文；（已废弃不支持）
        /// </summary>
        [XmlElement("encrypted_mobile")]
        public string EncryptedMobile { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式，其它说明详见商品明细说明；取值可参考alipay.trade.app.pay(app支付接口2.0)
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 历史支付宝订单号
        /// </summary>
        [XmlElement("history_alipay_trade_no")]
        public string HistoryAlipayTradeNo { get; set; }

        /// <summary>
        /// 商户用户id
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 已废弃不支持
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 是否需要查询反作弊等级值，默认为false不查询
        /// </summary>
        [XmlElement("need_query_anti_rank")]
        public string NeedQueryAntiRank { get; set; }

        /// <summary>
        /// 是否需要查询营销偏好等级值，默认为false不查询
        /// </summary>
        [XmlElement("need_query_marketing_rank")]
        public string NeedQueryMarketingRank { get; set; }

        /// <summary>
        /// 是否需要返回标签信息；默认为false不返回
        /// </summary>
        [XmlElement("need_return_tag")]
        public bool NeedReturnTag { get; set; }

        /// <summary>
        /// OpenId是用户在应用下的唯一用户标识。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠参数 注：仅与支付宝协商后可用；取值可参考alipay.trade.app.pay(app支付接口2.0)
        /// </summary>
        [XmlElement("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 收款支付宝账号对应的支付宝唯一用户号。 以2088开头的纯16位数字
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]（total_amount与undiscountable_amount两个字段需至少有一个不能为空）
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]（total_amount与undiscountable_amount两个字段需至少有一个不能为空）
        /// </summary>
        [XmlElement("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
