using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntstarshipHomeQueryResponse.
    /// </summary>
    public class AlipayUserAntstarshipHomeQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 全家福信息
        /// </summary>
        [XmlElement("family_info")]
        public OpenApiFamilyInfoVO FamilyInfo { get; set; }

        /// <summary>
        /// sku列表信息
        /// </summary>
        [XmlArray("sku_info_list")]
        [XmlArrayItem("open_api_sku_info_v_o")]
        public List<OpenApiSkuInfoVO> SkuInfoList { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
