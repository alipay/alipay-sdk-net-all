using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaptureCreateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CaptureCreateDTO : AopObject
    {
        /// <summary>
        /// 请款单号
        /// </summary>
        [XmlElement("capture_no")]
        public string CaptureNo { get; set; }

        /// <summary>
        /// 外部业务请求号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
