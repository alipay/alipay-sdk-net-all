using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddCateringOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddCateringOrderCreateModel : AopObject
    {
        /// <summary>
        /// 商品促销活动，订单确认接口中的 activity_list 透传，无商品促销活动可不传
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("activity_bean")]
        public List<ActivityBean> ActivityList { get; set; }

        /// <summary>
        /// 买家唯一标识
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 桌码拓展对象
        /// </summary>
        [XmlElement("code_ext")]
        public CodeExtBean CodeExt { get; set; }

        /// <summary>
        /// 就餐人数，单位人。如果没有选择就餐人数，默认传1
        /// </summary>
        [XmlElement("dining_number")]
        public long DiningNumber { get; set; }

        /// <summary>
        /// 备注，用户没填可不传
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单类型，固定传 TO_SHOP
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 外部订单号，保证订单全局唯一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 请求时间戳，1970至今毫秒值
        /// </summary>
        [XmlElement("request_stamp")]
        public long RequestStamp { get; set; }

        /// <summary>
        /// 必填信息，用户输入的必填项信息。关于必填项表单渲染，可以从订单必填项查询接口查询
        /// </summary>
        [XmlArray("require_info_list")]
        [XmlArrayItem("require_bean")]
        public List<RequireBean> RequireInfoList { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_bean")]
        public List<SkuBean> SkuList { get; set; }

        /// <summary>
        /// 用户看到的配送费，单位元。订单确认接口返回的 delivery_fee 字段
        /// </summary>
        [XmlElement("view_delivery_cost")]
        public string ViewDeliveryCost { get; set; }

        /// <summary>
        /// 用户看到需支付金额，单位元。订单确认接口返回的 payment_price 付款价
        /// </summary>
        [XmlElement("view_total_price")]
        public string ViewTotalPrice { get; set; }
    }
}
