using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataRiskservicecloudInputSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataRiskservicecloudInputSendModel : AopObject
    {
        /// <summary>
        /// 标识本次协商的数据输入的唯一编码，由蚂蚁定义
        /// </summary>
        [XmlElement("input_code")]
        public string InputCode { get; set; }

        /// <summary>
        /// 请求入参数据列表
        /// </summary>
        [XmlArray("params")]
        [XmlArrayItem("data_input_param")]
        public List<DataInputParam> Params { get; set; }

        /// <summary>
        /// 由客户端随机生成的关联本次调用的唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
