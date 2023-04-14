using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryBizinfoQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryBizinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务机构简称
        /// </summary>
        [XmlElement("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型，公服业务：IND
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务数据码，标识业务场景
        /// </summary>
        [XmlElement("data_code")]
        public string DataCode { get; set; }

        /// <summary>
        /// 机构结果码
        /// </summary>
        [XmlElement("org_result_code")]
        public string OrgResultCode { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回结果上下文，json格式
        /// </summary>
        [XmlElement("result_context")]
        public string ResultContext { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
