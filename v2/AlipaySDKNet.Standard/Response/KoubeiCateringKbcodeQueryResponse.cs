using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringKbcodeQueryResponse.
    /// </summary>
    public class KoubeiCateringKbcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑码信息列表
        /// </summary>
        [XmlArray("code_info_list")]
        [XmlArrayItem("kb_code_info_v_o")]
        public List<KbCodeInfoVO> CodeInfoList { get; set; }

        /// <summary>
        /// 当前页码（大于0的整数）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页返回的记录数（0~100的整数）
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 口碑码总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
