using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthBizParam Data Structure.
    /// </summary>
    [Serializable]
    public class AuthBizParam : AopObject
    {
        /// <summary>
        /// 出资限制模型列表
        /// </summary>
        [XmlArray("fund_limit_list")]
        [XmlArrayItem("fund_limit")]
        public List<FundLimit> FundLimitList { get; set; }
    }
}
