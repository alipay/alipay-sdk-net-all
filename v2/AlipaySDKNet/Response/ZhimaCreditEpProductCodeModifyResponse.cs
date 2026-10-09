using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpProductCodeModifyResponse.
    /// </summary>
    public class ZhimaCreditEpProductCodeModifyResponse : AopResponse
    {
        /// <summary>
        /// 处理结果：true成功,false失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 更新结果描述
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }
    }
}
