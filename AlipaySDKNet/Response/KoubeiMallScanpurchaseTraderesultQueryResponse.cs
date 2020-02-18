using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseTraderesultQueryResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseTraderesultQueryResponse : AopResponse
    {
        /// <summary>
        /// banner的位置广告图片。json格式数据
        /// </summary>
        [XmlElement("banner")]
        public string Banner { get; set; }

        /// <summary>
        /// 买家支付宝用户ID
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 消费送数据信息
        /// </summary>
        [XmlElement("consume_voucher")]
        public MallConsumeVoucher ConsumeVoucher { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("goods_details")]
        [XmlArrayItem("mall_goods_detail")]
        public List<MallGoodsDetail> GoodsDetails { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商圈场景订单
        /// </summary>
        [XmlElement("scene_order")]
        public SceneOrder SceneOrder { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID
        /// </summary>
        [XmlElement("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 核销码信息
        /// </summary>
        [XmlElement("user_verify")]
        public MallUserVerify UserVerify { get; set; }
    }
}
