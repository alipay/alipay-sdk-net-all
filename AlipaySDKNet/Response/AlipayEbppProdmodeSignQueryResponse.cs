using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppProdmodeSignQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回签约信息数据对象，主要包含:产品编码、产品版本、生效时间、到期时间等
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("sign_result_value")]
        public List<SignResultValue> DataList { get; set; }
    }
}
