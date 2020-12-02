using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationResultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpOperationResultQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }
    }
}
