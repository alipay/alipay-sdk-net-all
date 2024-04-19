using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockQualifiedInvestorApplyResponse.
    /// </summary>
    public class AntfortuneStockQualifiedInvestorApplyResponse : AopResponse
    {
        /// <summary>
        /// 签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户在支付宝总资产获取时间
        /// </summary>
        [XmlElement("alipay_asset_time")]
        public string AlipayAssetTime { get; set; }

        /// <summary>
        /// 支付宝金融总资产金额，单位元；精度到分
        /// </summary>
        [XmlElement("alipay_total_asset")]
        public string AlipayTotalAsset { get; set; }

        /// <summary>
        /// 余额宝首次交易时间，格式yyyyMMdd
        /// </summary>
        [XmlElement("first_yeb_trade_day")]
        public string FirstYebTradeDay { get; set; }

        /// <summary>
        /// 是否有合投材料
        /// </summary>
        [XmlElement("has_material")]
        public bool HasMaterial { get; set; }

        /// <summary>
        /// 材料列表
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("investor_material_info")]
        public List<InvestorMaterialInfo> MaterialList { get; set; }

        /// <summary>
        /// 材料类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 码商收入金额，单位元；精度到分
        /// </summary>
        [XmlElement("total_income")]
        public string TotalIncome { get; set; }

        /// <summary>
        /// traceId，用来唯一定位某次调用，方便问题排查
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
