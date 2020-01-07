using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeUserContractQueryResponse.
    /// </summary>
    public class ZhimaCreditPeUserContractQueryResponse : AopResponse
    {
        /// <summary>
        /// true: 用户开通 false: 用户未开通
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 签约时间，格式：yyyy-MM-dd hh:mm:ss,未开通时值为空
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 签约成功时对应的服务签约号,未开通时值为空
        /// </summary>
        [XmlElement("sign_id")]
        public string SignId { get; set; }
    }
}
