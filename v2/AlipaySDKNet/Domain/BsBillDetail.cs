using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BsBillDetail : AopObject
    {
        /// <summary>
        /// 西溪路569号
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 交易发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 商家品牌
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 门店归属市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 交易N设备SN号。如果交易不经过设备，则没有该值
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 交易数字化门店名称
        /// </summary>
        [XmlElement("digital_poi_name")]
        public string DigitalPoiName { get; set; }

        /// <summary>
        /// 单品累计补贴金额，人民币CNY。如果有多件优惠，则是多件优惠的补贴金额。如果是平台混资计划，则仅包括商户出资部分。
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 门店归属区
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 参与优惠的商品数量
        /// </summary>
        [XmlElement("goods_num")]
        public long GoodsNum { get; set; }

        /// <summary>
        /// 交易商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 订单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 交易号，已脱敏。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 整单累计补贴金额，人民币CNY，核销单（order_id）维度。 如果是退款单，则代表当前优惠退款金额。 退款金额可能少于核销补贴金额，取决于商户是否整单退。
        /// </summary>
        [XmlElement("order_subsidy_amount")]
        public string OrderSubsidyAmount { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 门店归属省
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品单价，人民币CNY
        /// </summary>
        [XmlElement("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
