using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneQuotationNimitzDatasetQueryResponse.
    /// </summary>
    public class AntfortuneQuotationNimitzDatasetQueryResponse : AopResponse
    {
        /// <summary>
        /// Nimitz 数据查询返回值，json形式
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 已弃用，返回时不要填充此字段，填充了也不会处理。
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("obj_rs_data_d_t_o")]
        public List<ObjRsDataDTO> ResultData { get; set; }

        /// <summary>
        /// 已弃用，返回时不要填充此字段，填充了也不会处理。
        /// </summary>
        [XmlElement("result_status")]
        public Status ResultStatus { get; set; }
    }
}
