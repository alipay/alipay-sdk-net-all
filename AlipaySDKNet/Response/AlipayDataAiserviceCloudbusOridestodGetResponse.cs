using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOridestodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusOridestodGetResponse : AopResponse
    {
        /// <summary>
        /// 7OD  结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("ori_dest_od_item")]
        public List<OriDestOdItem> Result { get; set; }
    }
}
