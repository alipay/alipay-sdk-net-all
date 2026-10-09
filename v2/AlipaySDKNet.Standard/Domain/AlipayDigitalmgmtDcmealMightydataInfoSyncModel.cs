using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtDcmealMightydataInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtDcmealMightydataInfoSyncModel : AopObject
    {
        /// <summary>
        /// 交易时间毫秒级时间戳
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 园区名称
        /// </summary>
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 城市名称，需要包含“市”，如杭州市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 智盘平台菜品信息
        /// </summary>
        [XmlArray("dish_details")]
        [XmlArrayItem("dcmeal_dish_detail")]
        public List<DcmealDishDetail> DishDetails { get; set; }

        /// <summary>
        /// 餐次，早参(breakfast),午餐(lunch)，晚餐(dinner)，夜宵(night)
        /// </summary>
        [XmlElement("meal_type")]
        public string MealType { get; set; }

        /// <summary>
        /// 如果是刷卡，传卡号。 如果是企业码，传uuid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单类型，付款/退款，consume为付款，refund为退款
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 支付详情，具体参考接口文档，json字符串存储。
        /// </summary>
        [XmlArray("pay_details")]
        [XmlArrayItem("dcmeal_pay_detail")]
        public List<DcmealPayDetail> PayDetails { get; set; }

        /// <summary>
        /// 支付方式，刷卡(card)/刷脸(face)/扫码(qrcode)
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 订单发生的餐厅名称
        /// </summary>
        [XmlElement("restaurant_name")]
        public string RestaurantName { get; set; }

        /// <summary>
        /// 产生订单的档口名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 终端订单号
        /// </summary>
        [XmlElement("term_document_id")]
        public string TermDocumentId { get; set; }

        /// <summary>
        /// 发生支付的档口编码
        /// </summary>
        [XmlElement("term_name")]
        public string TermName { get; set; }

        /// <summary>
        /// 消费金额，单位元。保留两位小数
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 刷卡支付时可为空，企业码时为订单号，不可为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 如果是刷卡，传卡号。 如果是企业码，传uuid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 智盘平台seq，全局唯一
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
