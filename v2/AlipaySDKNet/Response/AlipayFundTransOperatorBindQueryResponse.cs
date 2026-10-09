using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransOperatorBindQueryResponse.
    /// </summary>
    public class AlipayFundTransOperatorBindQueryResponse : AopResponse
    {
        /// <summary>
        /// true:已绑定 false:未绑定
        /// </summary>
        [XmlElement("bind")]
        public bool Bind { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作员角色
        /// </summary>
        [XmlArray("operator_role")]
        [XmlArrayItem("string")]
        public List<string> OperatorRole { get; set; }
    }
}
