using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalFxiaokeleadsCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalFxiaokeleadsCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [XmlElement("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 纷享销客调用海图创建商机接口成功后的返回值
        /// </summary>
        [XmlElement("result")]
        public FxiaokeCreateLeadsParams Result { get; set; }
    }
}
