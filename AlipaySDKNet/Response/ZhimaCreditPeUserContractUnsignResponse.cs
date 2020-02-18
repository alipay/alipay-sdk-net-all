using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeUserContractUnsignResponse.
    /// </summary>
    public class ZhimaCreditPeUserContractUnsignResponse : AopResponse
    {
        /// <summary>
        /// 解约时间，格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 服务签约号，解约成功后，接口返回
        /// </summary>
        [XmlElement("sign_id")]
        public string SignId { get; set; }
    }
}
