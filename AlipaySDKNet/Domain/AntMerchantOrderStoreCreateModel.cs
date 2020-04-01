using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantOrderStoreCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantOrderStoreCreateModel : AopObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展参数: CONSUMER_COUNT ：到店人数, 样例：3 SERVICE_ITEM：服务项目，样例: ["洗头","美发"] SERVICE_TIME: 到店时间，样例: 2020-03-10 09:00:00
        /// </summary>
        [XmlArray("ext")]
        [XmlArrayItem("order_ext")]
        public List<OrderExt> Ext { get; set; }

        /// <summary>
        /// 订单相关的商品信息
        /// </summary>
        [XmlArray("goods_info_list")]
        [XmlArrayItem("store_order_good")]
        public List<StoreOrderGood> GoodsInfoList { get; set; }

        /// <summary>
        /// 订单超时时间，默认60分钟
        /// </summary>
        [XmlElement("invalid_time")]
        public long InvalidTime { get; set; }

        /// <summary>
        /// 订单的描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 插件业务场景code，预约为ShopService
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 线下门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 线上店的ID
        /// </summary>
        [XmlElement("store_open_id")]
        public string StoreOpenId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
