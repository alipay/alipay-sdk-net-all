using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfexportInputfieldQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportInputfieldQueryResponse : AopResponse
    {
        /// <summary>
        /// 输出的输入域列表
        /// </summary>
        [XmlArray("input_fields")]
        [XmlArrayItem("j_f_export_input_field_model")]
        public List<JFExportInputFieldModel> InputFields { get; set; }
    }
}
