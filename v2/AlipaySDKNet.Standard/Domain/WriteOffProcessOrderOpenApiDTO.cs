using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WriteOffProcessOrderOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WriteOffProcessOrderOpenApiDTO : AopObject
    {
        /// <summary>
        /// 外部这次请求传入的幂等号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 申请核销的左右手明细单据
        /// </summary>
        [XmlArray("write_off_detail_open_api_list")]
        [XmlArrayItem("write_off_left_right_detail_open_api_d_t_o")]
        public List<WriteOffLeftRightDetailOpenApiDTO> WriteOffDetailOpenApiList { get; set; }
    }
}
