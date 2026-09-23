using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersalepageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderAftersalepageQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("aftersale_simple_info_v_o")]
        public List<AftersaleSimpleInfoVO> DataList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
