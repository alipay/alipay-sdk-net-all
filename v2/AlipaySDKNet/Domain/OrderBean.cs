using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderBean Data Structure.
    /// </summary>
    [Serializable]
    public class OrderBean : AopObject
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("activity_bean")]
        public List<ActivityBean> ActivityList { get; set; }

        /// <summary>
        /// 取餐号
        /// </summary>
        [XmlElement("claim_code")]
        public string ClaimCode { get; set; }

        /// <summary>
        /// 桌码扩展信息
        /// </summary>
        [XmlElement("code_ext")]
        public CodeExtBean CodeExt { get; set; }

        /// <summary>
        /// 创建时间，1970至今毫秒值
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 商品订单列表
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order_bean")]
        public List<ItemOrderBean> ItemOrderList { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态是枚举，数量大于10，具体参见OrderStatusEnum
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 跟order_status对应，枚举数量大于10，枚举详见OrderStatusEnum
        /// </summary>
        [XmlElement("order_status_desc")]
        public string OrderStatusDesc { get; set; }

        /// <summary>
        /// 指定的时刻，非时间戳， 为不可度量参数
        /// </summary>
        [XmlElement("order_timeout")]
        public string OrderTimeout { get; set; }

        /// <summary>
        /// TO_SHOP，当前只支持到店类型
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 实际价格
        /// </summary>
        [XmlElement("real_price")]
        public string RealPrice { get; set; }

        /// <summary>
        /// 订单必填信息
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
        /// 桌号
        /// </summary>
        [XmlElement("table_no")]
        public string TableNo { get; set; }

        /// <summary>
        /// 超时时间，1970至今毫秒值
        /// </summary>
        [XmlElement("timeout_stamp")]
        public long TimeoutStamp { get; set; }

        /// <summary>
        /// 商品总价
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
