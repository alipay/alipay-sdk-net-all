using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocTransferApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocTransferApplyModel : AopObject
    {
        /// <summary>
        /// 藏品上架时间
        /// </summary>
        [XmlElement("asset_on_sale_time")]
        public string AssetOnSaleTime { get; set; }

        /// <summary>
        /// 鲸探授权用户id(已转加密)
        /// </summary>
        [XmlElement("from_id_no")]
        public string FromIdNo { get; set; }

        /// <summary>
        /// 发起账号类型， 鲸探授权用户id(已转加密):OPEN_UID
        /// </summary>
        [XmlElement("from_id_type")]
        public string FromIdType { get; set; }

        /// <summary>
        /// 发起用户注册时间
        /// </summary>
        [XmlElement("from_user_register_time")]
        public string FromUserRegisterTime { get; set; }

        /// <summary>
        /// 资产nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 调用方交易单号，业务系统用于做幂等校验
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 鲸探授权用户id(已转加密)
        /// </summary>
        [XmlElement("to_id_no")]
        public string ToIdNo { get; set; }

        /// <summary>
        /// 接收方id类型 鲸探授权用户id(已转加密):OPEN_UID
        /// </summary>
        [XmlElement("to_id_type")]
        public string ToIdType { get; set; }

        /// <summary>
        /// 接收方注册时间
        /// </summary>
        [XmlElement("to_user_register_time")]
        public string ToUserRegisterTime { get; set; }

        /// <summary>
        /// 交易金额，单位: 分
        /// </summary>
        [XmlElement("trade_cent")]
        public long TradeCent { get; set; }

        /// <summary>
        /// 交易单号，支付单号
        /// </summary>
        [XmlElement("trade_order_no")]
        public string TradeOrderNo { get; set; }

        /// <summary>
        /// 流转操作类型
        /// </summary>
        [XmlElement("transfer_operate")]
        public string TransferOperate { get; set; }

        /// <summary>
        /// 流转类型
        /// </summary>
        [XmlElement("transfer_type")]
        public string TransferType { get; set; }
    }
}
