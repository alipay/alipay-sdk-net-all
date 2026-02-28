using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTradereconApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowTradereconApplyModel : AopObject
    {
        /// <summary>
        /// 物流公司编码，由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式。 ANT_MYBANK(网商银行模式) SPDB(浦发银行模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 业务幂等号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 母户卡号
        /// </summary>
        [XmlElement("parent_card_no")]
        public string ParentCardNo { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配； 如果mode为浦发银行，则为为商户接入浦发时生成的应用标识；
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 账单日期，格式为yyyyMMdd mode为网商银行时必填：   日期规则如下: 1. query_date < Today (当日生成昨日对账单，所以申请时间需早于当日) 2. 六个月前的当月一日 <= query_date 3. isv入驻时间 <= query_date  mode为浦发银行时必填：   当交易流水号、均为空时，账单日期(交易开始日期)、交易结束日期必填,yyyyMMdd,
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 最大为20,最小为1
        /// </summary>
        [XmlElement("query_num")]
        public string QueryNum { get; set; }

        /// <summary>
        /// mode为网商银行时： 下载账单类型 交易对账单：SYSTEM_TRADE_RECON 交易明细对账单：SYSTEM_TRADE_DETAIL_RECON  mode为浦发银行时： 01-客户入金 02-客户出金 06-子户互转(同一监管账户下的账户互转)
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 浦发银行特定场景参数,当mode=SPDB时必选
        /// </summary>
        [XmlElement("spdb_spec_params")]
        public FreightFlowSpdbSpecParams SpdbSpecParams { get; set; }

        /// <summary>
        /// 最小为1
        /// </summary>
        [XmlElement("start_num")]
        public string StartNum { get; set; }

        /// <summary>
        /// 子户号
        /// </summary>
        [XmlElement("sub_card_no")]
        public string SubCardNo { get; set; }
    }
}
