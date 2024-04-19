using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEmploymentGroupbatchQueryResponse.
    /// </summary>
    public class AlipayInsSceneEmploymentGroupbatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 批次单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子订单信息列表
        /// </summary>
        [XmlArray("sub_order_info_list")]
        [XmlArrayItem("ins_sub_order_employment_digest")]
        public List<InsSubOrderEmploymentDigest> SubOrderInfoList { get; set; }
    }
}
