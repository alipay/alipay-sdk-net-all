using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonGroupendorseQueryResponse.
    /// </summary>
    public class AlipayInsSceneCommonGroupendorseQueryResponse : AopResponse
    {
        /// <summary>
        /// 子批单的实付保费;单位分
        /// </summary>
        [XmlElement("endorse_fee")]
        public long EndorseFee { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 主批单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子单数量
        /// </summary>
        [XmlElement("sub_order_count")]
        public long SubOrderCount { get; set; }

        /// <summary>
        /// 子单列表
        /// </summary>
        [XmlArray("sub_order_info_list")]
        [XmlArrayItem("ins_sub_order_employment_digest")]
        public List<InsSubOrderEmploymentDigest> SubOrderInfoList { get; set; }

        /// <summary>
        /// 主批单号
        /// </summary>
        [XmlElement("summary_endorse_order_no")]
        public string SummaryEndorseOrderNo { get; set; }

        /// <summary>
        /// 总保费;单位分
        /// </summary>
        [XmlElement("summary_premium")]
        public long SummaryPremium { get; set; }
    }
}
