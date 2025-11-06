using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetVoucherTemplateInfoQueryResponse.
    /// </summary>
    public class AlipayAssetVoucherTemplateInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 券模版资产编码
        /// </summary>
        [XmlElement("asset_code")]
        public string AssetCode { get; set; }

        /// <summary>
        /// 资金信息列表，其中fundType=FUND_SCHEME时fundAccount对应资金池id，其余情况对应出资账号
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("vcp_fund_info")]
        public List<VcpFundInfo> FundInfos { get; set; }

        /// <summary>
        /// 券产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 券发放截止时间
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放起始时间
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 券模版状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
