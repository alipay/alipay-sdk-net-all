using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryPerformOrderCreateModel : AopObject
    {
        /// <summary>
        /// 通过支付宝收银台支付的资产详情，主要包括该笔订单的资产类型、资产金额、资产协议、支付描述等
        /// </summary>
        [XmlElement("alipay_trade_asset")]
        public TradeAssetRequest AlipayTradeAsset { get; set; }

        /// <summary>
        /// 账单金额(订单原价，金额元)
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 商户创单类型。用户主动创建指需要用户主动拉起收银台，用户主动确认后例如输入付款密码进行支付。商户直连代扣创建指商户和用户已签约代扣协议，由商户主动发起代扣、不需要用户主动确认，该场景商户必传用户代扣协议号。
        /// </summary>
        [XmlElement("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 透传二级商户smid 例如2088**********33
        /// </summary>
        [XmlElement("inst_smid")]
        public string InstSmid { get; set; }

        /// <summary>
        /// 商户app_id维度下的用户标识，目前为47位字符串。ser_id和open_id必传其一，建议商户传递open_id。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。 有根据商户订单号支付幂等需求的必传。
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 目前只支持直付通模式的商家分账。
        /// </summary>
        [XmlArray("profit_sharing_list")]
        [XmlArrayItem("profit_sharing_request")]
        public List<ProfitSharingRequest> ProfitSharingList { get; set; }

        /// <summary>
        /// 业务服务用户载体(户号\卡号\手机号等)，比如手机充值业务，充值手机号即为该服务载体。
        /// </summary>
        [XmlElement("service_account")]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// 订单超时未支付的关单时间 单位秒。 外部传入则以传入时间为准，否则以系统默认10分钟未支付则关闭订单。
        /// </summary>
        [XmlElement("timeout_close")]
        public long TimeoutClose { get; set; }

        /// <summary>
        /// 行业业务受理平台-服务模型唯一编码。该编码由业务BD入驻行业业务受理平台后分配给外部商户。
        /// </summary>
        [XmlElement("unique_code")]
        public string UniqueCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId，目前为16位纯数字。user_id和open_id必传其一。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
