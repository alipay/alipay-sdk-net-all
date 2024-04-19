using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDspcreativeUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDspcreativeUploadModel : AopObject
    {
        /// <summary>
        /// 验证码
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 创意列表
        /// </summary>
        [XmlArray("creatives")]
        [XmlArrayItem("dsp_creative")]
        public List<DspCreative> Creatives { get; set; }

        /// <summary>
        /// 外部dspId
        /// </summary>
        [XmlElement("dsp_id")]
        public string DspId { get; set; }
    }
}
