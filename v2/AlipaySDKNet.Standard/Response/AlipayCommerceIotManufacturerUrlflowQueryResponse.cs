using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotManufacturerUrlflowQueryResponse.
    /// </summary>
    public class AlipayCommerceIotManufacturerUrlflowQueryResponse : AopResponse
    {
        /// <summary>
        /// 失败列表
        /// </summary>
        [XmlArray("fail_sn_detail_list")]
        [XmlArrayItem("fail_sn_detail")]
        public List<FailSnDetail> FailSnDetailList { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("flow_no")]
        public string FlowNo { get; set; }

        /// <summary>
        /// 外部业务系统业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
