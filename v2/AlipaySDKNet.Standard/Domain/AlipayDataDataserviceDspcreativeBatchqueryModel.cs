using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDspcreativeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDspcreativeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 验证码
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 创意查询请求
        /// </summary>
        [XmlArray("creative_query_request")]
        [XmlArrayItem("dsp_creative_query_request")]
        public List<DspCreativeQueryRequest> CreativeQueryRequest { get; set; }

        /// <summary>
        /// dsp唯一标识
        /// </summary>
        [XmlElement("dsp_id")]
        public string DspId { get; set; }
    }
}
