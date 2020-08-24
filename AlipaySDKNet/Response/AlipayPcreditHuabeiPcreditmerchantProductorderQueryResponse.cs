using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务返回成功与否标志
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购查询请求对象
        /// </summary>
        [XmlElement("data")]
        public HbProductOrderQueryResponse Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务错误描述信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }
    }
}
