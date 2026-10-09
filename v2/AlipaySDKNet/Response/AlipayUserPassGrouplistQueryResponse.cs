using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserPassGrouplistQueryResponse.
    /// </summary>
    public class AlipayUserPassGrouplistQueryResponse : AopResponse
    {
        /// <summary>
        /// 券信息列表
        /// </summary>
        [XmlArray("pass_info_list")]
        [XmlArrayItem("pass_info_open_api_model")]
        public List<PassInfoOpenApiModel> PassInfoList { get; set; }
    }
}
