using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSelleradmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainFactoringSelleradmitQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否已提交加白申请
        /// </summary>
        [XmlElement("exsit")]
        public string Exsit { get; set; }

        /// <summary>
        /// 不准入原因代码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 门店不准入原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 门店是否为不准入
        /// </summary>
        [XmlElement("refused")]
        public string Refused { get; set; }

        /// <summary>
        /// 是否加白成功
        /// </summary>
        [XmlElement("white")]
        public string White { get; set; }
    }
}
