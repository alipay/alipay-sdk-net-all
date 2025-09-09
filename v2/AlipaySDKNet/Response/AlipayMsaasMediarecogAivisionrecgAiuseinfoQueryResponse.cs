using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionrecgAiuseinfoQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAivisionrecgAiuseinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// AI秤-零食场景-识别结果输出
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("tip_iot_deepeye_snack_recognize_page_res_vo")]
        public List<TipIotDeepeyeSnackRecognizePageResVo> DataList { get; set; }

        /// <summary>
        /// 每页显示条数，默认 10
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
