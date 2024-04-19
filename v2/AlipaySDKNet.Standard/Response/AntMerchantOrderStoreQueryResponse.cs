using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantOrderStoreQueryResponse.
    /// </summary>
    public class AntMerchantOrderStoreQueryResponse : AopResponse
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
        /// 业务场景对应的扩展字段
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
        /// 订单的描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单的ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
