using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxConsultResponse.
    /// </summary>
    public class AlipayOpenSearchBoxConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否准入，false代表不准入
        /// </summary>
        [XmlElement("access")]
        public bool Access { get; set; }

        /// <summary>
        /// 不准入项列表。不准入项用字符串描述，可参照接口文档和<a href="https://opendocs.alipay.com/pre-open/0311q3#%E5%87%86%E5%85%A5%E6%9D%A1%E4%BB%B6">准入条件</a>，进行调整以达到申请要求
        /// </summary>
        [XmlArray("not_pass_items")]
        [XmlArrayItem("string")]
        public List<string> NotPassItems { get; set; }
    }
}
