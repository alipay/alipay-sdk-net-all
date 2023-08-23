using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfInstcodeQueryResponse.
    /// </summary>
    public class AlipayEbppJfInstcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的机构信息列表
        /// </summary>
        [XmlArray("inst_code_list")]
        [XmlArrayItem("puc_inst_code")]
        public List<PucInstCode> InstCodeList { get; set; }
    }
}
