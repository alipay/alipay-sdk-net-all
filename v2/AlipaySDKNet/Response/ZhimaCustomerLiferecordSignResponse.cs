using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerLiferecordSignResponse.
    /// </summary>
    public class ZhimaCustomerLiferecordSignResponse : AopResponse
    {
        /// <summary>
        /// 业务处理是否成功
        /// </summary>
        [XmlElement("process_success")]
        public bool ProcessSuccess { get; set; }

        /// <summary>
        /// 结果code
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// code对应的数值码
        /// </summary>
        [XmlElement("sub_code_number")]
        public long SubCodeNumber { get; set; }

        /// <summary>
        /// 异常码说明
        /// </summary>
        [XmlElement("sub_message")]
        public string SubMessage { get; set; }

        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [XmlElement("sub_success")]
        public bool SubSuccess { get; set; }
    }
}
