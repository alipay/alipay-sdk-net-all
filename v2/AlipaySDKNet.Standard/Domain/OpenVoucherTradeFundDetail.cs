using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenVoucherTradeFundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OpenVoucherTradeFundDetail : AopObject
    {
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 资产编码
        /// </summary>
        [XmlElement("assets_code")]
        public string AssetsCode { get; set; }

        /// <summary>
        /// 业务上下文
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 上层业务事件码
        /// </summary>
        [XmlElement("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 上层业务产品码
        /// </summary>
        [XmlElement("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 现金价值，单位分
        /// </summary>
        [XmlElement("cash")]
        public long Cash { get; set; }

        /// <summary>
        /// 端到端事件码
        /// </summary>
        [XmlElement("cnl_ev_code")]
        public string CnlEvCode { get; set; }

        /// <summary>
        /// 端到端流水号
        /// </summary>
        [XmlElement("cnl_no")]
        public string CnlNo { get; set; }

        /// <summary>
        /// 端到端产品码
        /// </summary>
        [XmlElement("cnl_pd_code")]
        public string CnlPdCode { get; set; }

        /// <summary>
        /// 交易详情Id
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 详细标签
        /// </summary>
        [XmlElement("detail_tag")]
        public string DetailTag { get; set; }

        /// <summary>
        /// 本层事件码
        /// </summary>
        [XmlElement("ev_code")]
        public string EvCode { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金成分流水信息
        /// </summary>
        [XmlArray("fund_component_detail_list")]
        [XmlArrayItem("open_fund_component_detail_d_t_o")]
        public List<OpenFundComponentDetailDTO> FundComponentDetailList { get; set; }

        /// <summary>
        /// 资金信息
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("open_fund_info")]
        public List<OpenFundInfo> FundInfos { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品列表:单品券返回
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 本层产品码
        /// </summary>
        [XmlElement("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单状态，初始状态:I 成功状态:S
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板Id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券描述
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券Id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
