using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockDarwinQueryResponse.
    /// </summary>
    public class AntfortuneStockDarwinQueryResponse : AopResponse
    {
        /// <summary>
        /// 达尔文参数
        /// </summary>
        [XmlArray("darwin_parameter")]
        [XmlArrayItem("darwin_parameter")]
        public List<DarwinParameter> DarwinParameter { get; set; }

        /// <summary>
        /// 实验id
        /// </summary>
        [XmlElement("exp_id")]
        public string ExpId { get; set; }
    }
}
