using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationData Data Structure.
    /// </summary>
    [Serializable]
    public class OperationData : AopObject
    {
        /// <summary>
        /// 对应的运营数据内容
        /// </summary>
        [XmlElement("operation_data")]
        public string OperationData_ { get; set; }

        /// <summary>
        /// 运营数据类型枚举，如ALIPAY_PAY_COUNT代表支付宝支付笔数（含刷脸、扫码），详细枚举定义由产品给出
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }
    }
}
