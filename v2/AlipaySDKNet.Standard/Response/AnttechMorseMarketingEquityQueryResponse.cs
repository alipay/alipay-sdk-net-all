using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingEquityQueryResponse.
    /// </summary>
    public class AnttechMorseMarketingEquityQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于问题定位
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商务项目ID，由摩斯配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 券结果信息列表
        /// </summary>
        [XmlArray("voucher_result_info_list")]
        [XmlArrayItem("voucher_result_info")]
        public List<VoucherResultInfo> VoucherResultInfoList { get; set; }
    }
}
