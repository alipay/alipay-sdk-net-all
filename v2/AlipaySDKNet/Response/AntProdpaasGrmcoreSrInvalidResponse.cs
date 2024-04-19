using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasGrmcoreSrInvalidResponse.
    /// </summary>
    public class AntProdpaasGrmcoreSrInvalidResponse : AopResponse
    {
        /// <summary>
        /// 是否同意维护或作废
        /// </summary>
        [XmlElement("flag")]
        public bool Flag { get; set; }

        /// <summary>
        /// 校验不通过供应商code列表
        /// </summary>
        [XmlArray("suppliers")]
        [XmlArrayItem("string")]
        public List<string> Suppliers { get; set; }
    }
}
