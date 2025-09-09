using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestWelfareforestBatchqueryResponse.
    /// </summary>
    public class AlipaySocialAntforestWelfareforestBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用于页面展示使用的图片等信息
        /// </summary>
        [XmlElement("global_display_info")]
        public string GlobalDisplayInfo { get; set; }

        /// <summary>
        /// 公益林详情信息列表
        /// </summary>
        [XmlArray("welfare_forest_detail_list")]
        [XmlArrayItem("welfare_forest_detail_d_t_o")]
        public List<WelfareForestDetailDTO> WelfareForestDetailList { get; set; }
    }
}
