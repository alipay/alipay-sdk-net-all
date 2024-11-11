using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiFqAwardReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiFqAwardReceiveModel : AopObject
    {
        /// <summary>
        /// bankAgentMode表示间联，pid需要穿isv_pid normalOrderMode表示直连，pid即商户的pid platformBusinessMode表示直付通
        /// </summary>
        [XmlElement("acquire_mode")]
        public string AcquireMode { get; set; }

        /// <summary>
        /// true-有优惠 false-无优惠
        /// </summary>
        [XmlElement("discount")]
        public bool Discount { get; set; }

        /// <summary>
        /// 交易的商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 产生交易的商品数量
        /// </summary>
        [XmlElement("goods_num")]
        public string GoodsNum { get; set; }

        /// <summary>
        /// 交易商品的类目名称
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 所选行业名称，纯文本即可
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 间联下传isv_pid，直连下传pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 产生交易的收单产品
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 线下间联场景offline
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 即二级商户的id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 商品价格(分)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 产生交易支付的地点
        /// </summary>
        [XmlElement("trade_place")]
        public string TradePlace { get; set; }

        /// <summary>
        /// 产生支付的方式
        /// </summary>
        [XmlElement("trading")]
        public string Trading { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
