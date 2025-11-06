using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateModifyDeductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateModifyDeductQueryModel : AopObject
    {
        /// <summary>
        /// 用于描述业务类型
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 服务商PID，用于校验服务商是否可以修改扣款渠道
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }
    }
}
