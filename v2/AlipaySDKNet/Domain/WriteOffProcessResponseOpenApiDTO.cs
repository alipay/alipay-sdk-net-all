using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WriteOffProcessResponseOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WriteOffProcessResponseOpenApiDTO : AopObject
    {
        /// <summary>
        /// 核销明细结果返回DTO
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("write_off_process_detail_response_open_api_d_t_o")]
        public List<WriteOffProcessDetailResponseOpenApiDTO> DetailList { get; set; }

        /// <summary>
        /// 外部幂等值
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
