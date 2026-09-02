using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthArchiveReverseResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthArchiveReverseResponse : AopResponse
    {
        /// <summary>
        /// 整体是否成功（删除异常等失败场景返回 false；NOT_FOUND / 参数缺失等幂等场景仍返回 true）
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 整体结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result_details")]
        [XmlArrayItem("reverse_result_list")]
        public List<ReverseResultList> ResultDetails { get; set; }
    }
}
