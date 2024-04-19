using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTransferSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTransferSignModel : AopObject
    {
        /// <summary>
        /// 用以表明此次签约的外部业务号，同业务号签约行为幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务商代运营商户pid
        /// </summary>
        [XmlElement("sign_pid")]
        public string SignPid { get; set; }
    }
}
