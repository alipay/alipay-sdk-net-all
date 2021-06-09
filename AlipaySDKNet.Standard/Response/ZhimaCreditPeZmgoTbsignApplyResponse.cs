using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignApplyResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignApplyResponse : AopResponse
    {
        /// <summary>
        /// 签约申请返回的JSON信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
