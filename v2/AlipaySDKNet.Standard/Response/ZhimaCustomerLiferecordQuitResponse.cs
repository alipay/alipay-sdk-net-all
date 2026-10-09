using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerLiferecordQuitResponse.
    /// </summary>
    public class ZhimaCustomerLiferecordQuitResponse : AopResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("operate_success")]
        public bool OperateSuccess { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement("res_code")]
        public string ResCode { get; set; }

        /// <summary>
        /// 响应码对应编号
        /// </summary>
        [XmlElement("sub_code_number")]
        public long SubCodeNumber { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("sub_message")]
        public string SubMessage { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("sub_success")]
        public bool SubSuccess { get; set; }
    }
}
