using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandDirectAgentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDirectAgentQueryModel : AopObject
    {
        /// <summary>
        /// 服务商侧申请单号ID，由服务商在进件时传入
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
