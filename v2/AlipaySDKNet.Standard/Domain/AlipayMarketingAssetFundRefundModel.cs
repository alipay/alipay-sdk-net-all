using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingAssetFundRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingAssetFundRefundModel : AopObject
    {
        /// <summary>
        /// 权益资金信息，包括权益id和权益数量
        /// </summary>
        [XmlArray("asset_fund_infos")]
        [XmlArrayItem("asset_fund_d_t_o")]
        public List<AssetFundDTO> AssetFundInfos { get; set; }

        /// <summary>
        /// 资产id类型，目前包括ASSET_TEMPLATE(模板)和ASSET_INSTANCE(实例)两种
        /// </summary>
        [XmlElement("asset_id_type")]
        public string AssetIdType { get; set; }

        /// <summary>
        /// 资产类型，包括VOUCHER(券)、POINT(积分)、CARD(卡)等多种资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 不同资金业务场景，taobaoWechatPay(微信支付)、taobaoAlipayPay(支付宝支付)
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 业务号，用于幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 资产资金场景，包括BIZFUND_SEND_CASH（现金发放）BIZFUND_SEND_CASH_REVERSE(现金发放逆向)等
        /// </summary>
        [XmlElement("fund_scene")]
        public string FundScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 正向核销流水单据id
        /// </summary>
        [XmlElement("use_order_id")]
        public string UseOrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
