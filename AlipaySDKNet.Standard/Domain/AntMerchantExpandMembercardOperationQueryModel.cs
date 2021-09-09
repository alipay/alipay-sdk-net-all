using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardOperationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardOperationQueryModel : AopObject
    {
        /// <summary>
        /// 安心充配置操作的流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
