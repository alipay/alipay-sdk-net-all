using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountFinriskCompanyVerifyGetResponse.
    /// </summary>
    public class AlipayAccountFinriskCompanyVerifyGetResponse : AopResponse
    {
        /// <summary>
        /// 二代结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 三代结果码
        /// </summary>
        [XmlElement("result_code_third")]
        public string ResultCodeThird { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否业务处理成功。 true：处理成功；false：处理失败。 默认：false
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// 防伪结果信息
        /// </summary>
        [XmlArray("verify_info")]
        [XmlArrayItem("verify_info_v_o")]
        public List<VerifyInfoVO> VerifyInfo { get; set; }

        /// <summary>
        /// 防伪结果码
        /// </summary>
        [XmlElement("verify_result_code")]
        public string VerifyResultCode { get; set; }

        /// <summary>
        /// 防伪结果描述
        /// </summary>
        [XmlElement("verify_result_desc")]
        public string VerifyResultDesc { get; set; }
    }
}
