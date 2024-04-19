using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneQuotationPlateIndexQueryResponse.
    /// </summary>
    public class AntfortuneQuotationPlateIndexQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于返回板块的信息
        /// </summary>
        [XmlArray("plate_list")]
        [XmlArrayItem("plate_info_for_yi_cai")]
        public List<PlateInfoForYiCai> PlateList { get; set; }

        /// <summary>
        /// 板块数据
        /// </summary>
        [XmlElement("res")]
        public string Res { get; set; }
    }
}
