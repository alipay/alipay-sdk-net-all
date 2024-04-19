using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IoTBPaaSMerchantOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IoTBPaaSMerchantOrderInfo : AopObject
    {
        /// <summary>
        /// 优惠活动信息列表
        /// </summary>
        [XmlArray("activity_item_list")]
        [XmlArrayItem("io_t_b_paa_s_merchant_order_item_info")]
        public List<IoTBPaaSMerchantOrderItemInfo> ActivityItemList { get; set; }

        /// <summary>
        /// 外送费
        /// </summary>
        [XmlElement("courier_fee")]
        public string CourierFee { get; set; }

        /// <summary>
        /// 顾客性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 外送地址,外卖订单才有
        /// </summary>
        [XmlElement("order_address")]
        public string OrderAddress { get; set; }

        /// <summary>
        /// 买家联系方式,外卖订单才有
        /// </summary>
        [XmlElement("order_contact")]
        public string OrderContact { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("order_item_list")]
        [XmlArrayItem("io_t_b_paa_s_merchant_order_item_info")]
        public List<IoTBPaaSMerchantOrderItemInfo> OrderItemList { get; set; }

        /// <summary>
        /// 商品总数量
        /// </summary>
        [XmlElement("order_item_total_quantity")]
        public string OrderItemTotalQuantity { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("order_memo")]
        public string OrderMemo { get; set; }

        /// <summary>
        /// 取餐号
        /// </summary>
        [XmlElement("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 订单总价
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 订单实际价格
        /// </summary>
        [XmlElement("order_real_price")]
        public string OrderRealPrice { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 到店订单类型:SHOP_SERVICE 到家订单类型:HOME_SERVICE
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 打包费
        /// </summary>
        [XmlElement("package_fee")]
        public string PackageFee { get; set; }

        /// <summary>
        /// 必填信息
        /// </summary>
        [XmlArray("require_info_list")]
        [XmlArrayItem("io_t_b_paa_s_merchant_order_require_info")]
        public List<IoTBPaaSMerchantOrderRequireInfo> RequireInfoList { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 顾客姓名,脱敏处理
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
