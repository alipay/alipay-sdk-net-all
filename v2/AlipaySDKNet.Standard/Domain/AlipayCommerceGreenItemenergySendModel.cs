using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGreenItemenergySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGreenItemenergySendModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 绿色能量发放归属方信息, 说明：  (1)如果该复杂对象不填，根据openAPI标准流程决定能量发放归属方  -商户自研, 那么能量发放归属方就是商户.   -第三方应用授权, 那么能量发放归属方就是授权的商户. 参考https://opendocs.alipay.com/isv/10467/xldcyq  (2)如果填写，则认为能量发放归属方就是merchant_pid对应的商户.
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongGreenMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 商品69码，被扫商品的69码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 行业类型。枚举: 快消:FMCG; 酒店:HOTEL; 智能售卖:AUTOMAT; 景区:RESORT;高校:HIGHSCHOOL;品牌：FASHION; 商圈综合体:MALL; 充电宝:POWERBANK; 物流:LOGISTICS; 餐饮:CATERING;
        /// </summary>
        [XmlElement("industry_type")]
        public string IndustryType { get; set; }

        /// <summary>
        /// 支付宝绿色阵地订单详情跳转链接,商户可自定义跳转到自己的小程序（落地页）如果是小程序链接且带有参数，如示例中page=pages%2Fmap%2Findex%3FchInfo%3D%2520locationcard部分需要encode，否则page后面的参数会丢失。
        /// </summary>
        [XmlElement("order_link")]
        public string OrderLink { get; set; }

        /// <summary>
        /// 被扫码的二维码ID
        /// </summary>
        [XmlElement("qr_code_id")]
        public string QrCodeId { get; set; }

        /// <summary>
        /// 扫码时间
        /// </summary>
        [XmlElement("scan_time")]
        public string ScanTime { get; set; }
    }
}
